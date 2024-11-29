using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using testDevice.pub;
using System.IO;
using System.Xml.Linq;

namespace testDevice.Lora
{
    public partial class ConfigProtocolForm : Form
    {
        public ConfigProtocolForm()
        {
            InitializeComponent();
        }

        protocolItem curProtocolDataItem;
        protocolItem devAddrProtocolDataItem;
        configProtocol curConfigProtocol;
        SerialPort _serialPort;
        string controlCode = string.Empty;
        string receiveData = string.Empty;
        int cmdSendTimes = 0;
        Boolean authFlag = false;

        Frame frame;

        private void LoRawanTestForm_Load(object sender, EventArgs e)
        {
            frame = new frame97();
            loadData();

            if (!File.Exists(curConfigProtocol.filepath))
            {
                MessageBox.Show(curConfigProtocol.filepath + " 文件不存在！");
                return;
            }

            loadControlInfo();

            if (MainForm1.CONFIG["usertype"].ToString() == "customer") { 
                gbxOther.Visible = false;
            }
        }

        private void loadData()
        {
            List<configProtocol> listConfig = fileHelp.parseObjFromJsonFile<configProtocol>(paramGlobal.configFilePath, "protocol");
            foreach (configProtocol objconfig in listConfig)
            {
                if (objconfig.type == paramGlobal.protocol)
                {
                    curConfigProtocol = objconfig;
                }
            }
            if (curConfigProtocol != null) { 
                paramGlobal.password = curConfigProtocol.password;
                paramGlobal.user = curConfigProtocol.user;
                paramGlobal.protocolFilePath = curConfigProtocol.filepath;
            }

            if (!File.Exists(curConfigProtocol.filepath))
            {
                return;
            }

            List<protocolItem> data = new protocol().getDataSurce(paramGlobal.protocol, curConfigProtocol.filepath);

            cmbDataitem.DataSource = data;
            cmbDataitem.ValueMember = "keyFlag";
            cmbDataitem.DisplayMember = "keyInfo";

            foreach (protocolItem pitem in data)
            {
                if (pitem.keyFlag.ToUpper() == "C032" || pitem.keyFlag.ToUpper() == "0A81")
                {
                    devAddrProtocolDataItem = pitem;
                }
            }

            txtDevAddr.Text = string.IsNullOrEmpty(paramGlobal.devAddress) ? paramGlobal.broadcastAddress : paramGlobal.devAddress;
        }

        private void loadControlInfo()
        {
            labInfo.Text = "端口:" + paramGlobal.comPort + " 波特率:" + paramGlobal.baudRate;

            loadDataItem();
        }

        private void loadDataItem()
        {
            string dataItemStatus = string.Empty;
            curProtocolDataItem = (protocolItem)cmbDataitem.SelectedItem;
            if (_serialPort != null && _serialPort.IsOpen)
            {
                labPortSatus.Text = "running";
                labPortSatus.ForeColor = Color.Green;
                btnOpenCom.Text = "关闭串口";
            }
            else
            {
                labPortSatus.Text = "stop";
                labPortSatus.ForeColor = Color.Black;
                btnOpenCom.Text = "打开串口";
            }

            if (curProtocolDataItem.isCanRead)
            {
                dataItemStatus = "可读，";
                btnSend.Enabled = true;
            }
            else
            {
                dataItemStatus = "不可读，";
                btnSend.Enabled = false;
            }

            if (curProtocolDataItem.isCanEdit)
            {
                dataItemStatus += "可写";
                btnSet.Enabled = true;
            }
            else
            {
                dataItemStatus += "不可写";
                btnSet.Enabled = false;
            }

            labDataItemStatus.Text = dataItemStatus;
        }

        private void btnOpenCom_Click(object sender, EventArgs e)
        {

            _serialPort = mySerialPort.initSerallPort(_serialPort_DataReceived);
            if (btnOpenCom.Text == "关闭串口" && _serialPort != null) {
                _serialPort.Close();
                paramGlobal.comIsOpen = false;
            }
            else
            {
                if (_serialPort != null && _serialPort.IsOpen)
                {
                    paramGlobal.comIsOpen = true;
                }
                else
                {
                    paramGlobal.comIsOpen = false;
                }
            }

            loadDataItem();
        }

        private void btnSetDevAddr_Click(object sender, EventArgs e)
        {
            if (initFrame(true, paramGlobal.password + paramGlobal.user + dataConvert.strConverse(txtDevAddr.Text),true)) { sendDataToDev(frame.getCmdLine()); }
        }

        private void btnGetDevAddr_Click(object sender, EventArgs e)
        {
            if (initFrame(false, "",true)) { sendDataToDev(frame.getCmdLine()); }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            loadDataItem();
            if (initFrame(false, "")) { sendDataToDev(frame.getCmdLine()); }
        }

        private Boolean initFrame(Boolean isSet = false, string strData = "", Boolean isAddr = false)
        {
            if (isSet && string.IsNullOrEmpty(paramGlobal.devAddress))
            {
                MessageBox.Show("写数据时请先读取表号。");
                return false;
            }

            frame.data = strData;
            frame.addr = isSet ? paramGlobal.devAddress : paramGlobal.broadcastAddress;
            frame.meterType = paramGlobal.meterType;
            frame.serNum = paramGlobal.serNum;
            if (isAddr)
            {
                frame.dataFlag = devAddrProtocolDataItem.keyFlag;
                frame.controlChar = isSet ? devAddrProtocolDataItem.setControlCode : devAddrProtocolDataItem.readControlCode;
            }
            else {
                frame.dataFlag = curProtocolDataItem.keyFlag;
                frame.controlChar = isSet ? curProtocolDataItem.setControlCode : curProtocolDataItem.readControlCode;
            }
            return true;
        }

        private void sendDataToDev(string sendData) {
            if (_serialPort == null || !_serialPort.IsOpen)
            {
                MessageBox.Show("请先打开端口。");
                return;
            }

            log("发送: " + sendData, 1);
            paramGlobal.serNum++;

            byte[] btSend = dataConvert.getBytesFromStrHex(sendData);
            _serialPort.Write(btSend, 0, btSend.Length);
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            txtLogInfo.Text = string.Empty;
        }

        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(500);
            if (_serialPort == null || !_serialPort.IsOpen) { return; }
            int readCount = _serialPort.BytesToRead;
            byte[] btResponse = new byte[readCount];
            _serialPort.Read(btResponse, 0, readCount);

            receiveData = string.Empty;
            receiveData = dataConvert.getStrHexFromBytes(btResponse);

            //跨线程调用更新组件
            this.Invoke(
                new Action(() => {
                    afterReceive(receiveData);
                })
             );
        }

        //收到数据后的处理
        private void afterReceive(string theReceiveData)
        {
            if (theReceiveData.Replace("FC", "").Replace(" ", "").Length == 0){ return; }
            string dataFlag = frame.getDataFromCmd(receiveData.Trim(), "dataflag");
            string recData = frame.getDataFromCmd(receiveData.Trim(), dataFlag);
            string origindata = frame.getDataFromCmd(receiveData.Trim(), "origindata");
            controlCode = frame.getDataFromCmd(receiveData.Trim(), "controlCode");
            log("接收: " + theReceiveData);
            if(controlCode.Length !=0) { log("接收控制码: " + controlCode + " " + Convert.ToString(Convert.ToUInt32(controlCode, 16), 2)); }
            txtResult.Text = getResultData(recData, dataFlag);
            if (dataFlag.ToUpper() == "FE 85" || authFlag)
            {
                if (cmdSendTimes == 1)
                {
                    log("设备返回数据: " + origindata);
                    origindata = dataConvert.dataCalculate(origindata.Replace(" ", ""), "sub", "33");
                    origindata = dataConvert.strConverse(origindata).Replace(" ", "");
                    log("还原为原始数据: " + origindata);
                    string authData = auth.authEncrypt(origindata);
                    log("加密后数据: " + authData);
                    if (initFrame(true, paramGlobal.password + paramGlobal.user + authData, false)) { sendDataToDev(frame.getCmdLine()); }
                    log("加密后数据已发送。 ");
                    authFlag = true;
                }
                if (cmdSendTimes == 2)
                {
                    log("返回控制码: " + controlCode + " 认证" + (controlCode == "84" ? "成功！" : "失败"));
                    authFlag = false;
                }
                cmdSendTimes++;
            }
        }


        private string getResultData(string recData, string dataFlag) {
            if(dataFlag.ToUpper() == "C0 32" || dataFlag.ToUpper() == "0A 81") { 
                txtDevAddr.Text = recData; 
                paramGlobal.devAddress = recData;
            }
            if (curProtocolDataItem.fieldType == "string") {
                return dataConvert.getStringFromAscII(dataConvert.strConverse(recData));
            }            
            
            return recData;
        }

        private void log(string loginfo,int emptyRowCount = 0)
        {
            for (int i = 0; i < emptyRowCount; i++)
            {
                if(!string.IsNullOrEmpty(txtLogInfo.Text)) txtLogInfo.Text += Environment.NewLine;
            }
            txtLogInfo.Text += loginfo + Environment.NewLine;
        }

        private void rdoProtocol97_CheckedChanged(object sender, EventArgs e)
        {
            paramGlobal.protocol = "97";
            paramGlobal.broadcastAddress = "AA AA AA AA AA AA";
            frame = new frame97();
            loadData();
        }

        private void rdoProtocol07_CheckedChanged(object sender, EventArgs e)
        {
            paramGlobal.protocol = "07";
            paramGlobal.broadcastAddress = "AA AA AA AA AA AA";
            frame = new frame07();
            loadData();
        }

        private void rdoProtocol188_CheckedChanged(object sender, EventArgs e)
        {
            paramGlobal.protocol = "188";
            paramGlobal.broadcastAddress = "AA AA AA AA AA AA AA";
            frame = new frame188();
            loadData();
            loadMeterType();
            paramGlobal.meterType = cmbMeterType.SelectedValue.ToString();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            loadDataItem();
            if (initFrame(true, paramGlobal.password + paramGlobal.user + getHandleData())) { sendDataToDev(frame.getCmdLine()); }
        }

        private void cmbDataitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataItem();
        }

        private string getHandleData()
        {
            string strHandle = string.Empty;
            string strFieldType = string.Empty;
            strFieldType = curProtocolDataItem.fieldType;
            if (strFieldType == "string") {
                if (txtInsertValue1.Text.Trim() != "") strHandle += BitConverter.ToString(Encoding.ASCII.GetBytes(txtInsertValue1.Text.Trim())).Replace("-"," ");
                if (txtInsertValue2.Text.Trim() != "") strHandle += BitConverter.ToString(Encoding.ASCII.GetBytes(txtInsertValue2.Text.Trim())).Replace("-", " ");
                if (txtInsertValue3.Text.Trim() != "") strHandle += BitConverter.ToString(Encoding.ASCII.GetBytes(txtInsertValue3.Text.Trim())).Replace("-", " ");
                if (txtInsertValue4.Text.Trim() != "") strHandle += BitConverter.ToString(Encoding.ASCII.GetBytes(txtInsertValue4.Text.Trim())).Replace("-", " ");
            }
            else
            {
                strHandle += dataConvert.strConverse(txtInsertValue1.Text.Trim());
                strHandle += dataConvert.strConverse(txtInsertValue2.Text.Trim());
                strHandle += dataConvert.strConverse(txtInsertValue3.Text.Trim());
                strHandle += dataConvert.strConverse(txtInsertValue4.Text.Trim());
            }

            return strHandle;
        }

        private void btnClearInsert_Click(object sender, EventArgs e)
        {
            txtInsertValue1.Text = string.Empty;
            txtInsertValue2.Text = string.Empty;
            txtInsertValue3.Text = string.Empty;
            txtInsertValue4.Text = string.Empty;
        }

        private void loadMeterType()
        {
            cmbMeterType.DataSource = meterType.getMeterTypeList();
            cmbMeterType.ValueMember = "type";
            cmbMeterType.DisplayMember = "info";
        }

        private void cmbMeterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            paramGlobal.meterType = cmbMeterType.SelectedValue.ToString();
        }

        private void LoRawanTestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_serialPort != null && _serialPort.IsOpen)
            {
                paramGlobal.comIsOpen = false;
                _serialPort.Close();
            }
        }

        private void btnLoRaAuth_Click(object sender, EventArgs e)
        {
            frame = new frame97();
            curProtocolDataItem = new protocolItem() { keyFlag = "FE85", keyInfo = "", readControlCode = "01", setControlCode = "04" };
            if (initFrame(false, "")) { sendDataToDev(frame.getCmdLine()); }
            cmdSendTimes = 1;
        }
    }
}

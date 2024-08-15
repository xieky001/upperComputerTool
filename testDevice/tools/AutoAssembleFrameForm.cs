using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using testDevice.pub;

namespace testDevice.tools
{
    public partial class AutoAssembleFrameForm : Form
    {
        public AutoAssembleFrameForm()
        {
            InitializeComponent();
        }

        SerialPort _serialPort;
        const string frameConfigPath = "./protocoldata/frameConfig.json";
        frameConfig curFrameConfig;
        List<TextBox> textBoxes = new List<TextBox>();

        private void autoAssembleFrameForm_Load(object sender, EventArgs e)
        {
            loadFrameList();

            loadInfo();
        }

        private void loadFrameList()
        {
            List<frameConfig> listConfig = fileHelp.parseObjFromJsonFile<frameConfig>(frameConfigPath, "protocol");
            foreach (frameConfig objconfig in listConfig)
            {
                cmbFrameFormat.Items.Add(objconfig.type + "|" + objconfig.text);
            }
        }

        private void getFrameConfig(string configType) {
            List<frameConfig> listConfig = fileHelp.parseObjFromJsonFile<frameConfig>(frameConfigPath, "protocol");
            foreach (frameConfig objconfig in listConfig)
            {
                if (objconfig.type == configType) { 
                    curFrameConfig = objconfig;
                }
            }
        }

        private string getConfigType() {
            return cmbFrameFormat.Text.Split('|')[0];
        }

        private void cmbFrameFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            getFrameConfig(getConfigType());
            loadControls();
        }

        private void loadControls() {
            string[] frameDomainSpltes = curFrameConfig.format.Split('|');
            string[] domainInfo;
            int i = 0;

            this.panelFrame.Controls.Clear();
            textBoxes.Clear();
            foreach (string frameDomain in frameDomainSpltes) {
                i++;
                domainInfo = frameDomain.Split('&');

                createControl(domainInfo, 30, 40 * i, 400, 30);
            }
        }

        private void createControl(string[] domainInfo, int pointX, int pointY, int width, int height) {
            Label labControl = new Label();
            string defaultText = null;

            if (domainInfo.Length >= 4 && !string.IsNullOrEmpty(domainInfo[3]))
            {
                defaultText = domainInfo[3];
            }
            else
            {
                defaultText = null;
            }

            labControl.Location = new Point(pointX, pointY);
            labControl.Text = domainInfo[0] + "[" + domainInfo[2] + "]";

            this.panelFrame.Controls.Add(labControl);

            TextBox txtBox = new TextBox();

            txtBox.Name = getTxtBoxName(domainInfo[1]);
            txtBox.Location = new Point(pointX+100, pointY);
            txtBox.Size = new Size(width, height);
            txtBox.Text = defaultText;
            txtBox.Tag = domainInfo;

            txtBox.ReadOnly = (domainInfo.Length >= 5 && domainInfo[4].ToLower() == "true") ? true : false;

            this.panelFrame.Controls.Add(txtBox);
            textBoxes.Add(txtBox);
        }

        private void btnAssemble_Click(object sender, EventArgs e)
        {
            checkTextBox();
            calcLength();
            calcCS();
            //执行两次
            calcLength();
            calcCS();
            assembleFrame();
        }

        private void checkTextBox() {
            char[] strAllow = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'A', 'b', 'B', 'c', 'C', 'd', 'D', 'e', 'E', 'f', 'F', ' '};
            foreach (TextBox tb in textBoxes)
            {
                for(int i = 0; i < tb.Text.Length; i++)
                {
                    if (!strAllow.Contains(tb.Text[i]))
                    {
                        tb.Text = "";
                        break;
                    }

                }
            }
        }

        private void assembleFrame()
        {
            string result = string.Empty;
            foreach (TextBox tb in textBoxes)
            {
                result += dataHandle(tb);
            }
            txtFrameResult.Text = dataConvert.addBalnkStrHex(result);
        }

        private string dataHandle(TextBox tbx) {
            string[] formatList = (string[])tbx.Tag;
            string txt = tbx.Text;

            //倒序
            if (formatList.Length>=6 && formatList[5] == "true") {
                txt = dataConvert.strConverse(txt);
            }
            //+33
            if (formatList.Length >= 7 && formatList[6] == "true")
            {
                txt = dataConvert.dataCalculate(txt, "add", "33");
            }
            return txt;
        }

        private TextBox getTextBox(string txtBoxName) {
            foreach (TextBox tb in textBoxes) {
                if (tb.Name == txtBoxName) {
                    return tb;
                }
            }
            return null;
        }

        private void calcLength() {
            List<string> calcLenCalcs = new List<string>();

            foreach (string calc in curFrameConfig.calc_length.Split('|')) {
                calcLenCalcs = getTxtBoxNameList(calc.Split(':')[1]);
                TextBox tb = getTextBox(getTxtBoxName(calc.Split(':')[0]));

                tb.Text = dataConvert.strConverse(dataConvert.getHexFromInt(getTxtDataLen(calcLenCalcs), int.Parse(getFormatValue(tb.Name, 2))));
            }
        }

        private void calcCS()
        {
            List<string> calcCsCalcs = new List<string>();

            foreach (string calc in curFrameConfig.calc_cs.Split('|'))
            {
                calcCsCalcs = getTxtBoxNameList(calc.Split(':')[1]);
                TextBox tb = getTextBox(getTxtBoxName(calc.Split(':')[0]));

                tb.Text = dataConvert.getCsCode(getCsDataStr(calcCsCalcs));
            }
        }

        private string getCsDataStr(List<string> nameList) {
            string result = string.Empty;
            foreach (TextBox tb in textBoxes)
            {
                if (nameList.Contains(tb.Name))
                {
                    result += dataHandle(tb);
                }
            }
            return result;
        }

        private int getTxtDataLen(List<string> nameList) {
            int result = 0;
            foreach (TextBox tb in textBoxes)
            {
                if (nameList.Contains(tb.Name)) {
                    result += dataConvert.getDataLength(tb.Text);
                }
            }
            return result;
        }

        private List<string> getTxtBoxNameList(string txtRange) {
            string[] txtRanges1 = txtRange.Split(',');
            string[] txtRanges2;
            List<string> txtBoxNames = new List<string>();
            Boolean isInRange = false;

            foreach (string range in txtRanges1) {
                if (range.IndexOf("-") > 0)
                {
                    txtRanges2 = range.Split('-');
                    isInRange = false;
                    foreach (TextBox tb in textBoxes)
                    {
                        if (tb.Name == getTxtBoxName(txtRanges2[0])) {
                            isInRange = true;
                        }

                        if (isInRange) {
                            txtBoxNames.Add(tb.Name);
                        }

                        if (tb.Name == getTxtBoxName(txtRanges2[1]))
                        {
                            isInRange = false;
                        }
                    }
                }
                else {
                    txtBoxNames.Add(getTxtBoxName(range));
                }
            }


            return txtBoxNames;
        }

        private string getTxtBoxName(string strName) {
            return "txt_" + strName;
        }

        //根据控件名称获取指定位置的格式化信息
        private string getFormatValue(string txtBoxName,int position)
        {
            string[] frameDomainSpltes = curFrameConfig.format.Split('|');

            foreach (string frameDomain in frameDomainSpltes)
            {
                if (getTxtBoxName(frameDomain.Split('&')[1]) == txtBoxName) {
                    return frameDomain.Split('&')[position];
                }
            }
            return "";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            _serialPort = mySerialPort.initSerallPort(_serialPort_DataReceived);

            if (btnOpen.Text == "关闭串口" && _serialPort != null)
            {
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

            loadControl();
        }

        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(500);
            int readCount = _serialPort.BytesToRead;
            byte[] btResponse = new byte[readCount];
            _serialPort.Read(btResponse, 0, readCount);

            string str = dataConvert.getStrHexFromBytes(btResponse);

            //跨线程调用更新组件
            this.Invoke(
                new Action(() => {
                    txtReceive.Text = str;
                })
             );
        }

        private void loadControl()
        {
            if (_serialPort != null && _serialPort.IsOpen)
            {
                labStatus.Text = "running";
                labStatus.ForeColor = Color.Green;
                btnOpen.Text = "关闭串口";
            }
            else
            {
                labStatus.Text = "stop";
                labStatus.ForeColor = Color.Black;
                btnOpen.Text = "打开串口";
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (_serialPort == null || !_serialPort.IsOpen)
            {
                MessageBox.Show("请先打开端口。");
                return;
            }

            byte[] btSend = dataConvert.getBytesFromStrHex(txtFrameResult.Text.Trim());
            _serialPort.Write(btSend, 0, btSend.Length);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtReceive.Text = "";
        }

        private void loadInfo()
        {
            labInfo.Text = "端口:" + paramGlobal.comPort + " 波特率:" + paramGlobal.baudRate;
        }
    }
}

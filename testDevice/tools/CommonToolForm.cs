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
using testDevice.test;

namespace testDevice.Lora
{
    public partial class CommonToolForm : Form
    {
        SerialPort _serialPort;
        public CommonToolForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (_serialPort == null || !_serialPort.IsOpen)
            {
                MessageBox.Show("请先打开端口。");
                return;
            }

            byte[] btSend = dataConvert.getBytesFromStrHex(txtSend.Text.Trim());
            _serialPort.Write(btSend, 0, btSend.Length);
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

        private void txtSend_TextChanged(object sender, EventArgs e)
        {
            
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

        private void btnClearResponse_Click(object sender, EventArgs e)
        {
            txtReceive.Text = string.Empty;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butSub33_Click(object sender, EventArgs e)
        {
            txtTarget.Text = dataConvert.dataCalculate(txtSource.Text, "sub", "33");
        }

        private void btnAdd33_Click(object sender, EventArgs e)
        {
            txtTarget.Text = dataConvert.dataCalculate(txtSource.Text, "add", "33");
        }

        private void butClear33_Click(object sender, EventArgs e)
        {
            //txtSource.Text = string.Empty;
            txtTarget.Text = string.Empty;
         }

        private void btnConverse_Click(object sender, EventArgs e)
        {
            txtTarget.Text = dataConvert.strConverse(txtTarget.Text);
        }

        private void CommonToolForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_serialPort != null && _serialPort.IsOpen) { 
                _serialPort.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnCs_Click(object sender, EventArgs e)
        {
            txtCsRes.Text = dataConvert.getCsCode(txtCsSource.Text.Trim());
        }

        private void CommonToolForm_Load(object sender, EventArgs e)
        {
            loadInfo();
        }

        private void loadInfo() { 
            labInfo.Text = "端口:" + paramGlobal.comPort + " 波特率:" + paramGlobal.baudRate;
        }

        private void loadControl() {
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
    }
}

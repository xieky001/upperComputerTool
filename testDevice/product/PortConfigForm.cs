using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testDevice.pub;

namespace testDevice.product
{
    public partial class PortConfigForm : Form
    {
        public PortConfigForm()
        {
            InitializeComponent();
        }

        private void btnSavePortConfig_Click(object sender, EventArgs e)
        {
            savePort();
        }

        private void cmbComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            paramGlobal.comPort = cmbComPort.Text;
        }

        private void cmbBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            paramGlobal.baudRate = Convert.ToInt32(cmbBaudRate.Text);
        }

        private void PortConfigForm_Load(object sender, EventArgs e)
        {
            loadControl();
        }

        private void loadControl() {
            //端口加载
            List<string> arrPorts = mySerialPort.getComPorts();
            cmbComPort.Items.Clear();
            foreach (string item in arrPorts)
            {
                cmbComPort.Items.Add(item);
            }
            if (arrPorts.Count > 0)
            {
                cmbComPort.SelectedIndex = 0;
            }

            //比特率加载
            cmbBaudRate.Items.Add(1200);
            cmbBaudRate.Items.Add(2400);
            cmbBaudRate.Items.Add(4800);
            cmbBaudRate.Items.Add(9600);
            cmbBaudRate.Items.Add(14400);
            cmbBaudRate.Items.Add(19200);
            cmbBaudRate.Items.Add(115200);
            cmbBaudRate.SelectedIndex = 3;

            paramGlobal.comPort = cmbComPort.Text;
            paramGlobal.baudRate = Convert.ToInt32(cmbBaudRate.Text);
        }

        private void savePort() {
            paramGlobal.comPort = cmbComPort.Text;
            paramGlobal.baudRate = Convert.ToInt32(cmbBaudRate.Text);
        }
    }
}

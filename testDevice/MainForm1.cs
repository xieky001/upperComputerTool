using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testDevice.Lora;
using testDevice.MQTT;
using testDevice.product;
using testDevice.protocols;
using testDevice.pub;
using testDevice.pubform;
using testDevice.test;
using testDevice.tools;

namespace testDevice
{
    public partial class MainForm1 : Form
    {
        public static JObject CONFIG;

        public MainForm1()
        {
            InitializeComponent();
        }

        private void loRa水表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myForm = new CommonToolForm();
            myForm.MdiParent = this;
            myForm.Show();
        }

        private void 认证ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loRawan测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myForm = new ConfigProtocolForm();
            myForm.MdiParent = this;
            myForm.Show();
        }

        private void loRawan终端认证ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form authForm = new AuthForm();
            authForm.MdiParent = this;
            authForm.Show();
        }

        private void MainForm1_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromControl(this).WorkingArea;

            CONFIG = fileHelp.getJobjFromJson("./protocoldata/config.json");

            loadMenu();

            //loadPortConfigForm();
        }

        private void loadMenu() {
            switch (CONFIG["usertype"].ToString()) {
                case "customer":
                    其他ToolStripMenuItem.Visible=false;
                    工具ToolStripMenuItem.Visible = false;
                    break;
                case "test":
                    测试ToolStripMenuItem.Visible = false;
                    break;
                case "dev":
                    break;
                default:
                    break;
            }
        }

        private void 协议ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myForm = new ProtocolFormcs();
            myForm.MdiParent = this;
            myForm.Show();
        }

        private void 测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myForm = new TestFormcs();
            myForm.MdiParent = this;
            myForm.Show();
        }

        private void 组装帧ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myForm = new AutoAssembleFrameForm();
            myForm.MdiParent = this;
            myForm.Show();
        }

        private void 打开端口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadPortConfigForm();
        }

        private void loadPortConfigForm()
        {
            Form myForm = new PortConfigForm();
            myForm.MdiParent = this;
            myForm.Show();
        }

        private void 查看协议ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myForm = new ProtocolFormcs();
            myForm.MdiParent = this;
            myForm.Show();
        }

        private void 认证加密测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myForm = new AuthForm();
            myForm.MdiParent = this;
            myForm.Show();
        }

        private void 服务配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myForm = new ShowTextForm("", "protocoldata/mqttConfig.json", "",false);
            myForm.MdiParent = this;
            myForm.Show();
        }

        private void 消息发布ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myForm = new MqttSendForm();
            myForm.MdiParent = this;
            myForm.Show();
        }

        private void 消息订阅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myForm = new MqttReceiveForm();
            myForm.MdiParent = this;
            myForm.Show();
        }
    }
}

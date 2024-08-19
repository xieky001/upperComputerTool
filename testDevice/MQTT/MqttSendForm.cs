using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using testDevice.pub;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace testDevice.MQTT
{
    public partial class MqttSendForm : Form
    {
        private JObject mqttCONFIG;
        private MqttClient mqttClient = null;

        public MqttSendForm()
        {
            InitializeComponent();
        }

        private void MqttForm_Load(object sender, EventArgs e)
        {
            loadConfig();

            btnSend.Enabled = false;
        }

        private void loadConfig() {
            mqttCONFIG = fileHelp.getJobjFromJson("./protocoldata/mqttConfig.json");

            labHost.Text = mqttCONFIG["server"]["host"].ToString().Trim();
            labPort.Text = mqttCONFIG["server"]["port"].ToString().Trim();
            labUsername.Text = mqttCONFIG["server"]["username"].ToString().Trim();
            labPassword.Text = mqttCONFIG["server"]["password"].ToString().Trim();
            labTopic.Text = mqttCONFIG["server"]["testtopic"].ToString().Trim();
            labClient.Text = "mqttclient_" + new Random().Next(100000, 999999).ToString();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnConnect.Text == "连接")
                {
                    mqttClient = new MqttClient(labHost.Text,Int32.Parse(labPort.Text),false,null,null, MqttSslProtocols.TLSv1_2);

                    mqttClient.ConnectionClosed += mqtt_ConnectionClosedEventHandler;

                    mqttClient.Connect(labClient.Text, labUsername.Text, labPassword.Text,true,100);
                }
                else {
                    if (mqttClient.IsConnected)
                    {
                        mqttClient.Disconnect();
                        Thread.Sleep(100);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return;
            }

            if (mqttClient.IsConnected)
            {
                btnConnect.BackColor = Color.Green;
                btnConnect.Text = "断开";
                btnSend.Enabled = true;
                labServerStatus.Text = "";
            }
            else {
                btnConnect.BackColor = SystemColors.Control;
                btnConnect.Text = "连接";
                btnSend.Enabled = true;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSend.Text) || !mqttClient.IsConnected) return;

            byte[] byteArr = Encoding.UTF8.GetBytes(txtSend.Text);
            try
            {
                mqttClient.Publish(labTopic.Text, byteArr,MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE,true);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return;
            }

            rtxtSendMsg.ScrollToCaret();
            rtxtSendMsg.AppendText(Environment.NewLine);
            rtxtSendMsg.AppendText("【" + DateTime.Now + "】 主题：" + labTopic.Text + Environment.NewLine);
            rtxtSendMsg.AppendText("  " + txtSend.Text + Environment.NewLine);
            rtxtSendMsg.ScrollToCaret();

            txtSend.Text = "";
            txtSend.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtxtSendMsg.Clear();
        }

        private void mqtt_ConnectionClosedEventHandler(object sender, EventArgs e) {
            this.Invoke(new Action(() => {
                labServerStatus.Text = "服务器已断开！";
                btnConnect.BackColor = SystemColors.Control;
                btnConnect.Text = "连接";
            }));
        }
    }
}

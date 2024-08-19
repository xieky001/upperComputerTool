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
    public partial class MqttReceiveForm : Form
    {
        private JObject mqttCONFIG;
        private MqttClient mqttClient = null;

        public MqttReceiveForm()
        {
            InitializeComponent();
        }

        private void MqttForm_Load(object sender, EventArgs e)
        {
            loadConfig();
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

                    mqttClient.Subscribe(new string[] { labTopic.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });

                    mqttClient.MqttMsgPublishReceived += MqttMsgSubscribedEventHandler;
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
                labServerStatus.Text = "";
            }
            else {
                btnConnect.BackColor = SystemColors.Control;
                btnConnect.Text = "连接";
            }
        }

        private void MqttMsgSubscribedEventHandler(object sender, MqttMsgPublishEventArgs e)
        {
            this.Invoke(new Action(() =>
                {
                    rtxtReceiveMsg.ScrollToCaret();
                    rtxtReceiveMsg.AppendText(Environment.NewLine);
                    rtxtReceiveMsg.AppendText("【" + DateTime.Now + "】 主题：" + e.Topic + Environment.NewLine);
                    rtxtReceiveMsg.AppendText("  " + Encoding.UTF8.GetString(e.Message) + Environment.NewLine);
                    rtxtReceiveMsg.ScrollToCaret();
                })
            );
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtxtReceiveMsg.Clear();
        }

        private void mqtt_ConnectionClosedEventHandler(object sender, EventArgs e)
        {
            this.Invoke(new Action(() => {
                labServerStatus.Text = "服务器已断开！";
                btnConnect.BackColor = SystemColors.Control;
                btnConnect.Text = "连接";
            }));
        }
    }
}

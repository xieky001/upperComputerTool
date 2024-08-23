using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using testDevice.pub;

namespace testDevice.UDP
{
    public partial class UDPClientForm : Form
    {
        private JObject udpCONFIG, udpCONFIGRemote;
        private UdpClient udpClient;
        private int readBytesLength = 1024;
        private IPEndPoint endPoint,endPointRemote;
        private CancellationTokenSource cts;

        public UDPClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            loadConfig();
            loadConfigRemote();

            endPoint = new IPEndPoint(IPAddress.Parse(labHost.Text), int.Parse(labPort.Text));
        }

        private void loadConfig()
        {
            udpCONFIG = fileHelp.getJobjFromJson("./protocoldata/udpClientConfig.json");

            labHost.Text = udpCONFIG["server"]["host"].ToString().Trim();
            labPort.Text = udpCONFIG["server"]["port"].ToString().Trim();
            labUsername.Text = udpCONFIG["server"]["username"].ToString().Trim();
            labPassword.Text = udpCONFIG["server"]["password"].ToString().Trim();
        }

        private void loadConfigRemote()
        {
            udpCONFIGRemote = fileHelp.getJobjFromJson("./protocoldata/udpConfig.json");

            endPointRemote = new IPEndPoint(IPAddress.Parse(udpCONFIGRemote["server"]["host"].ToString().Trim()), int.Parse(udpCONFIGRemote["server"]["port"].ToString().Trim()));
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            startTask();
        }

        private void startTask() {
            try
            {
                if (btnConnect.Text == "连接")
                {
                    btnConnect.Enabled = false;
                    udpClient = new UdpClient(endPoint);
                    btnConnect.BackColor = Color.Green;
                    btnConnect.Text = "关闭";
                    labServerStatus.Text = "connecting";
                    btnConnect.Enabled = true;

                    cts = new CancellationTokenSource();
                    Task.Factory.StartNew(() => {
                        listenMsg();
                    }, cts.Token);
                }
                else
                {
                    btnConnect.Enabled = false;
                    cts?.Cancel();
                    btnConnect.BackColor = SystemColors.Control;
                    btnConnect.Text = "连接";
                    labServerStatus.Text = "no connected";
                    btnConnect.Enabled = true;
                    releaseClient();
                }
            }
            catch (Exception ex)
            {
                pubFuncs.showInfoByTextBox(this, rtxtSendMsg, "其他异常1：" + ex.Message, true);
                btnConnect.Enabled = true;
                return;
            }
        }

        private void listenMsg() {
            string msg = string.Empty;
            while (!cts.Token.IsCancellationRequested) {                
                try
                {
                    byte[] bytes = udpClient.Receive(ref endPointRemote);
                    if (bytes.Length != 0)
                    {
                        msg = Encoding.UTF8.GetString(bytes, 0, bytes.Length);

                        pubFuncs.showInfoByTextBox(this, rtxtSendMsg, "【server message】：" + msg);
                    }
                }
                catch (Exception ex) {
                    pubFuncs.showInfoByTextBox(this, rtxtSendMsg, "监听消息异常：" + ex.Message,true);
                    break;
                }
            }
            releaseClient();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (udpClient == null)
                {
                    MessageBox.Show("请先建立连接！");
                    return;
                }

                byte[] data = Encoding.UTF8.GetBytes(txtSend.Text);

                udpClient.Send(data, data.Length, endPointRemote);

                txtSend.Clear();
            }
            catch (Exception ex) {
                pubFuncs.showInfoByTextBox(this, rtxtSendMsg, "发送信息异常：" + ex.Message, true);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtxtSendMsg.Clear();
        }

        private void ClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            releaseClient();
        }

        private void releaseClient() {
            cts.Cancel();
            if (udpClient != null)
            {
                udpClient.Close();
                udpClient.Dispose();
                udpClient = null;
            }
        }
    }
}

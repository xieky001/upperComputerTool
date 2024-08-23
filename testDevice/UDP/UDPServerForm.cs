using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using testDevice.pub;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace testDevice.UDP
{
    public partial class UDPServerForm : Form
    {
        private JObject udpCONFIG, udpCONFIGRemote;
        private UdpClient udpListener;
        private IPEndPoint endPoint,remoteEndPoint;
        private CancellationTokenSource cts;

        public UDPServerForm()
        {
            InitializeComponent();
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {
            loadConfig();
            loadConfigRemote();

            endPoint = new IPEndPoint(IPAddress.Parse(labHost.Text), int.Parse(labPort.Text));
        }

        private void loadConfig() {
            udpCONFIG = fileHelp.getJobjFromJson("./protocoldata/udpConfig.json");

            labHost.Text = udpCONFIG["server"]["host"].ToString().Trim();
            labPort.Text = udpCONFIG["server"]["port"].ToString().Trim();
            labUsername.Text = udpCONFIG["server"]["username"].ToString().Trim();
            labPassword.Text = udpCONFIG["server"]["password"].ToString().Trim();
        }

        private void loadConfigRemote()
        {
            udpCONFIGRemote = fileHelp.getJobjFromJson("./protocoldata/udpClientConfig.json");

            remoteEndPoint = new IPEndPoint(IPAddress.Parse(udpCONFIGRemote["server"]["host"].ToString().Trim()), int.Parse(udpCONFIGRemote["server"]["port"].ToString().Trim()));
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text == "启动")
            {
                udpListener = new UdpClient(endPoint);
                btnConnect.BackColor = Color.Green;
                btnConnect.Text = "关闭";
                labServerStatus.Text = "Server is running!";

                cts = new CancellationTokenSource();
                Task.Factory.StartNew(() => {
                    startTask();
                }, cts.Token);
            }
            else
            {
                cts.Cancel();
                btnConnect.BackColor = SystemColors.Control;
                btnConnect.Text = "启动";
                labServerStatus.Text = "Server is stop!";
                releaseClient();
            }
        }

        private void startTask() {
            while (!cts.Token.IsCancellationRequested)
            {
                try
                {
                    byte[] receiveData = udpListener.Receive(ref remoteEndPoint);

                    if ((receiveData.Length > 0))
                    {
                        pubFuncs.showInfoByTextBox(this, rtxtSendMsg, Encoding.UTF8.GetString(receiveData, 0, receiveData.Length));
                    }                   
                }
                catch (Exception ex)
                {
                    pubFuncs.showInfoByTextBox(this, rtxtSendMsg, "监听客户端异常：" + ex.Message, true);
                }
            }

            releaseClient();
        }

        private void UDPServerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            releaseClient();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtxtSendMsg.Clear();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (udpListener == null) {
                MessageBox.Show("请先建立连接！");
                return;
            }
            byte[] byteData = Encoding.UTF8.GetBytes(txtSend.Text);
            udpListener.Send(byteData, byteData.Length, remoteEndPoint);
            txtSend.Clear();
        }

        private void releaseClient()
        {
            cts.Cancel();
            if (udpListener != null)
            {
                udpListener.Close();
                udpListener.Dispose();
                udpListener = null;
            }
        }
    }
}

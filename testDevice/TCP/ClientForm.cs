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

namespace testDevice.TCP
{
    public partial class ClientForm : Form
    {
        private JObject tcpCONFIG;
        private TcpClient tcpClient;
        private int readBytesLength = 1024;
        private IPEndPoint endPoint;
        private CancellationTokenSource cts;

        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            loadConfig();

            endPoint = new IPEndPoint(IPAddress.Parse(labHost.Text), int.Parse(labPort.Text));
        }

        private void loadConfig()
        {
            tcpCONFIG = fileHelp.getJobjFromJson("./protocoldata/tcpClientConfig.json");

            labHost.Text = tcpCONFIG["server"]["host"].ToString().Trim();
            labPort.Text = tcpCONFIG["server"]["port"].ToString().Trim();
            labUsername.Text = tcpCONFIG["server"]["username"].ToString().Trim();
            labPassword.Text = tcpCONFIG["server"]["password"].ToString().Trim();
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
                    tcpClient = new TcpClient();
                    while (!tcpClient.Connected)
                    {
                        tcpClient.Connect(endPoint);
                    }
                    btnConnect.BackColor = Color.Green;
                    btnConnect.Text = "关闭";
                    labServerStatus.Text = "connecting";
                    btnConnect.Enabled = true;
                }
                else
                {
                    btnConnect.Enabled = false;
                    tcpClient.Close();
                    cts?.Cancel();
                    btnConnect.BackColor = SystemColors.Control;
                    btnConnect.Text = "连接";
                    labServerStatus.Text = "no connected";
                    btnConnect.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("其他异常1：" + ex.Message);
                btnConnect.Enabled = true;
                return;
            }

            try
            {
                cts = new CancellationTokenSource();
                cts.Token.Register(() => {
                    showMessage(rtxtSendMsg, "线程已断开", false);
                });
                Task.Factory.StartNew(() => {
                    sendHeartBeat();
                }, cts.Token);

                Task.Factory.StartNew(() => {
                    listenMsg();
                },cts.Token);
            }
            catch (Exception ex) {
                MessageBox.Show("其他异常2：" + ex.Message);
                return;
            }
        }

        private void listenMsg() {
            if (!tcpClient.Connected) return;
            NetworkStream nStream = tcpClient.GetStream();
            string msg = string.Empty;
            while (!cts.Token.IsCancellationRequested) {
                byte[] bytes = new byte[readBytesLength];
                try
                {
                    int bytesReadLength = nStream.Read(bytes, 0, bytes.Length);
                    if (bytesReadLength != 0)
                    {
                        msg = Encoding.UTF8.GetString(bytes, 0, bytesReadLength);
                        if (msg != "[@TestClient@]") {
                            showMessage(rtxtSendMsg, "【server message】：" + msg, true);
                        }
                    }
                }
                catch (Exception ex) {
                    showMessage(rtxtSendMsg, "监听消息异常：" + ex.Message, true);
                    break;
                }
            }
            nStream.Close();
            nStream.Dispose();
            tcpClient.Close();
            tcpClient.Dispose();
        }

        //发送心跳信息
        private void sendHeartBeat() {
            if (!tcpClient.Connected) return;

            string message = assembleHeatBeatMsg();
            NetworkStream networkStream = tcpClient.GetStream();
            while (!cts.Token.IsCancellationRequested) {
                try
                {
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    networkStream.Write(data, 0, data.Length);
                    Thread.Sleep(2000);
                }
                catch (Exception ex) {
                    showMessage(rtxtSendMsg, "发送心跳异常：" + ex.Message, true);
                    break;
                }
            }
            networkStream.Close();
            networkStream.Dispose();
            tcpClient.Close();
            tcpClient.Dispose();
        }

        private string assembleHeatBeatMsg() { 
            string msg = string.Empty;
            string hostname = Dns.GetHostName();
            msg = "[@HeartBeat@]" + labUsername.Text;
            var ipaddress = Dns.GetHostAddresses(hostname);
            foreach (var ip in ipaddress) {
                if (ip.AddressFamily == AddressFamily.InterNetwork) {
                    msg += ":" + ip.ToString();
                }
            }

            return msg;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (tcpClient != null && tcpClient.Connected)
                {
                    NetworkStream nStream = tcpClient.GetStream();

                    byte[] data = Encoding.UTF8.GetBytes(txtSend.Text);

                    nStream.Write(data, 0, data.Length);

                    txtSend.Clear();
                }
                else {
                    MessageBox.Show("请先链接服务器!");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtxtSendMsg.Clear();
        }

        private void showMessage(TextBoxBase tbb, string msg, Boolean isTaskCall = false)
        {
            try
            {
                if (isTaskCall)
                {
                    this.Invoke(
                        new Action(() =>
                        {
                            tbb.AppendText(Environment.NewLine + msg);
                            tbb.ScrollToCaret();
                        })
                     );
                }
                else
                {
                    tbb.AppendText(Environment.NewLine + msg);
                    tbb.ScrollToCaret();
                }
            }
            catch { }
        }

        private void ClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (tcpClient != null && tcpClient.Connected) {
                    tcpClient.Close();
                    tcpClient.Dispose();
                }
            }
            catch { }
         }
    }
}

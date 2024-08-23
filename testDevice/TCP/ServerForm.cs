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

namespace testDevice.TCP
{
    public partial class ServerForm : Form
    {
        private JObject tcpCONFIG;
        private TcpListener tcpListener;
        private int readLength = 1024;
        private IPEndPoint endPoint;
        private CancellationTokenSource cts;
        private List<ClientInfo> tcpClients = new List<ClientInfo>();
        private static readonly object lockObj = new object();
        private ClientInfo curClient;

        public ServerForm()
        {
            InitializeComponent();
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {
            loadConfig();

            endPoint = new IPEndPoint(IPAddress.Parse(labHost.Text), int.Parse(labPort.Text));
        }

        private void loadConfig() {
            tcpCONFIG = fileHelp.getJobjFromJson("./protocoldata/tcpConfig.json");

            labHost.Text = tcpCONFIG["server"]["host"].ToString().Trim();
            labPort.Text = tcpCONFIG["server"]["port"].ToString().Trim();
            labUsername.Text = tcpCONFIG["server"]["username"].ToString().Trim();
            labPassword.Text = tcpCONFIG["server"]["password"].ToString().Trim();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text == "启动")
            {
                tcpListener = new TcpListener(endPoint);
                tcpListener.Start();

                btnConnect.BackColor = Color.Green;
                btnConnect.Text = "关闭";
                labServerStatus.Text = "Server is running!";

                cts = new CancellationTokenSource();
                Task.Factory.StartNew(() => {
                    startTask();
                }, cts.Token);

                Task.Factory.StartNew(() => {
                    testClients();
                }, cts.Token);
            }
            else
            {
                cts.Cancel();
                tcpListener.Stop();
                curClient = null;
                tcpClients.Clear();
                cmbClientlist.Items.Clear();

                btnConnect.BackColor = SystemColors.Control;
                btnConnect.Text = "启动";
                labServerStatus.Text = "Server is stop!";
            }
        }

        private void startTask() {
            while (!cts.Token.IsCancellationRequested)
            {
                try
                {
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();
                    if (tcpClient != null)
                    {
                        ClientInfo clientInfo = new ClientInfo() { Client = tcpClient };
                        tcpClients.Add(clientInfo);

                        Task.Factory.StartNew(() => {
                            handleClient(tcpClient);
                        }, cts.Token);
                    }
                }
                catch (Exception ex)
                {
                    pubFuncs.showInfoByTextBox(this, rtxtSendMsg, "监听客户端异常：" + ex.Message, true);
                }
            }
        }

        private void handleClient(TcpClient tcpClient) { 
            NetworkStream nStream = tcpClient.GetStream();
            while (!cts.Token.IsCancellationRequested) {
                byte[] getBytes = new byte[readLength];
                Boolean isHeartBeatMsg = false;
                try
                {
                    if (!tcpClient.Connected) break;
                    int byteLength = nStream.Read(getBytes, 0, getBytes.Length);
                    string message = Encoding.UTF8.GetString(getBytes, 0, byteLength);
                    string msgPrefix = string.Empty;
                    if(message.Length>=14 && message.Substring(0,13) == "[@HeartBeat@]")
                    {
                        isHeartBeatMsg = true;
                    }

                    if (isHeartBeatMsg)
                    {
                        message = message.Substring(13);
                        lock (lockObj)
                        {
                            ClientInfo item = tcpClients.FirstOrDefault(p => p.Client == tcpClient);
                            if (item != null && string.IsNullOrEmpty(item.IPAddress))
                            {
                                int itemIndex = tcpClients.IndexOf(item);
                                string[] splitStrs = message.Split(':');
                                if (splitStrs.Length > 1)
                                {
                                    item.Name = splitStrs[0];
                                    item.IPAddress = splitStrs[1];
                                }
                                else { 
                                    
                                }
                                tcpClients[itemIndex] = item;

                                if (!cmbClientlist.Items.Contains(item.Name + "：" + item.IPAddress))
                                {
                                    pubFuncs.cmbItemsManage(this, cmbClientlist, "add", item.Name + "：" + item.IPAddress);
                                }
                            }
                        }
                    }
                    else {
                        if (byteLength != 0)
                        {
                            ClientInfo item = tcpClients.FirstOrDefault(p => p.Client == tcpClient);
                            if (item != null)
                            {
                                if (string.IsNullOrEmpty(item.Name) && !string.IsNullOrEmpty(item.Client.Client.RemoteEndPoint.ToString())) {
                                    item.IPAddress = item.Client.Client.RemoteEndPoint.ToString();
                                    item.Name = "未知";
                                    pubFuncs.cmbItemsManage(this, cmbClientlist, "add", item.Name + "：" + item.IPAddress);
                                }
                                msgPrefix = "【" + item.Name + "：" + item.IPAddress + "】：";                                
                            }
                            pubFuncs.showInfoByTextBox(this, rtxtSendMsg, msgPrefix + message);
                        }
                    }
                }
                catch (Exception ex) {
                    pubFuncs.showInfoByTextBox(this, rtxtSendMsg, "处理消息异常：" + ex.Message, true);
                }
            }
            nStream.Close();
            closeClient(tcpClient);
        }

        private void closeClient(TcpClient tclient) {
            try
            {
                tclient.Close();
                ClientInfo item = tcpClients.FirstOrDefault(p => p.Client == tclient);
                if (item == null) return;
                lock (lockObj)
                {                    
                    pubFuncs.cmbItemsManage(this, cmbClientlist, "remove", item.Name + "：" + item.IPAddress);
                    tcpClients.Remove(item);
                }
                pubFuncs.showInfoByTextBox(this, rtxtSendMsg, item.Name + "：" + item.IPAddress + " 已断开", true);
            }
            catch (Exception ex)
            {
                pubFuncs.showInfoByTextBox(this, rtxtSendMsg, ex.Message, true);
            }
        }

        private void testClients() {
            NetworkStream ns;
            byte[] byteData;
            while (!cts.Token.IsCancellationRequested)
            {
                foreach (var item in tcpClients)
                {
                    try
                    {
                        ns = item.Client.GetStream();
                        byteData = Encoding.UTF8.GetBytes("[@TestClient@]");
                        ns.Write(byteData, 0, byteData.Length);
                    }
                    catch (Exception ex) {
                        tcpClients.Remove(item);
                        pubFuncs.cmbItemsManage(this, cmbClientlist, "remove", item.Name + "：" + item.IPAddress);
                        break;
                    }
                }
                Thread.Sleep(3000);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtxtSendMsg.Clear();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (curClient == null || cmbClientlist.SelectedItem == null)
            {
                MessageBox.Show("请选择客户端！");
                return;
            }

            NetworkStream ns = curClient.Client.GetStream();
            byte[] byteData = Encoding.UTF8.GetBytes(txtSend.Text);
            ns.Write(byteData, 0, byteData.Length);
            txtSend.Clear();
        }

        private void cmbClientlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in tcpClients)
            {
                if (cmbClientlist.SelectedItem.ToString() == (item.Name + "：" + item.IPAddress)) { 
                    curClient = item;
                }
            }
        }

        private void ServerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            releaseClient();
        }

        private void releaseClient()
        {
            cts.Cancel();
            if (tcpListener != null)
            {
                tcpListener.Stop();
                tcpListener = null;
            }
        }
    }
}

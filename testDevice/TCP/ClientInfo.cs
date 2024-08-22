using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace testDevice.TCP
{
    internal class ClientInfo
    {
        public TcpClient Client { get; set; }
        // 客户端名字
        public string Name { get; set; }
        // 客户端ip地址
        public string IPAddress { get; set; }
    }
}

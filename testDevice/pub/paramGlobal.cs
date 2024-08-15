using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDevice.pub
{
    public class paramGlobal
    {
        public static string protocol = "97";
        public static string comPort = string.Empty;
        public static Boolean comIsOpen = false;
        public static int baudRate = 2400;
        public static Parity parity = Parity.Even;
        public static StopBits stopBits = StopBits.One;
        public static int dataBits = 8;
        public static string broadcastAddress = "AA AA AA AA AA AA";
        public static string devAddress = string.Empty;
        public static string meterType = string.Empty;
        public static int serNum = 0;
        public static int chkComPortCount = 30;
        public static string password = string.Empty;
        public static string user = string.Empty;
        public static string configFilePath = "./protocoldata/config.json";
        public static string protocolFilePath = "";

    }
}

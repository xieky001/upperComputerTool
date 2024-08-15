using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testDevice.pub;
using testDevice.test;

namespace testDevice.pub
{
    public static class mySerialPort
    {
        public static SerialPort _SerialPort;

        public static SerialPort initSerallPort(SerialDataReceivedEventHandler DataReceivedMethod)
        {
            try
            {
                if (_SerialPort != null)
                {
                    _SerialPort.Close();
                }
                _SerialPort = new SerialPort(paramGlobal.comPort);
                _SerialPort.BaudRate = paramGlobal.baudRate;
                _SerialPort.Parity = paramGlobal.parity;
                _SerialPort.StopBits = paramGlobal.stopBits;
                _SerialPort.DataBits = paramGlobal.dataBits;
                _SerialPort.DataReceived += DataReceivedMethod;
                _SerialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            return _SerialPort;
        }

        public static List<string> getComPorts() 
        {
            SerialPort serialPort;
            string portName;
            List<string> ports = new List<string>();
            int num = 0;
            for (int i = 0; i < paramGlobal.chkComPortCount; i++) {
                portName = "COM" + i.ToString();
                serialPort = new SerialPort(portName);
                try
                {
                    serialPort.Open();
                    ports.Add(portName);
                    serialPort.Close();
                }
                catch (Exception ex) { }
            }
            return ports;
        }
    }
}

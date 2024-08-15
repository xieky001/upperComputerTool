using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace testDevice.pub
{
    public class Frame
    {
        public string startChar = "68";
        public string csChar = string.Empty;
        public string endChar = "16";
        public string dataLength;
        public string cmdLine = string.Empty;
        public string dataArea = string.Empty;

        public string addr { get; set; }
        public string controlChar { get; set; }
        public string dataFlag { get; set; }
        public string data { get; set; }
        public string meterType { get; set; }
        public int serNum { get; set; }

        public virtual string getDataFromCmd(string cmdline, string dataType) { return ""; }

        public virtual string getCmdLine() { return ""; }
    }
    public class frame97 : Frame
    {
        public override string getCmdLine()
        {
            addr = dataConvert.strConverse(addr);
            dataFlag = dataConvert.strConverse(dataFlag);

            dataArea = dataFlag + data; //因为要分组翻转，暂时不处理，在外层处理
            dataArea = dataConvert.dataCalculate(dataArea, "add", "33");

            dataLength = (dataArea.Replace(" ", "").Length / 2).ToString("X2");

            csChar = dataConvert.getCsCode(startChar + addr + startChar + controlChar + dataLength + dataArea);

            cmdLine = string.Format("{0} {1} {0} {2} {3} {4} {5} {6}", startChar, addr, controlChar, dataLength, dataArea, csChar, endChar);

            return cmdLine;
        }

        //从接收命令行中提取所需要的数据用来展示结果
        public override string getDataFromCmd(string cmdline, string dataType)
        {
            string mystr = string.Empty;
            string newCmdline = cmdline.Replace(" ", "");
            int beginPos = newCmdline.IndexOf("68");
            switch (dataType)
            {
                case "dataflag":    //数据标识符
                    if (newCmdline.Length <= 24) { return ""; }
                    mystr = newCmdline.Substring(beginPos + 20, 4);
                    //减33后倒序
                    mystr = dataConvert.dataCalculate(mystr, "sub", "33");
                    mystr = dataConvert.strConverse(mystr);
                    break;
                case "origindata":  //返回数据域的原始数据
                    if (newCmdline.Length <= 28) { return ""; }
                    mystr = newCmdline.Substring(beginPos + 24, newCmdline.LastIndexOf("16") - 2 - 24 - beginPos);
                    break;
                case "controlCode":
                    if (newCmdline.Length <= 22) { return ""; }
                    mystr = newCmdline.Substring(beginPos + 16, 2);
                    break;
                default:
                    //默认把数据标识后的数据取出来
                    if (newCmdline.Length <= 28) { return ""; }
                    mystr = newCmdline.Substring(beginPos + 24, newCmdline.LastIndexOf("16") - 2 - 24 - beginPos);
                    //减33后倒序
                    mystr = dataConvert.dataCalculate(mystr, "sub", "33");
                    mystr = handleDataOrderByDataFlag(mystr, getDataFromCmd(cmdline, "dataflag"));
                    break;
            }
            return mystr;
        }

        public string handleDataOrderByDataFlag(string oldData, string dataFlag)
        {
            string newData = string.Empty;
            oldData = oldData.Replace(" ", "");
            dataFlag = dataFlag.Replace(" ", "").ToUpper();
            switch (dataFlag)
            {
                case "FA0C":    //分成三组 DEVEUI、APPEUI、APPKEY
                    newData = "DEVEUI: " + oldData.Substring(0, 16) + Environment.NewLine;
                    newData += "APPEUI: " + oldData.Substring(16, 16) + Environment.NewLine;
                    newData += "APPKEY: " + oldData.Substring(32) + Environment.NewLine;
                    break;
                case "FA0D":    //分成三组 DevAddr、NwkSKey、AppSKey
                    newData = "DevAddr: " + oldData.Substring(0, 8) + Environment.NewLine;
                    newData += "NwkSKey: " + oldData.Substring(8, 32) + Environment.NewLine;
                    newData += "AppSKey: " + oldData.Substring(40) + Environment.NewLine;
                    break;
                default:
                    newData = dataConvert.strConverse(oldData);
                    break;
            }
            return newData;
        }
    }

    public class frame07 : Frame
    {
        public override string getDataFromCmd(string cmdline, string dataType) {
            string mystr = string.Empty;
            string newCmdline = cmdline.Replace(" ", "");
            int beginPos = newCmdline.IndexOf("68");
            switch (dataType)
            {
                case "dataflag":    //数据标识符
                    if (newCmdline.Length <= 26) { return ""; }
                    mystr = newCmdline.Substring(beginPos + 20, 8);
                    //减33后倒序
                    mystr = dataConvert.dataCalculate(mystr, "sub", "33");
                    mystr = dataConvert.strConverse(mystr);
                    break;
                case "origindata":  //返回数据域的原始数据
                    if (newCmdline.Length <= 28) { return ""; }
                    mystr = newCmdline.Substring(beginPos + 28, newCmdline.LastIndexOf("16") - 2 - 28 - beginPos);
                    break;
                case "controlCode":
                    if (newCmdline.Length <= 22) { return ""; }
                    mystr = newCmdline.Substring(beginPos + 16, 2);
                    break;
                default:
                    //默认把数据标识后的数据取出来
                    if (newCmdline.Length <= 28) { return ""; }
                    mystr = newCmdline.Substring(beginPos + 28, newCmdline.LastIndexOf("16") - 2 - 24 - beginPos);
                    //减33后倒序
                    mystr = dataConvert.dataCalculate(mystr, "sub", "33");
                    break;
            }
            return mystr;
        }

        public override string getCmdLine() {

            addr = dataConvert.strConverse(addr);
            dataFlag = dataConvert.strConverse(dataFlag);

            dataArea = dataFlag + data; //因为要分组翻转，暂时不处理，在外层处理
            dataArea = dataConvert.dataCalculate(dataArea, "add", "33");

            dataLength = (dataArea.Replace(" ", "").Length / 2).ToString("X2");

            csChar = dataConvert.getCsCode(startChar + addr + startChar + controlChar + dataLength + dataArea);

            cmdLine = string.Format("{0} {1} {0} {2} {3} {4} {5} {6}", startChar, addr, controlChar, dataLength, dataArea, csChar, endChar);

            return cmdLine;
        }
    }

    public class frame188 : Frame
    {
        //获取执行命令
        public override string getCmdLine() {
            addr = dataConvert.strConverse(addr);
            dataFlag = dataConvert.strConverse(dataFlag);
            string nSer = (serNum % 256).ToString("X2");

            dataArea = dataFlag + " " + nSer + " " + data; //因为要分组翻转，暂时不处理，在外层处理

            dataLength = (dataArea.Replace(" ", "").Length / 2).ToString("X2");

            csChar = dataConvert.getCsCode(startChar + meterType + addr + controlChar + dataLength + dataArea);

            cmdLine = string.Format("FE FE {0} {1} {2} {3} {4} {5} {6} {7}", startChar, meterType, addr, controlChar, dataLength, dataArea, csChar, endChar);

            return cmdLine;
        }

        //从接收命令行中提取所需要的数据用来展示结果
        public override string getDataFromCmd(string cmdline, string dataType)
        {
            string mystr = string.Empty;
            string newCmdline = cmdline.Replace(" ", "");
            int beginPos = newCmdline.IndexOf("68");
            switch (dataType.Replace(" ",""))
            {
                case "dataflag":    //数据标识符
                    if (newCmdline.Length <= 26) { return ""; }
                    mystr = newCmdline.Substring(beginPos + 22, 4);
                    mystr = dataConvert.strConverse(mystr);
                    break;
                case "0A81":
                    //地址需要从地址域获取
                    if (newCmdline.Length < 32) { return ""; }
                    mystr = newCmdline.Substring(beginPos + 4, 14);
                    mystr = dataConvert.strConverse(mystr);
                    break;
                case "controlCode":
                    if (newCmdline.Length <= 22) { return ""; }
                    mystr = newCmdline.Substring(beginPos + 18, 2);
                    break;
                default:
                    //默认把数据标识后的数据取出来
                    if (newCmdline.Length <= 32) { return ""; }
                    mystr = newCmdline.Substring(beginPos + 28, newCmdline.LastIndexOf("16") - 2 - 28);
                    mystr = handleDataOrderByDataFlag(mystr, getDataFromCmd(cmdline, "dataflag"));
                    break;
            }
            return mystr;
        }

        public string handleDataOrderByDataFlag(string oldData, string dataFlag)
        {
            string newData = string.Empty;
            oldData = oldData.Replace(" ", "");
            dataFlag = dataFlag.Replace(" ", "").ToUpper();
            switch (dataFlag)
            {
                case "901F":    //分成三组 DEVEUI、APPEUI、APPKEY
                    newData = "水量: " + dataConvert.strConverse(oldData.Substring(0, 8)) + Environment.NewLine;
                    newData += "单位: " + dataConvert.strConverse(oldData.Substring(8, 2)) + Environment.NewLine;
                    newData += "表状态: " + dataConvert.strConverse(oldData.Substring(oldData.Length-4,4)) + Environment.NewLine;
                    break;
                default:
                    newData = dataConvert.strConverse(oldData);
                    break;
            }
            return newData;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDevice.pub
{
    public static class dataConvert
    {
        //字节数组转换成16进制输出，字节数组中存的是ASCII码
        public static string getStrHexFromBytes(byte[] bytes)
        {
            string txt = string.Empty;
            if (bytes != null)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    txt += bytes[i].ToString("X2") + " ";
                }
            }
            return txt.Trim();
        }

        //16进制字符串转换成字节数组，字节数组中存的是ASCII码
        public static byte[] getBytesFromStrHex(string strHex)
        {
            strHex = strHex.Replace(" ", "");
            int btLen = strHex.Length / 2;
            byte[] btHexCmd = new byte[btLen];
            for (int i = 0; i < btLen; i++)
            {
                btHexCmd[i] = Convert.ToByte(strHex.Substring(i * 2, 2), 16);
            }
            return btHexCmd;
        }

        //数字转换成16进制输出，指定字节数
        public static string getHexFromInt(int num,int byteCount)
        {
            string result = num.ToString("X2");
            string str = string.Empty;

            if (byteCount * 2 > result.Length) {
                for (int i = 0; i < byteCount * 2 - result.Length; i++) {
                    str += "0";
                }
            }
            result = str + result;

            return result;
        }

        //16进制计算后返回显示字符串
        public static string dataCalculate(string strHex,string symbol,string strHexInterval)
        {
            strHex = strHex.Replace(" ", "");
            int btLen = strHex.Length / 2;
            string txt = string.Empty;
            string strTran = string.Empty;
            int intInterval = Convert.ToInt32(strHexInterval, 16);
            
            for (int i = 0; i < btLen; i++)
            {
                if (symbol.ToLower() == "add")
                {
                    strTran = (Convert.ToInt32(strHex.Substring(i * 2, 2), 16) + intInterval).ToString("X2");
                    txt += (strTran.Length > 2 ? strTran.Substring(strTran.Length - 2, 2) : strTran) + " ";
                }
                else if (symbol.ToLower() == "sub")
                {
                    strTran = (Convert.ToInt32(strHex.Substring(i * 2, 2), 16) - intInterval).ToString("X2");
                    txt += (strTran.Length > 2 ? strTran.Substring(strTran.Length - 2, 2) : strTran) + " ";
                }
                else {
                    txt += "";
                }
            }
            return txt.Trim();
        }

        //顺序翻转后返回
        public static string strConverse(string strHex) {
            strHex = strHex.Replace(" ", "");
            int btLen = strHex.Length / 2;
            string txt = string.Empty;
            for (int i = btLen-1; i >= 0; i--)
            {
                txt += strHex.Substring(i * 2, 2) + " ";
            }
            return txt.Trim();
        }

        //计算校验码
        public static string getCsCode(string strHex) {
            strHex = strHex.Replace(" ", "");
            int btLen = strHex.Length / 2;
            string txt = string.Empty;
            int sum = 0;
            int modnum = 0;
            for (int i = 0; i < btLen; i++)
            {
                sum += Convert.ToInt32(strHex.Substring(i * 2, 2),16);
            }
            modnum = sum % 256;
            txt = modnum.ToString("X2");
            return txt;
        }

        //十六进制每两位加一个空格，展示出来会好看些
        public static string addBalnkStrHex(string strHex) {
            strHex = strHex.Replace(" ", "");
            int btLen = strHex.Length / 2;
            string txt = string.Empty;
            for (int i = 0; i < btLen; i++)
            {
                txt += strHex.Substring(i * 2, 2) + " ";
            }
            return txt.Trim();
        }

        //结果是字符串的字节数量
        public static int getDataLength(string str)
        {
            return (str.Replace(" ", "").Length / 2);
        }

        //ASCII码串转换成字符串
        public static string getStringFromAscII(string recData) {
            recData = recData.Replace(" ", "");
            int btLen = recData.Length / 2;
            string txt = string.Empty;
            for (int i = 0; i < btLen; i++)
            {;
                txt += Convert.ToChar(Convert.ToInt32(recData.Substring(i * 2, 2), 16));
            }
            return txt.Trim();
        }
    }
}

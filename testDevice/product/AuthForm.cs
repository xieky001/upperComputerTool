using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testDevice.pub;

namespace testDevice.Lora
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string strHex = txtSource.Text.Trim().Replace(" ", "");

            if (strHex.Length <= 0) { return; }

            int btLen = strHex.Length / 2;
            string strHex1 = dataConvert.strConverse(strHex.Substring(0, btLen));
            byte[] mybytes1 = dataConvert.getBytesFromStrHex(strHex1);
            auth.Card_data(mybytes1, 0x89);
            string strRes1 =  dataConvert.getStrHexFromBytes(mybytes1);
            myLog("第一段16进制:" + strHex1);
            myLog("第一段加密后:" + strRes1);

            string strHex2 = dataConvert.strConverse(strHex.Substring(btLen, btLen));
            byte[] mybytes2 = dataConvert.getBytesFromStrHex(strHex2);
            auth.Card_data(mybytes2, 0x89);
            string strRes2 = dataConvert.getStrHexFromBytes(mybytes2);

            myLog("第二段16进制:" + strHex2);
            myLog("第二段加密后:" + strRes2);

            //strHex = dataConvert.strConverse(strRes1 + " " + strRes2);
            //myLog("倒序后:" + strHex);

            txtTarget.Text =  strRes2 +" "+ strRes1;
        }

        private void myLog(string strLog)
        { 
            labLog.Text += strLog + "\n";
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}

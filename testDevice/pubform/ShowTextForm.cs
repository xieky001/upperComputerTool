using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testDevice.pub;

namespace testDevice.pubform
{
    public partial class ShowTextForm : Form
    {
        string txtFormat;
        string filePath;
        string strText;

        public ShowTextForm(string pFormat,string pFilePath,string pStrText)
        {
            InitializeComponent();

            txtFormat = pFormat;
            filePath = pFilePath;
            strText = pStrText;
        }

        private void ShowTextForm_Load(object sender, EventArgs e)
        {
            labInfo.Text += txtFormat;
            if (!string.IsNullOrEmpty(filePath.Trim()))
            {
                labInfo.Text += "; 文件路径：" + filePath;
                showFileText();
            }

            if (!string.IsNullOrEmpty(strText.Trim()))
            {
                showFileText();
            }
        }

        private void showFileText() {
            textShowResult.Text = dataFormat(fileHelp.getStringFromFile(filePath));
        }

        private void showStringText()
        {
            textShowResult.Text = dataFormat(strText);
        }

        private string dataFormat(string strs) {
            string strResult = string.Empty;
            switch (txtFormat.ToLower()) {
                case "json":
                    strResult = JsonConvert.DeserializeObject(strs).ToString();
                    break;
                default:
                    strResult = strs;
                    break;
            }
            return strResult;
        }
    }
}

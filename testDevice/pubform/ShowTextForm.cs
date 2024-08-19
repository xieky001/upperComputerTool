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
        string fileContent;
        string txtFormat;
        string filePath;
        string strText;
        Boolean isWrite;

        public ShowTextForm(string pFormat,string pFilePath,string pStrText,Boolean pIsWrite = false)
        {
            InitializeComponent();

            txtFormat = pFormat;
            filePath = pFilePath;
            strText = pStrText;
            isWrite = pIsWrite;

            if (isWrite) {
                txtShowResult.ReadOnly = false;
                btnFormat.Visible = true;
                btnSave.Visible = true;
            }
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
            txtShowResult.Text = dataFormat(fileHelp.getStringFromFile(filePath));
        }

        private void showStringText()
        {
            txtShowResult.Text = dataFormat(strText);
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

        private void btnFormat_Click(object sender, EventArgs e)
        {
            fileContent = strJsonFormat();
            if (string.IsNullOrEmpty(fileContent)) return;

            MessageBox.Show("格式正确!");
        }

        private string strJsonFormat() {
            try
            {
                return JsonConvert.DeserializeObject(txtShowResult.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fileContent = strJsonFormat();
            if (fileContent == "") return;

            if (fileHelp.saveFile(filePath, fileContent)){
                MessageBox.Show("保存成功！");
                showFileText();
            }
        }
    }
}

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
        Boolean isCanWrite;

        public ShowTextForm(string pFormat,string pFilePath,string pStrText,Boolean pIsCanWrite = false,Boolean pIsCanSelectFile = false)
        {
            InitializeComponent();

            txtFormat = pFormat;
            filePath = pFilePath;
            strText = pStrText;
            isCanWrite = pIsCanWrite;

            if (isCanWrite) {
                txtShowResult.ReadOnly = false;
                btnFormat.Visible = true;
                btnSave.Visible = true;
            }
            if (pIsCanSelectFile) {
                cmbFiles.Enabled = true;
            }
            else {
                cmbFiles.Enabled = false;
            }
        }

        private void ShowTextForm_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFormat))
            {
                labInfo.Text += "json";
            }
            else {
                labInfo.Text += txtFormat;
            }

            loadConfigFiles();

            if (!string.IsNullOrEmpty(filePath.Trim()))
            {
                showFileText();
            }

            if (!string.IsNullOrEmpty(strText.Trim()))
            {
                cmbFiles.Visible = false;
                showStringText();
            }
        }

        //加载文件列表
        private void loadConfigFiles() { 
            string[] files = Directory.GetFiles("protocoldata");
            foreach (string file in files) { 
                cmbFiles.Items.Add(file);
                if (filePath == file) { 
                    cmbFiles.SelectedItem = file;
                }
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

        private void cmbFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            filePath = cmbFiles.SelectedItem.ToString();
            showFileText();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using testDevice.pub;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace testDevice.test
{
    public partial class TestFormcs : Form
    {
        public TestFormcs()
        {
            InitializeComponent();
        }

        string URL = "https://cn.bing.com/search?q=";
 
        private void TestFormcs_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            urlGO();
        }

        private void urlGO() {
            string searchUrl = URL + WebUtility.UrlEncode(txtText.Text.Trim());
            webShow.Navigate(searchUrl);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webShow.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webShow.GoForward();
        }

        private void webShow_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            foreach (HtmlElement links in this.webShow.Document.Links)
            {
                links.SetAttribute("target", "_self");
            }
            foreach (HtmlElement form in this.webShow.Document.Forms)
            {
                form.SetAttribute("target", "_self");
            }
        }

        private void txtText_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                urlGO();
            }
        }
    }
}

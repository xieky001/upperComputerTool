using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testDevice.protocols
{
    public partial class ProtocolFormcs : Form
    {
        public ProtocolFormcs()
        {
            InitializeComponent();
        }

        private void cmbDocs_SelectedIndexChanged(object sender, EventArgs e)
        {
            openDocs(cmbDocs.Text);
        }

        private void ProtocolFormcs_Load(object sender, EventArgs e)
        {
            cmbDocs.Items.Add("./docs/CJ T 188.pdf");
            cmbDocs.Items.Add("./docs/DL T 645-2007.pdf");
            cmbDocs.Items.Add("./docs/DLT 645-1997.pdf");
            cmbDocs.Items.Add("./docs/集中器本地通信模块接口协议.pdf");
        }

        private void openDocs(string filePath)
        {
            pdfViewer1.Document = PdfDocument.Load(filePath);
        }
    }
}

namespace testDevice.protocols
{
    partial class ProtocolFormcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pdfViewer1 = new PdfiumViewer.PdfViewer();
            this.cmbDocs = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.AutoSize = true;
            this.pdfViewer1.Location = new System.Drawing.Point(9, 51);
            this.pdfViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.ShowToolbar = false;
            this.pdfViewer1.Size = new System.Drawing.Size(1360, 651);
            this.pdfViewer1.TabIndex = 2;
            this.pdfViewer1.ZoomMode = PdfiumViewer.PdfViewerZoomMode.FitWidth;
            // 
            // cmbDocs
            // 
            this.cmbDocs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocs.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbDocs.FormattingEnabled = true;
            this.cmbDocs.Location = new System.Drawing.Point(9, 13);
            this.cmbDocs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDocs.Name = "cmbDocs";
            this.cmbDocs.Size = new System.Drawing.Size(363, 25);
            this.cmbDocs.TabIndex = 3;
            this.cmbDocs.SelectedIndexChanged += new System.EventHandler(this.cmbDocs_SelectedIndexChanged);
            // 
            // ProtocolFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 713);
            this.Controls.Add(this.cmbDocs);
            this.Controls.Add(this.pdfViewer1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProtocolFormcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProtocolFormcs";
            this.Load += new System.EventHandler(this.ProtocolFormcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private PdfiumViewer.PdfViewer pdfViewer1;
        private System.Windows.Forms.ComboBox cmbDocs;
    }
}
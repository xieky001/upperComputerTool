namespace testDevice.pubform
{
    partial class ShowTextForm
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
            this.textShowResult = new System.Windows.Forms.TextBox();
            this.labInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textShowResult
            // 
            this.textShowResult.Location = new System.Drawing.Point(1, 20);
            this.textShowResult.Multiline = true;
            this.textShowResult.Name = "textShowResult";
            this.textShowResult.ReadOnly = true;
            this.textShowResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textShowResult.Size = new System.Drawing.Size(624, 396);
            this.textShowResult.TabIndex = 0;
            // 
            // labInfo
            // 
            this.labInfo.AutoSize = true;
            this.labInfo.Location = new System.Drawing.Point(12, 5);
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(35, 12);
            this.labInfo.TabIndex = 1;
            this.labInfo.Text = "格式:";
            // 
            // ShowTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 416);
            this.Controls.Add(this.labInfo);
            this.Controls.Add(this.textShowResult);
            this.Name = "ShowTextForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文本内容展示";
            this.Load += new System.EventHandler(this.ShowTextForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textShowResult;
        private System.Windows.Forms.Label labInfo;
    }
}
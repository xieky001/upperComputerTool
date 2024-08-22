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
            this.txtShowResult = new System.Windows.Forms.TextBox();
            this.labInfo = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFormat = new System.Windows.Forms.Button();
            this.cmbFiles = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtShowResult
            // 
            this.txtShowResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtShowResult.Location = new System.Drawing.Point(1, 20);
            this.txtShowResult.Multiline = true;
            this.txtShowResult.Name = "txtShowResult";
            this.txtShowResult.ReadOnly = true;
            this.txtShowResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtShowResult.Size = new System.Drawing.Size(624, 396);
            this.txtShowResult.TabIndex = 0;
            this.txtShowResult.TabStop = false;
            // 
            // labInfo
            // 
            this.labInfo.AutoSize = true;
            this.labInfo.Location = new System.Drawing.Point(6, 3);
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(35, 12);
            this.labInfo.TabIndex = 1;
            this.labInfo.Text = "格式:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(560, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 20);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFormat
            // 
            this.btnFormat.Location = new System.Drawing.Point(486, 0);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(68, 20);
            this.btnFormat.TabIndex = 3;
            this.btnFormat.Text = "格式验证";
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Visible = false;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // cmbFiles
            // 
            this.cmbFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiles.FormattingEnabled = true;
            this.cmbFiles.Location = new System.Drawing.Point(74, 0);
            this.cmbFiles.Name = "cmbFiles";
            this.cmbFiles.Size = new System.Drawing.Size(240, 20);
            this.cmbFiles.TabIndex = 4;
            this.cmbFiles.SelectedIndexChanged += new System.EventHandler(this.cmbFiles_SelectedIndexChanged);
            // 
            // ShowTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 416);
            this.Controls.Add(this.cmbFiles);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labInfo);
            this.Controls.Add(this.txtShowResult);
            this.Name = "ShowTextForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文本内容展示";
            this.Load += new System.EventHandler(this.ShowTextForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtShowResult;
        private System.Windows.Forms.Label labInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.ComboBox cmbFiles;
    }
}
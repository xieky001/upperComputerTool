namespace testDevice.TCP
{
    partial class ClientForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labServerStatus = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.labClient = new System.Windows.Forms.Label();
            this.labPassword = new System.Windows.Forms.Label();
            this.labUsername = new System.Windows.Forms.Label();
            this.labPort = new System.Windows.Forms.Label();
            this.labHost = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.rtxtSendMsg = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labServerStatus);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.labClient);
            this.groupBox1.Controls.Add(this.labPassword);
            this.groupBox1.Controls.Add(this.labUsername);
            this.groupBox1.Controls.Add(this.labPort);
            this.groupBox1.Controls.Add(this.labHost);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 62);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "连接信息";
            // 
            // labServerStatus
            // 
            this.labServerStatus.AutoSize = true;
            this.labServerStatus.ForeColor = System.Drawing.Color.Red;
            this.labServerStatus.Location = new System.Drawing.Point(329, 41);
            this.labServerStatus.Name = "labServerStatus";
            this.labServerStatus.Size = new System.Drawing.Size(0, 12);
            this.labServerStatus.TabIndex = 13;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(508, 33);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(57, 20);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // labClient
            // 
            this.labClient.AutoSize = true;
            this.labClient.Location = new System.Drawing.Point(77, 40);
            this.labClient.Name = "labClient";
            this.labClient.Size = new System.Drawing.Size(0, 12);
            this.labClient.TabIndex = 10;
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Location = new System.Drawing.Point(518, 17);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(0, 12);
            this.labPassword.TabIndex = 9;
            // 
            // labUsername
            // 
            this.labUsername.AutoSize = true;
            this.labUsername.Location = new System.Drawing.Point(364, 17);
            this.labUsername.Name = "labUsername";
            this.labUsername.Size = new System.Drawing.Size(0, 12);
            this.labUsername.TabIndex = 8;
            // 
            // labPort
            // 
            this.labPort.AutoSize = true;
            this.labPort.Location = new System.Drawing.Point(219, 17);
            this.labPort.Name = "labPort";
            this.labPort.Size = new System.Drawing.Size(0, 12);
            this.labPort.TabIndex = 7;
            // 
            // labHost
            // 
            this.labHost.AutoSize = true;
            this.labHost.Location = new System.Drawing.Point(77, 17);
            this.labHost.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labHost.Name = "labHost";
            this.labHost.Size = new System.Drawing.Size(0, 12);
            this.labHost.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "客户端ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "密码:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "账号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(496, 402);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(72, 20);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(496, 373);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(72, 20);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSend
            // 
            this.txtSend.BackColor = System.Drawing.Color.White;
            this.txtSend.Location = new System.Drawing.Point(4, 361);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(483, 69);
            this.txtSend.TabIndex = 12;
            // 
            // rtxtSendMsg
            // 
            this.rtxtSendMsg.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rtxtSendMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtSendMsg.Location = new System.Drawing.Point(4, 70);
            this.rtxtSendMsg.Name = "rtxtSendMsg";
            this.rtxtSendMsg.ReadOnly = true;
            this.rtxtSendMsg.Size = new System.Drawing.Size(567, 285);
            this.rtxtSendMsg.TabIndex = 14;
            this.rtxtSendMsg.Text = "";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 435);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.rtxtSendMsg);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientForm_FormClosed);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labServerStatus;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label labClient;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.Label labUsername;
        private System.Windows.Forms.Label labPort;
        private System.Windows.Forms.Label labHost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.RichTextBox rtxtSendMsg;
    }
}
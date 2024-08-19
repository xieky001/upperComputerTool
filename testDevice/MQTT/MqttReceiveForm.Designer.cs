namespace testDevice.MQTT
{
    partial class MqttReceiveForm
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
            this.labTopic = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.rtxtReceiveMsg = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.labServerStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labServerStatus);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.labTopic);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.label8);
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
            this.groupBox1.Location = new System.Drawing.Point(8, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "连接信息";
            // 
            // labTopic
            // 
            this.labTopic.AutoSize = true;
            this.labTopic.Location = new System.Drawing.Point(228, 40);
            this.labTopic.Name = "labTopic";
            this.labTopic.Size = new System.Drawing.Size(0, 12);
            this.labTopic.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "主题:";
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
            this.labPassword.Location = new System.Drawing.Point(512, 17);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(0, 12);
            this.labPassword.TabIndex = 9;
            // 
            // labUsername
            // 
            this.labUsername.AutoSize = true;
            this.labUsername.Location = new System.Drawing.Point(372, 17);
            this.labUsername.Name = "labUsername";
            this.labUsername.Size = new System.Drawing.Size(0, 12);
            this.labUsername.TabIndex = 8;
            // 
            // labPort
            // 
            this.labPort.AutoSize = true;
            this.labPort.Location = new System.Drawing.Point(216, 17);
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
            this.label4.Location = new System.Drawing.Point(420, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "密码:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "账号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 17);
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
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(444, 35);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(57, 20);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // rtxtReceiveMsg
            // 
            this.rtxtReceiveMsg.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rtxtReceiveMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtReceiveMsg.Location = new System.Drawing.Point(9, 73);
            this.rtxtReceiveMsg.Name = "rtxtReceiveMsg";
            this.rtxtReceiveMsg.ReadOnly = true;
            this.rtxtReceiveMsg.Size = new System.Drawing.Size(567, 360);
            this.rtxtReceiveMsg.TabIndex = 6;
            this.rtxtReceiveMsg.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(507, 35);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(57, 20);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labServerStatus
            // 
            this.labServerStatus.AutoSize = true;
            this.labServerStatus.ForeColor = System.Drawing.Color.Red;
            this.labServerStatus.Location = new System.Drawing.Point(309, 39);
            this.labServerStatus.Name = "labServerStatus";
            this.labServerStatus.Size = new System.Drawing.Size(0, 12);
            this.labServerStatus.TabIndex = 14;
            // 
            // MqttReceiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 440);
            this.Controls.Add(this.rtxtReceiveMsg);
            this.Controls.Add(this.groupBox1);
            this.Name = "MqttReceiveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MQTT通讯验证_订阅主题";
            this.Load += new System.EventHandler(this.MqttForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labHost;
        private System.Windows.Forms.Label labPort;
        private System.Windows.Forms.Label labUsername;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.Label labClient;
        private System.Windows.Forms.Label labTopic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtxtReceiveMsg;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label labServerStatus;
    }
}
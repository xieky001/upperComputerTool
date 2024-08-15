namespace testDevice.Lora
{
    partial class CommonToolForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClearResponse = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.labStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConverse = new System.Windows.Forms.Button();
            this.butClear33 = new System.Windows.Forms.Button();
            this.butSub33 = new System.Windows.Forms.Button();
            this.btnAdd33 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCsRes = new System.Windows.Forms.TextBox();
            this.btnCs = new System.Windows.Forms.Button();
            this.txtCsSource = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labInfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "命令：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(35, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "响应：";
            // 
            // txtSend
            // 
            this.txtSend.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSend.Location = new System.Drawing.Point(115, 32);
            this.txtSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(485, 23);
            this.txtSend.TabIndex = 2;
            this.txtSend.TextChanged += new System.EventHandler(this.txtSend_TextChanged);
            // 
            // txtReceive
            // 
            this.txtReceive.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtReceive.Location = new System.Drawing.Point(115, 103);
            this.txtReceive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReceive.Multiline = true;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.ReadOnly = true;
            this.txtReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceive.Size = new System.Drawing.Size(485, 71);
            this.txtReceive.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.Location = new System.Drawing.Point(199, 65);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(97, 28);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClearResponse
            // 
            this.btnClearResponse.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearResponse.Location = new System.Drawing.Point(367, 65);
            this.btnClearResponse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClearResponse.Name = "btnClearResponse";
            this.btnClearResponse.Size = new System.Drawing.Size(97, 28);
            this.btnClearResponse.TabIndex = 5;
            this.btnClearResponse.Text = "清空响应";
            this.btnClearResponse.UseVisualStyleBackColor = true;
            this.btnClearResponse.Click += new System.EventHandler(this.btnClearResponse_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpen.Location = new System.Drawing.Point(16, 13);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(97, 28);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "打开端口";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labStatus.Location = new System.Drawing.Point(181, 19);
            this.labStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(34, 17);
            this.labStatus.TabIndex = 8;
            this.labStatus.Text = "stop";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtReceive);
            this.panel1.Controls.Add(this.btnClearResponse);
            this.panel1.Controls.Add(this.txtSend);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(16, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 188);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConverse);
            this.groupBox1.Controls.Add(this.butClear33);
            this.groupBox1.Controls.Add(this.butSub33);
            this.groupBox1.Controls.Add(this.btnAdd33);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTarget);
            this.groupBox1.Controls.Add(this.txtSource);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(16, 249);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(621, 260);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "33H转换";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnConverse
            // 
            this.btnConverse.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConverse.Location = new System.Drawing.Point(345, 116);
            this.btnConverse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConverse.Name = "btnConverse";
            this.btnConverse.Size = new System.Drawing.Size(90, 28);
            this.btnConverse.TabIndex = 10;
            this.btnConverse.Text = "converse";
            this.btnConverse.UseVisualStyleBackColor = true;
            this.btnConverse.Click += new System.EventHandler(this.btnConverse_Click);
            // 
            // butClear33
            // 
            this.butClear33.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butClear33.Location = new System.Drawing.Point(454, 116);
            this.butClear33.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butClear33.Name = "butClear33";
            this.butClear33.Size = new System.Drawing.Size(90, 28);
            this.butClear33.TabIndex = 9;
            this.butClear33.Text = "clear";
            this.butClear33.UseVisualStyleBackColor = true;
            this.butClear33.Click += new System.EventHandler(this.butClear33_Click);
            // 
            // butSub33
            // 
            this.butSub33.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butSub33.Location = new System.Drawing.Point(235, 116);
            this.butSub33.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butSub33.Name = "butSub33";
            this.butSub33.Size = new System.Drawing.Size(90, 28);
            this.butSub33.TabIndex = 8;
            this.butSub33.Text = "-33H";
            this.butSub33.UseVisualStyleBackColor = true;
            this.butSub33.Click += new System.EventHandler(this.butSub33_Click);
            // 
            // btnAdd33
            // 
            this.btnAdd33.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd33.Location = new System.Drawing.Point(126, 116);
            this.btnAdd33.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd33.Name = "btnAdd33";
            this.btnAdd33.Size = new System.Drawing.Size(90, 28);
            this.btnAdd33.TabIndex = 7;
            this.btnAdd33.Text = "+33H";
            this.btnAdd33.UseVisualStyleBackColor = true;
            this.btnAdd33.Click += new System.EventHandler(this.btnAdd33_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(36, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "结果：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(36, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "原值：";
            // 
            // txtTarget
            // 
            this.txtTarget.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTarget.Location = new System.Drawing.Point(116, 166);
            this.txtTarget.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTarget.Multiline = true;
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.ReadOnly = true;
            this.txtTarget.Size = new System.Drawing.Size(485, 85);
            this.txtTarget.TabIndex = 4;
            // 
            // txtSource
            // 
            this.txtSource.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSource.Location = new System.Drawing.Point(116, 26);
            this.txtSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(485, 79);
            this.txtSource.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCsRes);
            this.groupBox2.Controls.Add(this.btnCs);
            this.groupBox2.Controls.Add(this.txtCsSource);
            this.groupBox2.Location = new System.Drawing.Point(644, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 188);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "校验码";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtCsRes
            // 
            this.txtCsRes.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCsRes.Location = new System.Drawing.Point(20, 136);
            this.txtCsRes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCsRes.Name = "txtCsRes";
            this.txtCsRes.ReadOnly = true;
            this.txtCsRes.Size = new System.Drawing.Size(353, 23);
            this.txtCsRes.TabIndex = 6;
            // 
            // btnCs
            // 
            this.btnCs.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCs.Location = new System.Drawing.Point(140, 86);
            this.btnCs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCs.Name = "btnCs";
            this.btnCs.Size = new System.Drawing.Size(97, 28);
            this.btnCs.TabIndex = 5;
            this.btnCs.Text = "计算";
            this.btnCs.UseVisualStyleBackColor = true;
            this.btnCs.Click += new System.EventHandler(this.btnCs_Click);
            // 
            // txtCsSource
            // 
            this.txtCsSource.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCsSource.Location = new System.Drawing.Point(20, 40);
            this.txtCsSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCsSource.Name = "txtCsSource";
            this.txtCsSource.Size = new System.Drawing.Size(353, 23);
            this.txtCsSource.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(121, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "串口状态:";
            // 
            // labInfo
            // 
            this.labInfo.AutoSize = true;
            this.labInfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labInfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labInfo.Location = new System.Drawing.Point(235, 19);
            this.labInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(44, 17);
            this.labInfo.TabIndex = 14;
            this.labInfo.Text = "empty";
            // 
            // CommonToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 561);
            this.Controls.Add(this.labInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labStatus);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CommonToolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "通用工具";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CommonToolForm_FormClosed);
            this.Load += new System.EventHandler(this.CommonToolForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClearResponse;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butSub33;
        private System.Windows.Forms.Button btnAdd33;
        private System.Windows.Forms.Button butClear33;
        private System.Windows.Forms.Button btnConverse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCsSource;
        private System.Windows.Forms.TextBox txtCsRes;
        private System.Windows.Forms.Button btnCs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labInfo;
    }
}
namespace testDevice.Lora
{
    partial class ConfigProtocolForm
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
            this.cmbDataitem = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMeterType = new System.Windows.Forms.ComboBox();
            this.btnGetDevAddr = new System.Windows.Forms.Button();
            this.labPortSatus = new System.Windows.Forms.Label();
            this.txtDevAddr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOpenCom = new System.Windows.Forms.Button();
            this.labInfo = new System.Windows.Forms.Label();
            this.rdoProtocol188 = new System.Windows.Forms.RadioButton();
            this.rdoProtocol07 = new System.Windows.Forms.RadioButton();
            this.rdoProtocol97 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInsertValue1 = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLogInfo = new System.Windows.Forms.TextBox();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.labDataItemStatus = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInsertValue2 = new System.Windows.Forms.TextBox();
            this.txtInsertValue3 = new System.Windows.Forms.TextBox();
            this.txtInsertValue4 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClearInsert = new System.Windows.Forms.Button();
            this.gbxOther = new System.Windows.Forms.GroupBox();
            this.btnLoRaAuth = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbxOther.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDataitem
            // 
            this.cmbDataitem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataitem.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbDataitem.FormattingEnabled = true;
            this.cmbDataitem.Location = new System.Drawing.Point(73, 148);
            this.cmbDataitem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDataitem.Name = "cmbDataitem";
            this.cmbDataitem.Size = new System.Drawing.Size(486, 25);
            this.cmbDataitem.TabIndex = 0;
            this.cmbDataitem.SelectedIndexChanged += new System.EventHandler(this.cmbDataitem_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbMeterType);
            this.groupBox1.Controls.Add(this.btnGetDevAddr);
            this.groupBox1.Controls.Add(this.labPortSatus);
            this.groupBox1.Controls.Add(this.txtDevAddr);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnOpenCom);
            this.groupBox1.Controls.Add(this.labInfo);
            this.groupBox1.Controls.Add(this.rdoProtocol188);
            this.groupBox1.Controls.Add(this.rdoProtocol07);
            this.groupBox1.Controls.Add(this.rdoProtocol97);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(14, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(709, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(343, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "表类型:";
            // 
            // cmbMeterType
            // 
            this.cmbMeterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeterType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbMeterType.FormattingEnabled = true;
            this.cmbMeterType.Location = new System.Drawing.Point(396, 78);
            this.cmbMeterType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbMeterType.Name = "cmbMeterType";
            this.cmbMeterType.Size = new System.Drawing.Size(149, 25);
            this.cmbMeterType.TabIndex = 15;
            this.cmbMeterType.SelectedIndexChanged += new System.EventHandler(this.cmbMeterType_SelectedIndexChanged);
            // 
            // btnGetDevAddr
            // 
            this.btnGetDevAddr.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGetDevAddr.Location = new System.Drawing.Point(263, 75);
            this.btnGetDevAddr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetDevAddr.Name = "btnGetDevAddr";
            this.btnGetDevAddr.Size = new System.Drawing.Size(66, 28);
            this.btnGetDevAddr.TabIndex = 14;
            this.btnGetDevAddr.Text = "读表号";
            this.btnGetDevAddr.UseVisualStyleBackColor = true;
            this.btnGetDevAddr.Click += new System.EventHandler(this.btnGetDevAddr_Click);
            // 
            // labPortSatus
            // 
            this.labPortSatus.AutoSize = true;
            this.labPortSatus.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPortSatus.Location = new System.Drawing.Point(114, 30);
            this.labPortSatus.Name = "labPortSatus";
            this.labPortSatus.Size = new System.Drawing.Size(39, 17);
            this.labPortSatus.TabIndex = 13;
            this.labPortSatus.Text = "STOP";
            // 
            // txtDevAddr
            // 
            this.txtDevAddr.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDevAddr.Location = new System.Drawing.Point(51, 77);
            this.txtDevAddr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDevAddr.Name = "txtDevAddr";
            this.txtDevAddr.Size = new System.Drawing.Size(206, 23);
            this.txtDevAddr.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(8, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "表号:";
            // 
            // btnOpenCom
            // 
            this.btnOpenCom.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenCom.Location = new System.Drawing.Point(11, 24);
            this.btnOpenCom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenCom.Name = "btnOpenCom";
            this.btnOpenCom.Size = new System.Drawing.Size(97, 28);
            this.btnOpenCom.TabIndex = 9;
            this.btnOpenCom.Text = "打开串口";
            this.btnOpenCom.UseVisualStyleBackColor = true;
            this.btnOpenCom.Click += new System.EventHandler(this.btnOpenCom_Click);
            // 
            // labInfo
            // 
            this.labInfo.AutoSize = true;
            this.labInfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labInfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labInfo.Location = new System.Drawing.Point(172, 30);
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(44, 17);
            this.labInfo.TabIndex = 6;
            this.labInfo.Text = "empty";
            // 
            // rdoProtocol188
            // 
            this.rdoProtocol188.AutoSize = true;
            this.rdoProtocol188.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoProtocol188.Location = new System.Drawing.Point(570, 81);
            this.rdoProtocol188.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoProtocol188.Name = "rdoProtocol188";
            this.rdoProtocol188.Size = new System.Drawing.Size(75, 21);
            this.rdoProtocol188.TabIndex = 2;
            this.rdoProtocol188.Text = "CJ T 188";
            this.rdoProtocol188.UseVisualStyleBackColor = true;
            this.rdoProtocol188.CheckedChanged += new System.EventHandler(this.rdoProtocol188_CheckedChanged);
            // 
            // rdoProtocol07
            // 
            this.rdoProtocol07.AutoSize = true;
            this.rdoProtocol07.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoProtocol07.Location = new System.Drawing.Point(570, 50);
            this.rdoProtocol07.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoProtocol07.Name = "rdoProtocol07";
            this.rdoProtocol07.Size = new System.Drawing.Size(110, 21);
            this.rdoProtocol07.TabIndex = 1;
            this.rdoProtocol07.Text = "DL T 645-2007";
            this.rdoProtocol07.UseVisualStyleBackColor = true;
            this.rdoProtocol07.CheckedChanged += new System.EventHandler(this.rdoProtocol07_CheckedChanged);
            // 
            // rdoProtocol97
            // 
            this.rdoProtocol97.AutoSize = true;
            this.rdoProtocol97.Checked = true;
            this.rdoProtocol97.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoProtocol97.Location = new System.Drawing.Point(570, 21);
            this.rdoProtocol97.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoProtocol97.Name = "rdoProtocol97";
            this.rdoProtocol97.Size = new System.Drawing.Size(110, 21);
            this.rdoProtocol97.TabIndex = 0;
            this.rdoProtocol97.TabStop = true;
            this.rdoProtocol97.Text = "DL T 645-1997";
            this.rdoProtocol97.UseVisualStyleBackColor = true;
            this.rdoProtocol97.CheckedChanged += new System.EventHandler(this.rdoProtocol97_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(22, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "数据项:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(5, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "写入值:";
            // 
            // txtInsertValue1
            // 
            this.txtInsertValue1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInsertValue1.Location = new System.Drawing.Point(60, 36);
            this.txtInsertValue1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInsertValue1.Name = "txtInsertValue1";
            this.txtInsertValue1.Size = new System.Drawing.Size(391, 23);
            this.txtInsertValue1.TabIndex = 4;
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSet.Location = new System.Drawing.Point(457, 124);
            this.btnSet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(64, 28);
            this.btnSet.TabIndex = 5;
            this.btnSet.Text = "设置";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(18, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "log info：";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.txtLogInfo);
            this.panel1.Controls.Add(this.btnClearLog);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(729, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 558);
            this.panel1.TabIndex = 7;
            // 
            // txtLogInfo
            // 
            this.txtLogInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtLogInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogInfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLogInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLogInfo.Location = new System.Drawing.Point(3, 36);
            this.txtLogInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLogInfo.Multiline = true;
            this.txtLogInfo.Name = "txtLogInfo";
            this.txtLogInfo.ReadOnly = true;
            this.txtLogInfo.Size = new System.Drawing.Size(416, 518);
            this.txtLogInfo.TabIndex = 8;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearLog.Location = new System.Drawing.Point(333, 5);
            this.btnClearLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(84, 25);
            this.btnClearLog.TabIndex = 7;
            this.btnClearLog.Text = "clear";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.Location = new System.Drawing.Point(567, 146);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(55, 28);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "读取";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // labDataItemStatus
            // 
            this.labDataItemStatus.AutoSize = true;
            this.labDataItemStatus.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDataItemStatus.Location = new System.Drawing.Point(631, 151);
            this.labDataItemStatus.Name = "labDataItemStatus";
            this.labDataItemStatus.Size = new System.Drawing.Size(80, 17);
            this.labDataItemStatus.TabIndex = 14;
            this.labDataItemStatus.Text = "可读，不可写";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtResult.Location = new System.Drawing.Point(74, 412);
            this.txtResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(649, 119);
            this.txtResult.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(31, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "输出:";
            // 
            // txtInsertValue2
            // 
            this.txtInsertValue2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInsertValue2.Location = new System.Drawing.Point(60, 80);
            this.txtInsertValue2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInsertValue2.Name = "txtInsertValue2";
            this.txtInsertValue2.Size = new System.Drawing.Size(391, 23);
            this.txtInsertValue2.TabIndex = 17;
            // 
            // txtInsertValue3
            // 
            this.txtInsertValue3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInsertValue3.Location = new System.Drawing.Point(60, 124);
            this.txtInsertValue3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInsertValue3.Name = "txtInsertValue3";
            this.txtInsertValue3.Size = new System.Drawing.Size(391, 23);
            this.txtInsertValue3.TabIndex = 18;
            // 
            // txtInsertValue4
            // 
            this.txtInsertValue4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInsertValue4.Location = new System.Drawing.Point(60, 168);
            this.txtInsertValue4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInsertValue4.Name = "txtInsertValue4";
            this.txtInsertValue4.Size = new System.Drawing.Size(391, 23);
            this.txtInsertValue4.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClearInsert);
            this.groupBox2.Controls.Add(this.txtInsertValue4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtInsertValue3);
            this.groupBox2.Controls.Add(this.txtInsertValue1);
            this.groupBox2.Controls.Add(this.txtInsertValue2);
            this.groupBox2.Controls.Add(this.btnSet);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(14, 190);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(530, 215);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "按照顺序组合在一起，每组内按照正常顺序写";
            // 
            // btnClearInsert
            // 
            this.btnClearInsert.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearInsert.Location = new System.Drawing.Point(457, 165);
            this.btnClearInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearInsert.Name = "btnClearInsert";
            this.btnClearInsert.Size = new System.Drawing.Size(64, 28);
            this.btnClearInsert.TabIndex = 20;
            this.btnClearInsert.Text = "clear";
            this.btnClearInsert.UseVisualStyleBackColor = true;
            this.btnClearInsert.Click += new System.EventHandler(this.btnClearInsert_Click);
            // 
            // gbxOther
            // 
            this.gbxOther.Controls.Add(this.btnLoRaAuth);
            this.gbxOther.Location = new System.Drawing.Point(550, 190);
            this.gbxOther.Name = "gbxOther";
            this.gbxOther.Size = new System.Drawing.Size(173, 215);
            this.gbxOther.TabIndex = 21;
            this.gbxOther.TabStop = false;
            this.gbxOther.Text = "其他";
            // 
            // btnLoRaAuth
            // 
            this.btnLoRaAuth.Location = new System.Drawing.Point(49, 36);
            this.btnLoRaAuth.Name = "btnLoRaAuth";
            this.btnLoRaAuth.Size = new System.Drawing.Size(90, 23);
            this.btnLoRaAuth.TabIndex = 0;
            this.btnLoRaAuth.Text = "LoRa认证";
            this.btnLoRaAuth.UseVisualStyleBackColor = true;
            this.btnLoRaAuth.Click += new System.EventHandler(this.btnLoRaAuth_Click);
            // 
            // ConfigProtocolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 561);
            this.Controls.Add(this.gbxOther);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.labDataItemStatus);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbDataitem);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ConfigProtocolForm";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设备通讯【提前配置协议】";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoRawanTestForm_FormClosed);
            this.Load += new System.EventHandler(this.LoRawanTestForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxOther.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDataitem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoProtocol188;
        private System.Windows.Forms.RadioButton rdoProtocol07;
        private System.Windows.Forms.RadioButton rdoProtocol97;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInsertValue1;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label labInfo;
        private System.Windows.Forms.Button btnOpenCom;
        private System.Windows.Forms.TextBox txtDevAddr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labPortSatus;
        private System.Windows.Forms.Label labDataItemStatus;
        private System.Windows.Forms.Button btnGetDevAddr;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLogInfo;
        private System.Windows.Forms.TextBox txtInsertValue2;
        private System.Windows.Forms.TextBox txtInsertValue3;
        private System.Windows.Forms.TextBox txtInsertValue4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClearInsert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMeterType;
        private System.Windows.Forms.GroupBox gbxOther;
        private System.Windows.Forms.Button btnLoRaAuth;
    }
}
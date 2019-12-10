namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSendMsg = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbox_Protocol = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ClearReceive = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_ClearSend = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(110, 92);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(132, 25);
            this.txtIP.TabIndex = 0;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(110, 141);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(132, 25);
            this.txtPort.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(428, 558);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 124);
            this.listBox1.TabIndex = 2;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(4, 7);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(246, 266);
            this.txtLog.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(460, 396);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 29);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "启动服务器";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(680, 396);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "服务器发送";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSend1_Click);
            // 
            // txtSendMsg
            // 
            this.txtSendMsg.Location = new System.Drawing.Point(405, 227);
            this.txtSendMsg.Margin = new System.Windows.Forms.Padding(4);
            this.txtSendMsg.Multiline = true;
            this.txtSendMsg.Name = "txtSendMsg";
            this.txtSendMsg.Size = new System.Drawing.Size(197, 96);
            this.txtSendMsg.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(460, 452);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 29);
            this.button3.TabIndex = 7;
            this.button3.Text = "启动客户端";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(680, 452);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 29);
            this.button4.TabIndex = 8;
            this.button4.Text = "客户端发送";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 521);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(680, 521);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 29);
            this.button5.TabIndex = 10;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(641, 572);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 110);
            this.textBox1.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbox_Protocol);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 277);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "网络设置";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Location = new System.Drawing.Point(68, 197);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(149, 50);
            this.button6.TabIndex = 13;
            this.button6.Text = "启动服务器";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label3.Location = new System.Drawing.Point(6, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "端口号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "IP地址：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "协议类型：";
            // 
            // cbbox_Protocol
            // 
            this.cbbox_Protocol.FormattingEnabled = true;
            this.cbbox_Protocol.Items.AddRange(new object[] {
            "TCP Server",
            "TCP Client"});
            this.cbbox_Protocol.Location = new System.Drawing.Point(110, 48);
            this.cbbox_Protocol.Name = "cbbox_Protocol";
            this.cbbox_Protocol.Size = new System.Drawing.Size(132, 23);
            this.cbbox_Protocol.TabIndex = 2;
            this.cbbox_Protocol.Text = "TCP Server";
            this.cbbox_Protocol.SelectedIndexChanged += new System.EventHandler(this.cbbox_Protocol_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(610, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(258, 311);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtLog);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(250, 282);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "网络数据接收";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ClearReceive);
            this.groupBox2.Location = new System.Drawing.Point(16, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 163);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收设置";
            // 
            // btn_ClearReceive
            // 
            this.btn_ClearReceive.Location = new System.Drawing.Point(190, 119);
            this.btn_ClearReceive.Name = "btn_ClearReceive";
            this.btn_ClearReceive.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearReceive.TabIndex = 17;
            this.btn_ClearReceive.Text = "清除显示";
            this.btn_ClearReceive.UseVisualStyleBackColor = true;
            this.btn_ClearReceive.Click += new System.EventHandler(this.btn_ClearReceive_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_ClearSend);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Location = new System.Drawing.Point(16, 464);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 163);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送设置";
            // 
            // btn_ClearSend
            // 
            this.btn_ClearSend.Location = new System.Drawing.Point(190, 108);
            this.btn_ClearSend.Name = "btn_ClearSend";
            this.btn_ClearSend.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearSend.TabIndex = 16;
            this.btn_ClearSend.Text = "清除显示";
            this.btn_ClearSend.UseVisualStyleBackColor = true;
            this.btn_ClearSend.Click += new System.EventHandler(this.btn_ClearSend_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("宋体", 12F);
            this.button7.Location = new System.Drawing.Point(190, 31);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(68, 55);
            this.button7.TabIndex = 16;
            this.button7.Text = "发送";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(885, 686);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtSendMsg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "TCP调试助手";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSendMsg;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbox_Protocol;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ClearReceive;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_ClearSend;
        private System.Windows.Forms.Button button7;
    }
}


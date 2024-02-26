namespace Basic_Client
{
    partial class Client
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPort = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtHost = new TextBox();
            btnConnect = new Button();
            label1 = new Label();
            txtMessage = new TextBox();
            btnSend = new Button();
            txtStatus = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnSerialPortOpen = new Button();
            txtSerialReceive = new TextBox();
            btnSerialSend = new Button();
            txtSerialSend = new TextBox();
            btnReceive = new Button();
            btnSerialPortClose = new Button();
            label7 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // txtPort
            // 
            txtPort.Location = new Point(325, 32);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(125, 27);
            txtPort.TabIndex = 11;
            txtPort.Text = "8910";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 35);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 10;
            label3.Text = "Port";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 32);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 9;
            // 
            // txtHost
            // 
            txtHost.Location = new Point(97, 32);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(125, 27);
            txtHost.TabIndex = 8;
            txtHost.Text = "127.0.0.1";
            txtHost.TextChanged += txtHost_TextChanged;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(472, 30);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(94, 29);
            btnConnect.TabIndex = 7;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 35);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 6;
            label1.Text = "Host";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(38, 90);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(667, 91);
            txtMessage.TabIndex = 12;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(611, 201);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 13;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(38, 248);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(667, 91);
            txtStatus.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 384);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 17;
            label4.Text = "Port";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 381);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 16;
            // 
            // btnSerialPortOpen
            // 
            btnSerialPortOpen.Location = new Point(244, 379);
            btnSerialPortOpen.Name = "btnSerialPortOpen";
            btnSerialPortOpen.Size = new Size(94, 29);
            btnSerialPortOpen.TabIndex = 15;
            btnSerialPortOpen.Text = "Open";
            btnSerialPortOpen.UseVisualStyleBackColor = true;
            btnSerialPortOpen.Click += btnSerialPortOpen_Click;
            // 
            // txtSerialReceive
            // 
            txtSerialReceive.Location = new Point(38, 583);
            txtSerialReceive.Multiline = true;
            txtSerialReceive.Name = "txtSerialReceive";
            txtSerialReceive.Size = new Size(667, 91);
            txtSerialReceive.TabIndex = 21;
            // 
            // btnSerialSend
            // 
            btnSerialSend.Location = new Point(611, 536);
            btnSerialSend.Name = "btnSerialSend";
            btnSerialSend.Size = new Size(94, 29);
            btnSerialSend.TabIndex = 20;
            btnSerialSend.Text = "Send";
            btnSerialSend.UseVisualStyleBackColor = true;
            btnSerialSend.Click += btnSerialSend_Click;
            // 
            // txtSerialSend
            // 
            txtSerialSend.Location = new Point(38, 439);
            txtSerialSend.Multiline = true;
            txtSerialSend.Name = "txtSerialSend";
            txtSerialSend.Size = new Size(667, 91);
            txtSerialSend.TabIndex = 19;
            // 
            // btnReceive
            // 
            btnReceive.Location = new Point(611, 680);
            btnReceive.Name = "btnReceive";
            btnReceive.Size = new Size(94, 29);
            btnReceive.TabIndex = 22;
            btnReceive.Text = "Receive";
            btnReceive.UseVisualStyleBackColor = true;
            btnReceive.Click += btnReceive_Click;
            // 
            // btnSerialPortClose
            // 
            btnSerialPortClose.Location = new Point(356, 379);
            btnSerialPortClose.Name = "btnSerialPortClose";
            btnSerialPortClose.Size = new Size(94, 29);
            btnSerialPortClose.TabIndex = 23;
            btnSerialPortClose.Text = "Close";
            btnSerialPortClose.UseVisualStyleBackColor = true;
            btnSerialPortClose.Click += btnSerialPortClose_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 560);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 25;
            label7.Text = "Received";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(79, 380);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 69);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 27;
            label6.Text = "Message";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 227);
            label8.Name = "label8";
            label8.Size = new Size(131, 20);
            label8.TabIndex = 28;
            label8.Text = "Received Message";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(38, 416);
            label9.Name = "label9";
            label9.Size = new Size(67, 20);
            label9.TabIndex = 29;
            label9.Text = "Message";
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 713);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(btnSerialPortClose);
            Controls.Add(btnReceive);
            Controls.Add(txtSerialReceive);
            Controls.Add(btnSerialSend);
            Controls.Add(txtSerialSend);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(btnSerialPortOpen);
            Controls.Add(txtStatus);
            Controls.Add(btnSend);
            Controls.Add(txtMessage);
            Controls.Add(txtPort);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtHost);
            Controls.Add(btnConnect);
            Controls.Add(label1);
            Name = "Client";
            Text = "Client";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPort;
        private Label label3;
        private Label label2;
        private TextBox txtHost;
        private Button btnConnect;
        private Label label1;
        private TextBox txtMessage;
        private Button btnSend;
        private TextBox txtStatus;
        private Label label4;
        private Label label5;
        private Button btnSerialPortOpen;
        private TextBox txtSerialReceive;
        private Button btnSerialSend;
        private TextBox txtSerialSend;
        private Button btnReceive;
        private Button btnSerialPortClose;
        private Label label7;
        private ComboBox comboBox1;
        private Label label6;
        private Label label8;
        private Label label9;
    }
}

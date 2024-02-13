namespace Basic_TCP_IP_Client
{
    partial class Server
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
            label1 = new Label();
            btnStart = new Button();
            txtHost = new TextBox();
            label2 = new Label();
            txtPort = new TextBox();
            label3 = new Label();
            btnStop = new Button();
            txtStatus = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 76);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 0;
            label1.Text = "Host";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(489, 71);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // txtHost
            // 
            txtHost.Location = new Point(114, 73);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(125, 27);
            txtHost.TabIndex = 2;
            txtHost.Text = "127.0.0.1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 73);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 3;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(342, 73);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(125, 27);
            txtPort.TabIndex = 5;
            txtPort.Text = "8910";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 76);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 4;
            label3.Text = "Port";
            // 
            // btnStop
            // 
            btnStop.Location = new Point(599, 71);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(94, 29);
            btnStop.TabIndex = 6;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(55, 124);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(667, 216);
            txtStatus.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtStatus);
            Controls.Add(btnStop);
            Controls.Add(txtPort);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtHost);
            Controls.Add(btnStart);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Server";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnStart;
        private TextBox txtHost;
        private Label label2;
        private TextBox txtPort;
        private Label label3;
        private Button btnStop;
        private TextBox txtStatus;
    }
}

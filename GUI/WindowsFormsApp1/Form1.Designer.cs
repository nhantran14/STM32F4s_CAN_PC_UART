namespace WindowsFormsApp1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtReadSerial = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ccbBaudrate = new System.Windows.Forms.ComboBox();
            this.ccbComName = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.trs = new System.Windows.Forms.TextBox();
            this.Trs_btn = new System.Windows.Forms.Button();
            this.allow = new System.Windows.Forms.RadioButton();
            this.stop = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtReadSerial);
            this.groupBox1.Location = new System.Drawing.Point(10, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receive Data";
            // 
            // txtReadSerial
            // 
            this.txtReadSerial.Location = new System.Drawing.Point(12, 26);
            this.txtReadSerial.Multiline = true;
            this.txtReadSerial.Name = "txtReadSerial";
            this.txtReadSerial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReadSerial.Size = new System.Drawing.Size(418, 173);
            this.txtReadSerial.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ccbBaudrate);
            this.groupBox2.Controls.Add(this.ccbComName);
            this.groupBox2.Location = new System.Drawing.Point(463, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 214);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statics";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(125, 152);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(79, 32);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM Port";
            // 
            // ccbBaudrate
            // 
            this.ccbBaudrate.FormattingEnabled = true;
            this.ccbBaudrate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "115200"});
            this.ccbBaudrate.Location = new System.Drawing.Point(97, 98);
            this.ccbBaudrate.Name = "ccbBaudrate";
            this.ccbBaudrate.Size = new System.Drawing.Size(195, 21);
            this.ccbBaudrate.TabIndex = 1;
            // 
            // ccbComName
            // 
            this.ccbComName.FormattingEnabled = true;
            this.ccbComName.ItemHeight = 13;
            this.ccbComName.Location = new System.Drawing.Point(97, 41);
            this.ccbComName.Name = "ccbComName";
            this.ccbComName.Size = new System.Drawing.Size(195, 21);
            this.ccbComName.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // trs
            // 
            this.trs.Location = new System.Drawing.Point(198, 292);
            this.trs.Multiline = true;
            this.trs.Name = "trs";
            this.trs.Size = new System.Drawing.Size(242, 57);
            this.trs.TabIndex = 2;
            // 
            // Trs_btn
            // 
            this.Trs_btn.Location = new System.Drawing.Point(467, 295);
            this.Trs_btn.Name = "Trs_btn";
            this.Trs_btn.Size = new System.Drawing.Size(110, 54);
            this.Trs_btn.TabIndex = 3;
            this.Trs_btn.Text = "Transmit";
            this.Trs_btn.UseVisualStyleBackColor = true;
            this.Trs_btn.Click += new System.EventHandler(this.Trs_btn_Click);
            // 
            // allow
            // 
            this.allow.AutoSize = true;
            this.allow.Location = new System.Drawing.Point(125, 228);
            this.allow.Name = "allow";
            this.allow.Size = new System.Drawing.Size(50, 17);
            this.allow.TabIndex = 4;
            this.allow.TabStop = true;
            this.allow.Text = "Allow";
            this.allow.UseVisualStyleBackColor = true;
            // 
            // stop
            // 
            this.stop.AutoSize = true;
            this.stop.Location = new System.Drawing.Point(290, 228);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(47, 17);
            this.stop.TabIndex = 5;
            this.stop.TabStop = true;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.allow);
            this.Controls.Add(this.Trs_btn);
            this.Controls.Add(this.trs);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "UART Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtReadSerial;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ccbBaudrate;
        private System.Windows.Forms.ComboBox ccbComName;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox trs;
        private System.Windows.Forms.Button Trs_btn;
        private System.Windows.Forms.RadioButton allow;
        private System.Windows.Forms.RadioButton stop;
    }
}


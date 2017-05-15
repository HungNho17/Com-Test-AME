namespace TestAME
{
    partial class SW_SerialComSetUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SW_SerialComSetUp));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LVSerialPort = new System.Windows.Forms.ListView();
            this.Port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RB115200 = new System.Windows.Forms.RadioButton();
            this.RB57600 = new System.Windows.Forms.RadioButton();
            this.RB38400 = new System.Windows.Forms.RadioButton();
            this.RB19200 = new System.Windows.Forms.RadioButton();
            this.RB14400 = new System.Windows.Forms.RadioButton();
            this.RB9600 = new System.Windows.Forms.RadioButton();
            this.RB4800 = new System.Windows.Forms.RadioButton();
            this.RB2400 = new System.Windows.Forms.RadioButton();
            this.RB1200 = new System.Windows.Forms.RadioButton();
            this.RB600 = new System.Windows.Forms.RadioButton();
            this.RB300 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RBParityNone = new System.Windows.Forms.RadioButton();
            this.RBParityOdd = new System.Windows.Forms.RadioButton();
            this.RBParityEven = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RBDataB8 = new System.Windows.Forms.RadioButton();
            this.RBDataB7 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.RBStopB2 = new System.Windows.Forms.RadioButton();
            this.RBStopB1 = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LVSerialPort);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(240, 396);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Ports";
            // 
            // LVSerialPort
            // 
            this.LVSerialPort.CheckBoxes = true;
            this.LVSerialPort.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Port,
            this.Description});
            this.LVSerialPort.FullRowSelect = true;
            this.LVSerialPort.GridLines = true;
            this.LVSerialPort.Location = new System.Drawing.Point(11, 17);
            this.LVSerialPort.Name = "LVSerialPort";
            this.LVSerialPort.Size = new System.Drawing.Size(224, 374);
            this.LVSerialPort.TabIndex = 0;
            this.LVSerialPort.UseCompatibleStateImageBehavior = false;
            this.LVSerialPort.View = System.Windows.Forms.View.Details;
            this.LVSerialPort.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.SerialPort_ItemCheck);
            // 
            // Port
            // 
            this.Port.Text = "Ports";
            // 
            // Description
            // 
            this.Description.Text = "Registry Description";
            this.Description.Width = 200;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RB115200);
            this.groupBox2.Controls.Add(this.RB57600);
            this.groupBox2.Controls.Add(this.RB38400);
            this.groupBox2.Controls.Add(this.RB19200);
            this.groupBox2.Controls.Add(this.RB14400);
            this.groupBox2.Controls.Add(this.RB9600);
            this.groupBox2.Controls.Add(this.RB4800);
            this.groupBox2.Controls.Add(this.RB2400);
            this.groupBox2.Controls.Add(this.RB1200);
            this.groupBox2.Controls.Add(this.RB600);
            this.groupBox2.Controls.Add(this.RB300);
            this.groupBox2.Location = new System.Drawing.Point(271, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(193, 107);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Baud Rate:";
            // 
            // RB115200
            // 
            this.RB115200.AutoSize = true;
            this.RB115200.Location = new System.Drawing.Point(138, 66);
            this.RB115200.Margin = new System.Windows.Forms.Padding(2);
            this.RB115200.Name = "RB115200";
            this.RB115200.Size = new System.Drawing.Size(59, 17);
            this.RB115200.TabIndex = 10;
            this.RB115200.TabStop = true;
            this.RB115200.Text = "115.2K";
            this.RB115200.UseVisualStyleBackColor = true;
            this.RB115200.Click += new System.EventHandler(this.BaudRate_CheckedChanged);
            // 
            // RB57600
            // 
            this.RB57600.AutoSize = true;
            this.RB57600.Location = new System.Drawing.Point(138, 44);
            this.RB57600.Margin = new System.Windows.Forms.Padding(2);
            this.RB57600.Name = "RB57600";
            this.RB57600.Size = new System.Drawing.Size(53, 17);
            this.RB57600.TabIndex = 9;
            this.RB57600.TabStop = true;
            this.RB57600.Text = "57.6K";
            this.RB57600.UseVisualStyleBackColor = true;
            this.RB57600.Click += new System.EventHandler(this.BaudRate_CheckedChanged);
            // 
            // RB38400
            // 
            this.RB38400.AutoSize = true;
            this.RB38400.Location = new System.Drawing.Point(138, 22);
            this.RB38400.Margin = new System.Windows.Forms.Padding(2);
            this.RB38400.Name = "RB38400";
            this.RB38400.Size = new System.Drawing.Size(53, 17);
            this.RB38400.TabIndex = 8;
            this.RB38400.TabStop = true;
            this.RB38400.Text = "38.4K";
            this.RB38400.UseVisualStyleBackColor = true;
            this.RB38400.Click += new System.EventHandler(this.BaudRate_CheckedChanged);
            // 
            // RB19200
            // 
            this.RB19200.AutoSize = true;
            this.RB19200.Location = new System.Drawing.Point(76, 85);
            this.RB19200.Margin = new System.Windows.Forms.Padding(2);
            this.RB19200.Name = "RB19200";
            this.RB19200.Size = new System.Drawing.Size(53, 17);
            this.RB19200.TabIndex = 7;
            this.RB19200.TabStop = true;
            this.RB19200.Text = "19.2K";
            this.RB19200.UseVisualStyleBackColor = true;
            this.RB19200.Click += new System.EventHandler(this.BaudRate_CheckedChanged);
            // 
            // RB14400
            // 
            this.RB14400.AutoSize = true;
            this.RB14400.Location = new System.Drawing.Point(76, 66);
            this.RB14400.Margin = new System.Windows.Forms.Padding(2);
            this.RB14400.Name = "RB14400";
            this.RB14400.Size = new System.Drawing.Size(53, 17);
            this.RB14400.TabIndex = 6;
            this.RB14400.TabStop = true;
            this.RB14400.Text = "14.4K";
            this.RB14400.UseVisualStyleBackColor = true;
            this.RB14400.Click += new System.EventHandler(this.BaudRate_CheckedChanged);
            // 
            // RB9600
            // 
            this.RB9600.AutoSize = true;
            this.RB9600.Location = new System.Drawing.Point(76, 44);
            this.RB9600.Margin = new System.Windows.Forms.Padding(2);
            this.RB9600.Name = "RB9600";
            this.RB9600.Size = new System.Drawing.Size(49, 17);
            this.RB9600.TabIndex = 5;
            this.RB9600.TabStop = true;
            this.RB9600.Text = "9600";
            this.RB9600.UseVisualStyleBackColor = true;
            this.RB9600.Click += new System.EventHandler(this.BaudRate_CheckedChanged);
            // 
            // RB4800
            // 
            this.RB4800.AutoSize = true;
            this.RB4800.Location = new System.Drawing.Point(76, 22);
            this.RB4800.Margin = new System.Windows.Forms.Padding(2);
            this.RB4800.Name = "RB4800";
            this.RB4800.Size = new System.Drawing.Size(49, 17);
            this.RB4800.TabIndex = 4;
            this.RB4800.TabStop = true;
            this.RB4800.Text = "4800";
            this.RB4800.UseVisualStyleBackColor = true;
            this.RB4800.Click += new System.EventHandler(this.BaudRate_CheckedChanged);
            // 
            // RB2400
            // 
            this.RB2400.AutoSize = true;
            this.RB2400.Location = new System.Drawing.Point(11, 85);
            this.RB2400.Margin = new System.Windows.Forms.Padding(2);
            this.RB2400.Name = "RB2400";
            this.RB2400.Size = new System.Drawing.Size(49, 17);
            this.RB2400.TabIndex = 3;
            this.RB2400.TabStop = true;
            this.RB2400.Text = "2400";
            this.RB2400.UseVisualStyleBackColor = true;
            this.RB2400.Click += new System.EventHandler(this.BaudRate_CheckedChanged);
            // 
            // RB1200
            // 
            this.RB1200.AutoSize = true;
            this.RB1200.Location = new System.Drawing.Point(11, 66);
            this.RB1200.Margin = new System.Windows.Forms.Padding(2);
            this.RB1200.Name = "RB1200";
            this.RB1200.Size = new System.Drawing.Size(49, 17);
            this.RB1200.TabIndex = 2;
            this.RB1200.TabStop = true;
            this.RB1200.Text = "1200";
            this.RB1200.UseVisualStyleBackColor = true;
            this.RB1200.Click += new System.EventHandler(this.BaudRate_CheckedChanged);
            // 
            // RB600
            // 
            this.RB600.AutoSize = true;
            this.RB600.Location = new System.Drawing.Point(11, 44);
            this.RB600.Margin = new System.Windows.Forms.Padding(2);
            this.RB600.Name = "RB600";
            this.RB600.Size = new System.Drawing.Size(43, 17);
            this.RB600.TabIndex = 1;
            this.RB600.TabStop = true;
            this.RB600.Text = "600";
            this.RB600.UseVisualStyleBackColor = true;
            this.RB600.Click += new System.EventHandler(this.BaudRate_CheckedChanged);
            // 
            // RB300
            // 
            this.RB300.AutoSize = true;
            this.RB300.Location = new System.Drawing.Point(10, 22);
            this.RB300.Margin = new System.Windows.Forms.Padding(2);
            this.RB300.Name = "RB300";
            this.RB300.Size = new System.Drawing.Size(43, 17);
            this.RB300.TabIndex = 0;
            this.RB300.TabStop = true;
            this.RB300.Text = "300";
            this.RB300.UseVisualStyleBackColor = true;
            this.RB300.Click += new System.EventHandler(this.BaudRate_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RBParityNone);
            this.groupBox3.Controls.Add(this.RBParityOdd);
            this.groupBox3.Controls.Add(this.RBParityEven);
            this.groupBox3.Location = new System.Drawing.Point(272, 124);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(192, 55);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parity:";
            // 
            // RBParityNone
            // 
            this.RBParityNone.AutoSize = true;
            this.RBParityNone.Location = new System.Drawing.Point(137, 24);
            this.RBParityNone.Margin = new System.Windows.Forms.Padding(2);
            this.RBParityNone.Name = "RBParityNone";
            this.RBParityNone.Size = new System.Drawing.Size(51, 17);
            this.RBParityNone.TabIndex = 2;
            this.RBParityNone.TabStop = true;
            this.RBParityNone.Text = "None";
            this.RBParityNone.UseVisualStyleBackColor = true;
            this.RBParityNone.Click += new System.EventHandler(this.Parity_CheckedChanged);
            // 
            // RBParityOdd
            // 
            this.RBParityOdd.AutoSize = true;
            this.RBParityOdd.Location = new System.Drawing.Point(75, 24);
            this.RBParityOdd.Margin = new System.Windows.Forms.Padding(2);
            this.RBParityOdd.Name = "RBParityOdd";
            this.RBParityOdd.Size = new System.Drawing.Size(45, 17);
            this.RBParityOdd.TabIndex = 1;
            this.RBParityOdd.TabStop = true;
            this.RBParityOdd.Text = "Odd";
            this.RBParityOdd.UseVisualStyleBackColor = true;
            this.RBParityOdd.Click += new System.EventHandler(this.Parity_CheckedChanged);
            // 
            // RBParityEven
            // 
            this.RBParityEven.AutoSize = true;
            this.RBParityEven.Location = new System.Drawing.Point(10, 24);
            this.RBParityEven.Margin = new System.Windows.Forms.Padding(2);
            this.RBParityEven.Name = "RBParityEven";
            this.RBParityEven.Size = new System.Drawing.Size(50, 17);
            this.RBParityEven.TabIndex = 0;
            this.RBParityEven.TabStop = true;
            this.RBParityEven.Text = "Even";
            this.RBParityEven.UseVisualStyleBackColor = true;
            this.RBParityEven.Click += new System.EventHandler(this.Parity_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RBDataB8);
            this.groupBox4.Controls.Add(this.RBDataB7);
            this.groupBox4.Location = new System.Drawing.Point(272, 194);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(93, 41);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data bits:";
            // 
            // RBDataB8
            // 
            this.RBDataB8.AutoSize = true;
            this.RBDataB8.Location = new System.Drawing.Point(61, 17);
            this.RBDataB8.Margin = new System.Windows.Forms.Padding(2);
            this.RBDataB8.Name = "RBDataB8";
            this.RBDataB8.Size = new System.Drawing.Size(31, 17);
            this.RBDataB8.TabIndex = 1;
            this.RBDataB8.TabStop = true;
            this.RBDataB8.Text = "8";
            this.RBDataB8.UseVisualStyleBackColor = true;
            this.RBDataB8.Click += new System.EventHandler(this.DataBits_CheckedChanged);
            // 
            // RBDataB7
            // 
            this.RBDataB7.AutoSize = true;
            this.RBDataB7.Location = new System.Drawing.Point(11, 17);
            this.RBDataB7.Margin = new System.Windows.Forms.Padding(2);
            this.RBDataB7.Name = "RBDataB7";
            this.RBDataB7.Size = new System.Drawing.Size(31, 17);
            this.RBDataB7.TabIndex = 0;
            this.RBDataB7.TabStop = true;
            this.RBDataB7.Text = "7";
            this.RBDataB7.UseVisualStyleBackColor = true;
            this.RBDataB7.Click += new System.EventHandler(this.DataBits_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.RBStopB2);
            this.groupBox5.Controls.Add(this.RBStopB1);
            this.groupBox5.Location = new System.Drawing.Point(370, 194);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(94, 41);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Stop bits:";
            // 
            // RBStopB2
            // 
            this.RBStopB2.AutoSize = true;
            this.RBStopB2.Location = new System.Drawing.Point(59, 17);
            this.RBStopB2.Margin = new System.Windows.Forms.Padding(2);
            this.RBStopB2.Name = "RBStopB2";
            this.RBStopB2.Size = new System.Drawing.Size(31, 17);
            this.RBStopB2.TabIndex = 1;
            this.RBStopB2.TabStop = true;
            this.RBStopB2.Text = "2";
            this.RBStopB2.UseVisualStyleBackColor = true;
            this.RBStopB2.Click += new System.EventHandler(this.StopBits_CheckedChanged);
            // 
            // RBStopB1
            // 
            this.RBStopB1.AutoSize = true;
            this.RBStopB1.Location = new System.Drawing.Point(12, 17);
            this.RBStopB1.Margin = new System.Windows.Forms.Padding(2);
            this.RBStopB1.Name = "RBStopB1";
            this.RBStopB1.Size = new System.Drawing.Size(31, 17);
            this.RBStopB1.TabIndex = 0;
            this.RBStopB1.TabStop = true;
            this.RBStopB1.Text = "1";
            this.RBStopB1.UseVisualStyleBackColor = true;
            this.RBStopB1.Click += new System.EventHandler(this.StopBits_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(273, 249);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(179, 116);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Serial port information:";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(272, 381);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(81, 26);
            this.btOK.TabIndex = 6;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(370, 381);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(82, 26);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "CANCEL";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // SW_SerialComSetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 419);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SW_SerialComSetUp";
            this.Text = "SelectAndConfigSP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SW_SerialComSetUp_FormClosed);
            this.Load += new System.EventHandler(this.SelectAndConfigSP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RB115200;
        private System.Windows.Forms.RadioButton RB57600;
        private System.Windows.Forms.RadioButton RB38400;
        private System.Windows.Forms.RadioButton RB19200;
        private System.Windows.Forms.RadioButton RB14400;
        private System.Windows.Forms.RadioButton RB9600;
        private System.Windows.Forms.RadioButton RB4800;
        private System.Windows.Forms.RadioButton RB2400;
        private System.Windows.Forms.RadioButton RB1200;
        private System.Windows.Forms.RadioButton RB600;
        private System.Windows.Forms.RadioButton RB300;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RBParityNone;
        private System.Windows.Forms.RadioButton RBParityOdd;
        private System.Windows.Forms.RadioButton RBParityEven;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton RBDataB8;
        private System.Windows.Forms.RadioButton RBDataB7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton RBStopB2;
        private System.Windows.Forms.RadioButton RBStopB1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.ListView LVSerialPort;
        private System.Windows.Forms.ColumnHeader Port;
        private System.Windows.Forms.ColumnHeader Description;
    }
}
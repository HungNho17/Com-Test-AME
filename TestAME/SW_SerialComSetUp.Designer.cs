﻿namespace TestAME
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CLBSerialPort = new System.Windows.Forms.CheckedListBox();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CLBSerialPort);
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 487);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Ports";
            // 
            // CLBSerialPort
            // 
            this.CLBSerialPort.CheckOnClick = true;
            this.CLBSerialPort.FormattingEnabled = true;
            this.CLBSerialPort.Location = new System.Drawing.Point(6, 21);
            this.CLBSerialPort.MultiColumn = true;
            this.CLBSerialPort.Name = "CLBSerialPort";
            this.CLBSerialPort.Size = new System.Drawing.Size(252, 446);
            this.CLBSerialPort.TabIndex = 0;
            this.CLBSerialPort.Tag = "";
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
            this.groupBox2.Location = new System.Drawing.Point(319, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Baud Rate:";
            // 
            // RB115200
            // 
            this.RB115200.AutoSize = true;
            this.RB115200.Location = new System.Drawing.Point(184, 81);
            this.RB115200.Name = "RB115200";
            this.RB115200.Size = new System.Drawing.Size(74, 21);
            this.RB115200.TabIndex = 10;
            this.RB115200.TabStop = true;
            this.RB115200.Text = "115.2K";
            this.RB115200.UseVisualStyleBackColor = true;
            // 
            // RB57600
            // 
            this.RB57600.AutoSize = true;
            this.RB57600.Location = new System.Drawing.Point(184, 54);
            this.RB57600.Name = "RB57600";
            this.RB57600.Size = new System.Drawing.Size(66, 21);
            this.RB57600.TabIndex = 9;
            this.RB57600.TabStop = true;
            this.RB57600.Text = "57.6K";
            this.RB57600.UseVisualStyleBackColor = true;
            // 
            // RB38400
            // 
            this.RB38400.AutoSize = true;
            this.RB38400.Location = new System.Drawing.Point(184, 27);
            this.RB38400.Name = "RB38400";
            this.RB38400.Size = new System.Drawing.Size(66, 21);
            this.RB38400.TabIndex = 8;
            this.RB38400.TabStop = true;
            this.RB38400.Text = "38.4K";
            this.RB38400.UseVisualStyleBackColor = true;
            // 
            // RB19200
            // 
            this.RB19200.AutoSize = true;
            this.RB19200.Location = new System.Drawing.Point(101, 105);
            this.RB19200.Name = "RB19200";
            this.RB19200.Size = new System.Drawing.Size(66, 21);
            this.RB19200.TabIndex = 7;
            this.RB19200.TabStop = true;
            this.RB19200.Text = "19.2K";
            this.RB19200.UseVisualStyleBackColor = true;
            // 
            // RB14400
            // 
            this.RB14400.AutoSize = true;
            this.RB14400.Location = new System.Drawing.Point(101, 81);
            this.RB14400.Name = "RB14400";
            this.RB14400.Size = new System.Drawing.Size(66, 21);
            this.RB14400.TabIndex = 6;
            this.RB14400.TabStop = true;
            this.RB14400.Text = "14.4K";
            this.RB14400.UseVisualStyleBackColor = true;
            // 
            // RB9600
            // 
            this.RB9600.AutoSize = true;
            this.RB9600.Location = new System.Drawing.Point(101, 54);
            this.RB9600.Name = "RB9600";
            this.RB9600.Size = new System.Drawing.Size(61, 21);
            this.RB9600.TabIndex = 5;
            this.RB9600.TabStop = true;
            this.RB9600.Text = "9600";
            this.RB9600.UseVisualStyleBackColor = true;
            // 
            // RB4800
            // 
            this.RB4800.AutoSize = true;
            this.RB4800.Location = new System.Drawing.Point(101, 27);
            this.RB4800.Name = "RB4800";
            this.RB4800.Size = new System.Drawing.Size(61, 21);
            this.RB4800.TabIndex = 4;
            this.RB4800.TabStop = true;
            this.RB4800.Text = "4800";
            this.RB4800.UseVisualStyleBackColor = true;
            // 
            // RB2400
            // 
            this.RB2400.AutoSize = true;
            this.RB2400.Location = new System.Drawing.Point(15, 105);
            this.RB2400.Name = "RB2400";
            this.RB2400.Size = new System.Drawing.Size(61, 21);
            this.RB2400.TabIndex = 3;
            this.RB2400.TabStop = true;
            this.RB2400.Text = "2400";
            this.RB2400.UseVisualStyleBackColor = true;
            // 
            // RB1200
            // 
            this.RB1200.AutoSize = true;
            this.RB1200.Location = new System.Drawing.Point(15, 81);
            this.RB1200.Name = "RB1200";
            this.RB1200.Size = new System.Drawing.Size(61, 21);
            this.RB1200.TabIndex = 2;
            this.RB1200.TabStop = true;
            this.RB1200.Text = "1200";
            this.RB1200.UseVisualStyleBackColor = true;
            // 
            // RB600
            // 
            this.RB600.AutoSize = true;
            this.RB600.Location = new System.Drawing.Point(15, 54);
            this.RB600.Name = "RB600";
            this.RB600.Size = new System.Drawing.Size(53, 21);
            this.RB600.TabIndex = 1;
            this.RB600.TabStop = true;
            this.RB600.Text = "600";
            this.RB600.UseVisualStyleBackColor = true;
            // 
            // RB300
            // 
            this.RB300.AutoSize = true;
            this.RB300.Location = new System.Drawing.Point(14, 27);
            this.RB300.Name = "RB300";
            this.RB300.Size = new System.Drawing.Size(53, 21);
            this.RB300.TabIndex = 0;
            this.RB300.TabStop = true;
            this.RB300.Text = "300";
            this.RB300.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RBParityNone);
            this.groupBox3.Controls.Add(this.RBParityOdd);
            this.groupBox3.Controls.Add(this.RBParityEven);
            this.groupBox3.Location = new System.Drawing.Point(320, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 68);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parity:";
            // 
            // RBParityNone
            // 
            this.RBParityNone.AutoSize = true;
            this.RBParityNone.Location = new System.Drawing.Point(183, 29);
            this.RBParityNone.Name = "RBParityNone";
            this.RBParityNone.Size = new System.Drawing.Size(63, 21);
            this.RBParityNone.TabIndex = 2;
            this.RBParityNone.TabStop = true;
            this.RBParityNone.Text = "None";
            this.RBParityNone.UseVisualStyleBackColor = true;
            // 
            // RBParityOdd
            // 
            this.RBParityOdd.AutoSize = true;
            this.RBParityOdd.Location = new System.Drawing.Point(100, 29);
            this.RBParityOdd.Name = "RBParityOdd";
            this.RBParityOdd.Size = new System.Drawing.Size(56, 21);
            this.RBParityOdd.TabIndex = 1;
            this.RBParityOdd.TabStop = true;
            this.RBParityOdd.Text = "Odd";
            this.RBParityOdd.UseVisualStyleBackColor = true;
            // 
            // RBParityEven
            // 
            this.RBParityEven.AutoSize = true;
            this.RBParityEven.Location = new System.Drawing.Point(13, 29);
            this.RBParityEven.Name = "RBParityEven";
            this.RBParityEven.Size = new System.Drawing.Size(61, 21);
            this.RBParityEven.TabIndex = 0;
            this.RBParityEven.TabStop = true;
            this.RBParityEven.Text = "Even";
            this.RBParityEven.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RBDataB8);
            this.groupBox4.Controls.Add(this.RBDataB7);
            this.groupBox4.Location = new System.Drawing.Point(320, 239);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(124, 50);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data bits:";
            // 
            // RBDataB8
            // 
            this.RBDataB8.AutoSize = true;
            this.RBDataB8.Location = new System.Drawing.Point(81, 21);
            this.RBDataB8.Name = "RBDataB8";
            this.RBDataB8.Size = new System.Drawing.Size(37, 21);
            this.RBDataB8.TabIndex = 1;
            this.RBDataB8.TabStop = true;
            this.RBDataB8.Text = "8";
            this.RBDataB8.UseVisualStyleBackColor = true;
            // 
            // RBDataB7
            // 
            this.RBDataB7.AutoSize = true;
            this.RBDataB7.Location = new System.Drawing.Point(15, 21);
            this.RBDataB7.Name = "RBDataB7";
            this.RBDataB7.Size = new System.Drawing.Size(37, 21);
            this.RBDataB7.TabIndex = 0;
            this.RBDataB7.TabStop = true;
            this.RBDataB7.Text = "7";
            this.RBDataB7.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.RBStopB2);
            this.groupBox5.Controls.Add(this.RBStopB1);
            this.groupBox5.Location = new System.Drawing.Point(450, 239);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(126, 50);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Stop bits:";
            // 
            // RBStopB2
            // 
            this.RBStopB2.AutoSize = true;
            this.RBStopB2.Location = new System.Drawing.Point(79, 21);
            this.RBStopB2.Name = "RBStopB2";
            this.RBStopB2.Size = new System.Drawing.Size(37, 21);
            this.RBStopB2.TabIndex = 1;
            this.RBStopB2.TabStop = true;
            this.RBStopB2.Text = "2";
            this.RBStopB2.UseVisualStyleBackColor = true;
            // 
            // RBStopB1
            // 
            this.RBStopB1.AutoSize = true;
            this.RBStopB1.Location = new System.Drawing.Point(16, 21);
            this.RBStopB1.Name = "RBStopB1";
            this.RBStopB1.Size = new System.Drawing.Size(37, 21);
            this.RBStopB1.TabIndex = 0;
            this.RBStopB1.TabStop = true;
            this.RBStopB1.Text = "1";
            this.RBStopB1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(321, 307);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(239, 193);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Serial port information:";
            // 
            // SW_SerialComSetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 516);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.CheckedListBox CLBSerialPort;
    }
}
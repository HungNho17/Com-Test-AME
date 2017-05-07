using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestAME
{
    public partial class MW_AmeTest : Form
    {
        SerialComPort ComPort = null;

        public MW_AmeTest()
        {
            InitializeComponent();
        }

        public void UpdateStatusConnect()
        {
            BTConnectSP.Text = "Serial " + SPort.PortName;
        }

        public void InitializeSPort()
        {
            ComPort = new SerialComPort(SPort);
            string[] port = ComPort.GetNameAllSerialPortValid();
            SPort.PortName = port[0];
            UpdateStatusConnect();
        }

        private void AME_APP_TEST_Load(object sender, EventArgs e)
        {
            InitializeSPort();
            MessageBox.Show(SPort.PortName);
        }

        private void BTSPort_Click(object sender, EventArgs e)
        {
            SW_SerialComSetUp SubFormSPort = new SW_SerialComSetUp(SPort);
            SubFormSPort.FormClosed += new FormClosedEventHandler(SubFormSPortClosed); 
            SubFormSPort.Show();
        }

        void SubFormSPortClosed(object sender, FormClosedEventArgs e)  
        {  
            MessageBox.Show("Form 2 Closed!");
            UpdateStatusConnect();
        }

    }
}

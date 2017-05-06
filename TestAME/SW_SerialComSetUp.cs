using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace TestAME
{
    public partial class SW_SerialComSetUp : Form
    {
        SerialPort ComPort = null;
        List<RadioButton> ListRBBaudRateIdx = null;
        int[] ListBaudRateValue;

        string PortName = null;
        int PortBaudRate;
        int PortDataBits;
        Parity PortParity;
        StopBits PortStopBit;

        public SW_SerialComSetUp(SerialPort SPort)
        {
            InitializeComponent();
            ComPort = SPort;
            ListRBBaudRateIdx = new List<RadioButton>() { RB300, RB600, RB1200, RB2400, RB4800, RB9600, RB14400, RB19200, RB38400, RB57600, RB115200 };
            ListBaudRateValue = new int[] { 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 57600,115200 };
        }

        public void RefreshComport()
        { 
            string[] port = SerialPort.GetPortNames();
            foreach(string element in port)
            {
                CLBSerialPort.Items.Add(element);
            }
            CLBSerialPort.SetItemChecked(0, true);
        }
        public void LoadVariableSPortDefault()
        {
            RefreshComport();
            PortName = CLBSerialPort.Items[0].ToString();
            RB9600.Checked = true; PortBaudRate = 9600;
            RBParityNone.Checked = true; PortParity = Parity.None;
            RBDataB8.Checked = true; PortDataBits = 8;
            RBStopB1.Checked = true; PortStopBit = StopBits.One;
        }

        // Form loading.
        private void SelectAndConfigSP_Load(object sender, EventArgs e)
        {
            LoadVariableSPortDefault();
        }

        // Even manage.
        private void BaudRate_CheckedChanged(object sender, EventArgs e)
        {
            int index = ListRBBaudRateIdx.IndexOf(sender as RadioButton);
        }

        private void SW_SerialComSetUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            ComPort.PortName = PortName;
            ComPort.BaudRate = PortBaudRate;
            ComPort.Parity = PortParity;
            ComPort.DataBits = PortDataBits;
            ComPort.StopBits = PortStopBit;
        }


    }
}

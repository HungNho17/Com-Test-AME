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
//==============================================================================
// Type definition.
//==============================================================================
        DataGrid Datagrid = new DataGrid();

//==============================================================================
// All Atributes.
//==============================================================================
        SerialPort ComPort = null;
        List<RadioButton> ListRBBaudRateIdx = null;
        int[] ListBaudRateValue;

        string PortName = null;
        int PortBaudRate;
        int PortDataBits;
        Parity PortParity;
        StopBits PortStopBit;

//==============================================================================
// Window Actions.
//==============================================================================
        public SW_SerialComSetUp(SerialPort SPort)
        {
            InitializeComponent();
            ComPort = SPort;
            ListRBBaudRateIdx = new List<RadioButton>() { RB300, RB600, RB1200, RB2400, RB4800, RB9600, RB14400, RB19200, RB38400, RB57600, RB115200 };
            ListBaudRateValue = new int[] { 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 57600,115200 };
        }

        private void SelectAndConfigSP_Load(object sender, EventArgs e)
        {
            if (ComPort.IsOpen)
            {
                LoadVariableSPort();
            }
            else
            {
                LoadVariableDefault();
            }
        }

//==============================================================================
// Internal Actions.
//==============================================================================
        public void RefreshComport()
        { 
            string[] port = SerialPort.GetPortNames();

            foreach(string element in port)
            {
                CLBSerialPort.Items.Add(element);
            }
            CLBSerialPort.SetItemChecked(0, true);
        }

        public void LoadVariableDefault()
        {
            RefreshComport();
            PortName = CLBSerialPort.Items[0].ToString();
            PortBaudRate = 9600;
            PortParity = Parity.None;
            PortDataBits = 8;
            PortStopBit = StopBits.One;

            LoadStatusWindow();
        }

        public void LoadVariableSPort()
        {
            RefreshComport();
            PortName = ComPort.PortName;
            PortBaudRate = ComPort.BaudRate;
            PortParity = ComPort.Parity;
            PortDataBits = ComPort.DataBits;
            PortStopBit = ComPort.StopBits;

            LoadStatusWindow();
        }

        public void LoadStatusWindow()
        {
            for (int i = 0; i < 11; i++)
            {
                if (ListBaudRateValue[i] == PortBaudRate) ListRBBaudRateIdx[i].Checked = true;
            }

            if (PortParity == Parity.Even)
            {
                RBParityEven.Checked = true;
            }
            else if (PortParity == Parity.Odd)
            {
                RBParityOdd.Checked = true;
            }
            else if (PortParity == Parity.None)
            {
                RBParityNone.Checked = true;
            }

            if (PortDataBits == 7)
            {
                RBDataB7.Checked = true;
            }
            else if (PortDataBits == 8)
            {
                RBDataB8.Checked = true;
            }

            if (PortStopBit == StopBits.One)
            {
                RBStopB1.Checked = true;
            }
            else if (PortStopBit == StopBits.Two)
            {
                RBStopB2.Checked = true;
            }
             
        }


//==============================================================================
// Event Process
//==============================================================================
        private void BaudRate_CheckedChanged(object sender, EventArgs e)
        {
            int index = ListRBBaudRateIdx.IndexOf(sender as RadioButton);
            for (int i = 0; i < 11; i++)
            {
                if (i == index)
                {
                    PortBaudRate = ListBaudRateValue[i];
                }
            }
        }

        private void Parity_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton temp = sender as RadioButton;
            if (temp == RBParityEven)
            {
                PortParity = Parity.Even;
            }
            else if (temp == RBParityOdd)
            {
                PortParity = Parity.Odd;
            }
            else if (temp == RBParityNone)
            {
                PortParity = Parity.None;
            }
        }

        private void DataBits_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton temp = sender as RadioButton;
            if (temp == RBDataB7)
            {
                PortDataBits = 7;
            }
            else if (temp == RBDataB8)
            {
                PortDataBits = 8;
            }
        }

        private void StopBits_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton temp = sender as RadioButton;
            if (temp == RBStopB1)
            {
                PortStopBit = StopBits.One;
            }
            else if (temp == RBStopB2)
            {
                PortStopBit = StopBits.Two;
            }
        }

        private void SW_SerialComSetUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ComPort.IsOpen)
            {
                if (ComPort.PortName != PortName)
                {
                    ComPort.Close();
                    ComPort.PortName = PortName;
                }
            }

            ComPort.BaudRate = PortBaudRate;
            ComPort.Parity = PortParity;
            ComPort.DataBits = PortDataBits;
            ComPort.StopBits = PortStopBit;
        }

    }
}

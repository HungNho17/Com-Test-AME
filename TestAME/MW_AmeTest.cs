using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;

namespace TestAME
{

    public partial class MW_AmeTest : Form
    {
//==============================================================================
// Type definition.
//==============================================================================
        

//==============================================================================
// All Atributes.
//==============================================================================
        SerialComPort ComPort = null;
        List<Button> CommandBTList = null;
        List<Button> ConnectStatusBTList = null;

        bool FlagConnectStatus = false;
        bool FlagDisplayDataRecieve = true;
        bool FlagShowSpace = false;
        bool FlagShowLF = false;
        bool FlagWrapText = true;
        bool FlagSendLF = false;
        bool FlagSendTo = true;

        public delegate void AddDataDelegate(int datain);
        public AddDataDelegate myDelegate;
//==============================================================================
// Window Actions.
//==============================================================================
        public MW_AmeTest()
        {
            InitializeComponent();
        }

        // Event Window Loaded.
        private void AME_APP_TEST_Load(object sender, EventArgs e)
        {
            ReInitializeAllComponents();
            this.myDelegate = new AddDataDelegate(AddDataMethod);

        }

//==============================================================================
// Internal Actions.
//==============================================================================

        // Initialize All Component of Window
        public void ReInitializeAllComponents()
        {
            ComPort = new SerialComPort(SPort);
            SPort.DataReceived += new SerialDataReceivedEventHandler(SPort_DataReceived);
            ConnectStatusBTList = new List<Button>() { btConnectSP, btDisplayRCData, btShowSpace, btShowLF};
            UpdateStatusWindow();
        }

        // Update Status For Window
        public void UpdateStatusWindow()
        {
            if (SPort.PortName != null)
            {
                btConnectSP.Text = "Serial " + SPort.PortName;
            }

            if (FlagConnectStatus) // update status connection
            {
                lbConnect.Image = TestAME.Properties.Resources.Green;
            }
            else
            {
                lbConnect.Image = TestAME.Properties.Resources.Red;
            }
            
            if (FlagShowSpace )
            {
                lbShowSpace.Image = TestAME.Properties.Resources.Green;
            }
            else
            {
                lbShowSpace.Image = TestAME.Properties.Resources.Red;
            }

            if (FlagShowLF)
            {
                lbShowLF.Image = TestAME.Properties.Resources.Green;
            }
            else
            {
                lbShowLF.Image = TestAME.Properties.Resources.Red;
            }

            if (FlagDisplayDataRecieve == false) // update status data recieve display
            {
                tbDataRecieve.BackColor = Color.MediumBlue;
                lbDisplayRCData.Image = TestAME.Properties.Resources.Red;
            }
            else
            {
                tbDataRecieve.BackColor = Color.Black;
                lbDisplayRCData.Image = TestAME.Properties.Resources.Green;
            }

            if (FlagWrapText) // update status process data recieve
            {
                lbWrapText.Image = TestAME.Properties.Resources.Green;
            }
            else
            {
                lbWrapText.Image = TestAME.Properties.Resources.Red;
            }

            if (FlagSendLF) // update status process data sending
            {
                lbSendLF.Image = TestAME.Properties.Resources.Green;
            }
            else
            {
                lbSendLF.Image = TestAME.Properties.Resources.Red;
            }

            if (FlagSendTo)
            {
                lbToCommunicate.Image = TestAME.Properties.Resources.Green;
                lbToLocalCMD.Image = TestAME.Properties.Resources.Red;
            }
            else
            {
                lbToCommunicate.Image = TestAME.Properties.Resources.Red;
                lbToLocalCMD.Image = TestAME.Properties.Resources.Green;
            }
        }

        public bool ProcessDataRecieved(int data)
        {
            bool ret = true;
            string temp = ComPort.ProcessDataRecieve(data);
            
            tbDataRecieve.SelectionStart = tbDataRecieve.TextLength;
            tbDataRecieve.SelectionLength = 0;
            tbDataRecieve.SelectionColor = Color.Yellow;
            tbDataRecieve.AppendText(temp);
            tbDataRecieve.SelectionColor = tbDataRecieve.ForeColor;

            return ret;
        }

//==============================================================================
// Event Process
//==============================================================================
        private void BTSPort_Click(object sender, EventArgs e)
        {
            SW_SerialComSetUp SubFormSPort = new SW_SerialComSetUp(SPort);
            SubFormSPort.FormClosed += new FormClosedEventHandler(SubFormSPortClosed); 
            SubFormSPort.ShowDialog();
        }

        void SubFormSPortClosed(object sender, FormClosedEventArgs e)  
        {  
            // Do something if it in need!

            UpdateStatusWindow();
        }

        private void BTConnectStatus_Click(object sender, EventArgs e)
        {
            int IndexSender = ConnectStatusBTList.IndexOf(sender as Button);
            switch (IndexSender)
            { 
                case 0: // bt connect
                    if (FlagConnectStatus == false)
                    {
                        if (ComPort.OpenSPort())
                        {
                            FlagConnectStatus = true;
                        }
                    }
                    else
                    {
                        if (ComPort.CloseSPort())
                        {
                            FlagConnectStatus = false;
                        }
                    }
                    break;

                case 1: // bt datarecieve display
                    FlagDisplayDataRecieve ^= true;
                    break;
                case 2: // bt show space
                    FlagShowSpace ^= true;
                    break;
                case 3: // bt show endline character.
                    FlagShowLF ^= true;
                    break;

                default:
                    break;
            }

            UpdateStatusWindow();
        }

        public void AddDataMethod(int dataIn)
        {
            ProcessDataRecieved(dataIn);
        }

        void SPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            int indata = 0;
            while (indata != (-1))
            {
                try
                {
                    indata = sp.ReadByte();
                    this.Invoke(this.myDelegate, new Object[] { indata });
                }
                catch { break; }
            }
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            if (tbDataSend.Text != null)
            {
                ComPort.SendData(tbDataSend.Text);
            }
        }
    }
}

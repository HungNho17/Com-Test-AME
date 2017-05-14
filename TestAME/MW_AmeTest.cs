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
using System.Runtime.InteropServices;

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
        List<Button> ControlUIBTList = null;

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
            ControlUIBTList = new List<Button>() { btWrapTextCo, btClearCo, btNewLineCo, btSendLFLo, btClearLo, btCharToCo, btCharToLo };
            UpdateStatusWindow();
            UpdateCharSetTable();
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

                if (FlagDisplayDataRecieve == false) // update status data recieve display
                {
                    tbDataRecieve.BackColor = Color.DarkBlue;
                    lbDisplayRCData.Image = TestAME.Properties.Resources.Red;
                }
                else
                {
                    tbDataRecieve.BackColor = Color.Black;
                    lbDisplayRCData.Image = TestAME.Properties.Resources.Green;
                }
            }
            else
            {
                lbConnect.Image = TestAME.Properties.Resources.Red;

                tbDataRecieve.BackColor = Color.DarkBlue;
                lbDisplayRCData.Image = TestAME.Properties.Resources.Red;
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

            if (FlagWrapText) // update status process data recieve
            {
                lbWrapText.Image = TestAME.Properties.Resources.Green;
                tbDataRecieve.WordWrap = true;
            }
            else
            {
                lbWrapText.Image = TestAME.Properties.Resources.Red;
                tbDataRecieve.WordWrap = false;
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

        // Update Char Set Table
        public void UpdateCharSetTable()
        {
            DataTable TempTable = null;
            ListViewItem TempItem = null;

            TempTable = ComPort.ProcessCharSetTable().Copy();
            foreach (DataRow element in TempTable.Rows)
            {
                TempItem = new ListViewItem(element[0].ToString());
                TempItem.SubItems.Add(element[1].ToString());
                TempItem.SubItems.Add(element[2].ToString());
                lvCharSet.Items.Add(TempItem);
            }
            lvCharSet.FullRowSelect = true;
        }

        // Update data recieved into texbox recieve
        public bool UpdateDataRecieved(int data, bool flagFromSP)
        {
            bool ret = true;

            // Do nothing.
            if (!FlagDisplayDataRecieve || (data == -1)) 
                return ret;

            string temp = ComPort.RecieveDataProcessing(data, FlagShowLF, FlagShowSpace);
            
            tbDataRecieve.SelectionStart = tbDataRecieve.TextLength;
            tbDataRecieve.SelectionLength = 0;

            if (flagFromSP)
                tbDataRecieve.SelectionColor = Color.Yellow;

            tbDataRecieve.AppendText(temp);
            tbDataRecieve.Focus();
            tbDataRecieve.SelectionStart = tbDataRecieve.Text.Length;
            tbDataRecieve.SelectionColor = tbDataRecieve.ForeColor;
            return ret;
        }

        /// <summary>
        /// CONVERT KEYCODE TO INT OF ASSCII CHARACTER
        /// </summary>
        public int KeyCodeToUnicode(Keys key)
        {
            int iResult = 0;
            byte[] keyboardState = new byte[255];
            bool keyboardStateStatus = GetKeyboardState(keyboardState);

            if (!keyboardStateStatus)
            {
                return 0;
            }

            uint virtualKeyCode = (uint)key;
            uint scanCode = MapVirtualKey(virtualKeyCode, 0);
            IntPtr inputLocaleIdentifier = GetKeyboardLayout(0);

            StringBuilder result = new StringBuilder();
            ToUnicodeEx(virtualKeyCode, scanCode, keyboardState, result, (int)5, (uint)0, inputLocaleIdentifier);
            try
            {
                iResult = result[0];
            }
            catch 
            { 
                iResult = -1;
            }
            
            return iResult;
        }
        [DllImport("user32.dll")]
        static extern bool GetKeyboardState(byte[] lpKeyState);
        [DllImport("user32.dll")]
        static extern uint MapVirtualKey(uint uCode, uint uMapType);
        [DllImport("user32.dll")]
        static extern IntPtr GetKeyboardLayout(uint idThread);
        [DllImport("user32.dll")]
        static extern int ToUnicodeEx(uint wVirtKey, uint wScanCode, byte[] lpKeyState, [Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, uint wFlags, IntPtr dwhkl);

//==============================================================================
// Event Process
//==============================================================================
        /// <summary>
        /// SUB FORM SET UP SERIAL PORT ENTER
        /// </summary>
        private void BTSPort_Click(object sender, EventArgs e)
        {
            SW_SerialComSetUp SubFormSPort = new SW_SerialComSetUp(SPort);
            SubFormSPort.FormClosed += new FormClosedEventHandler(SubFormSPortClosed); 
            SubFormSPort.ShowDialog();
        }

        /// <summary>
        /// SUP FORM SET UP SERIAL PORT CLOSE
        /// </summary>
        void SubFormSPortClosed(object sender, FormClosedEventArgs e)  
        {  
            // Do something if it in need!
            UpdateStatusWindow();
        }

        /// <summary>
        /// PROCESS MULTI BUTTON - CONNECTING ACTION
        /// </summary>
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
                        else
                        {
                            MessageBox.Show("Comport Fail!");
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

        /// <summary>
        /// PROCESS MULTI BUTTON - CONTROL UI
        /// </summary>
        private void BTControlUI_Click(object sender, EventArgs e)
        {
            int IndexSender = ControlUIBTList.IndexOf(sender as Button);
            switch (IndexSender)
            {
                case 0: // bt wrap text
                    FlagWrapText ^= true;
                    break;

                case 1: // bt clear co
                    tbDataRecieve.Text = "";
                    break;
                case 2: // bt new line
                    tbDataRecieve.Text += "\n";
                    break;
                case 3: // bt send lf
                    FlagSendLF ^= true;
                    break;
                case 4: // bt clear lo
                    tbDataSend.Text = "";
                    break;
                case 5: // bt char to co
                    FlagSendTo = true;
                    break;
                case 6: // bt char to lo
                    FlagSendTo = false;
                    break;

                default:
                    break;
            }

            UpdateStatusWindow();
        }

        /// <summary>
        /// PROCESS DATA RECIEVE FORM SERIAL PORT
        /// </summary>
        public void AddDataMethod(int dataIn)
        {
            UpdateDataRecieved(dataIn, true); // from SP
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

        /// <summary>
        /// PROCESS SEND DATA VIA SERIAL PORT
        /// </summary>
        private void btSend_Click(object sender, EventArgs e)
        {
            if (tbDataSend.Text != null)
            {
                ComPort.SendData(tbDataSend.Text, FlagSendLF);
            }
        }

        /// <summary>
        /// TEXT BOX DATA RECIEVE SELECTION
        /// </summary>
        private void TBDataRecive_Click(object sender, EventArgs e)
        {
            tbDataRecieve.Focus();
            tbDataRecieve.SelectionStart = tbDataRecieve.Text.Length;
        }

        /// <summary>
        /// PROCESS DATA RECIEVE TEXT CHANGE
        /// </summary>
        private void TBDataRecieve_TextChange(object sender, EventArgs e)
        {
            //tbDataRecieve.Text = tbDataRecieve.Text.Remove(tbDataRecieve.Text.Length - 1);
            //tbDataRecieve.SelectionStart = tbDataRecieve.Text.Length;
        }

        /// <summary>
        /// PROCESS WINDOW KEYBOARD PRESS
        /// </summary>
        private void WindowKeyDown_Event(object sender, KeyEventArgs e)
        {
            int temp = 0;
            e.Handled = true;

            temp = KeyCodeToUnicode(e.KeyCode);
            UpdateDataRecieved(temp, false); // from keyboard
        }
        private void WindowKeyUp_Event(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }
        private void WindowKeyPress_Event(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// PROCESS CHARACTER SELECT
        /// </summary>
        private void SelectCharacterSet_DoubleClick(object sender, EventArgs e)
        {
            
        }




    }
}

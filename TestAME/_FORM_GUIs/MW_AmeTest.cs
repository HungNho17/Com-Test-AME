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
using Microsoft.Win32;
using System.Management;
using System.Diagnostics;
using System.Security.AccessControl;

namespace TestAME
{

    public partial class MW_AmeTest : Form
    {
//==============================================================================
// All Atributes.
//==============================================================================
        ISerialComport          ComPort = null;
        P_UserCommandManagement UserCmd = null;

        List<Button> CommandBTList = null;
        List<Button> ConnectStatusBTList = null;
        List<Button> ControlUIBTList = null;
        static int IndextCounter = 0;
        static int TimerCounterCheckComport = 0;

        string[] btNameListCurrent = null;
        string[] cmdListCurrent = null;

        bool FlagConnectStatus = false;
        bool FlagDisplayDataRecieve = true;
        bool FlagShowSpace = false;
        bool FlagShowLF = false;
        bool FlagWrapText = true;
        bool FlagSendLF = false;
        bool FlagSendTo = true;
        bool FlagTimeStamping = false;
        bool FlagIndexStamping = false;

        bool FlagRTSOutput = true;
        bool FlagDTROutput = true;
        HANDSHAKE_TYPE HandshakeMode = HANDSHAKE_TYPE.BOTH;

        public delegate void AddDataDelegate(string datain);
        public AddDataDelegate myDelegate;

        SW_SerialComSetUp       SubFormSPort        = null;
        SW_SetupUserCommand     SubFormCmd          = null;
        SW_MultiCmd             SubFormMultiCmd     = null;
        SW_LabelsProgramming    SubFormSampleLabels = null;

        Size FormDefaultSize = new Size();
        bool FlagFlipView = false;

        //==============================================================================
        // Window Actions.
        //==============================================================================
        public MW_AmeTest()
        {
            InitializeComponent();
        }

        private void AME_APP_TEST_Load(object sender, EventArgs e)
        {
            FormDefaultSize = this.Size;
            ReInitializeAllComponents();

            this.myDelegate = new AddDataDelegate(AddDataMethod);
            ComPort.RegisterReceiveRealTime(new DataReceiveUpdate(Read));
        }

        private void AME_APP_TEST_Close(object sender, EventArgs e)
        {
            this.Close();
        }

//==============================================================================
// Internal Actions.
//==============================================================================

        public void ReInitializeAllComponents()
        {
            ComPort = new CSerialComPort(SPort);
            UserCmd = new P_UserCommandManagement();
            ConnectStatusBTList = new List<Button>() { btConnectSP, btDisplayRCData, btShowSpace, btShowLF,btTempConnect};
            ControlUIBTList = new List<Button>() { btWrapTextCo, btClearCo, btNewLineCo, btSendLFLo, btClearLo, btCharToCo, btCharToLo };
            CommandBTList = new List<Button>() { btCmd0,btCmd1,btCmd2,btCmd3,btCmd4,btCmd5,btCmd6,btCmd7};

            UpdateOldPortAndAutoReconnect();
            UpdateStatusWindow();
            UpdateCharSetTable();
            UpdateUserButtonCmd();
            UpdateRightContextManu();
            UpdateKeyboarStatus();

            if (Properties.Settings.Default.Handshake > 0)
            {
                HandshakeMode = (HANDSHAKE_TYPE)Properties.Settings.Default.Handshake;
            }
        }
        public void UpdateOldPortAndAutoReconnect()
        {
            if (ComPort.LoadOldComPort())
            {
                tsmiAutoReconnect.Checked = false;
                if (Properties.Settings.Default.AutoReconnect == true)
                {
                    tsmiAutoReconnect.Checked = true;
                    btConnectSP.PerformClick();
                }
            }
        }

        public void UpdateStatusWindow()
        {
            if (SPort != null)
            {
                btConnectSP.Text = "Serial " + SPort.PortName;
            }

            if (FlagConnectStatus) // update status connection
            {
                lbConnect.Image = TestAME.Properties.Resources.Green;
                lbTempStatus.Image = TestAME.Properties.Resources.Green;

                if (FlagDisplayDataRecieve == false) // update status data recieve display
                {
                    tbDataRecieve.BackColor = Color.Navy;
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
                lbTempStatus.Image = TestAME.Properties.Resources.Red;

                tbDataRecieve.BackColor = Color.Navy;
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

            // temp init but do not tracking yet...
            UpdateCTSaDTRStatus();

        }

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

            lvCharSet.Columns[0].Width = (lvCharSet.Width * 33) / 100;
            lvCharSet.Columns[1].Width = (lvCharSet.Width * 20) / 100;
            lvCharSet.Columns[2].Width = (lvCharSet.Width * 27) / 100;
        }

        public bool UpdateDataRecieved(string data, bool flagFromSP)
        {
            bool ret = true;

            if (FlagDisplayDataRecieve && (data != null))
            {
                tbDataRecieve.Focus();
                string temp = ComPort.ProcessPureString(data, FlagShowLF, FlagShowSpace);

                if (temp != null)
                {
                    string temp1 = UpdateStamping(temp.Substring(temp.Length-1,1));
                    if (temp1 != null)
                    {
                        tbDataRecieve.SelectionColor  = tbDataRecieve.ForeColor;
                        tbDataRecieve.AppendText(temp1);
                    }

                    if (flagFromSP)
                    {
                        tbDataRecieve.SelectionStart = tbDataRecieve.TextLength;
                        tbDataRecieve.SelectionLength = 0;
                        tbDataRecieve.SelectionColor = Color.Yellow;
                    }

                    tbDataRecieve.AppendText(temp);
                    tbDataRecieve.SelectionColor = tbDataRecieve.ForeColor;

                    if ((SubFormMultiCmd != null) && flagFromSP)
                    {
                        //SubFormMultiCmd.UpdateFeedBackSending(temp);
                    }
                }
            }

            return ret;
        }

        public bool UpdateDataTransmited(string dataIn)
        {
            bool bRet = false;
            if (dataIn == null) return bRet;

            string temp1 = UpdateStamping(dataIn.Substring(dataIn.Length-1,1));
            if (temp1 != null)
                tbDataRecieve.AppendText(temp1);

            tbDataRecieve.AppendText(dataIn);
            tbDataRecieve.Focus();
            tbDataRecieve.SelectionStart = tbDataRecieve.Text.Length;
            tbDataRecieve.SelectionColor = tbDataRecieve.ForeColor;
            bRet = true;

            return bRet;
        }

        public bool UpdateUserButtonCmd()
        {
            bool bRet = false;

            btNameListCurrent = UserCmd.GetCurrentUserSetting(1);
            cmdListCurrent = UserCmd.GetCurrentUserSetting(0);

            bRet =  ProcessButtonCmd(btNameListCurrent);
            lbCurrentUser.Text = UserCmd.GetCurrentUserName();

            return bRet;
        }
        public bool ProcessButtonCmd(string[] btNameListTemp)
        {
            bool bRet = false;

            int idx = 0;
            foreach (string element in btNameListCurrent)
            {
                CommandBTList[idx].Text = "undefine";
                CommandBTList[idx].Enabled = false;
                if (element != "")
                {
                    CommandBTList[idx].Text = element;
                    CommandBTList[idx].Enabled = true;
                }
                idx++;
            }

            return bRet;
        }

        public bool UpdateKeyboarStatus()
        {
            bool bRet = true;

            lbCap.Enabled = false;
            lbNum.Enabled = false;
            lbSclr.Enabled = false;

            if (Control.IsKeyLocked(Keys.CapsLock)) lbCap.Enabled = true;
            if (Control.IsKeyLocked(Keys.NumLock)) lbNum.Enabled = true;
            if (Control.IsKeyLocked(Keys.Scroll)) lbSclr.Enabled = true;
            
            return bRet;
        }

        public bool UpdateRightContextManu()
        {
            bool bRet = true;

            // Menu of Data Recieve text box
            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Copy", new EventHandler(DataRecieveTB_copy));
            cm.MenuItems.Add("Pase", new EventHandler(DataRecieveTB_pase));
            tbDataRecieve.ContextMenu = cm; 

            return bRet;
        }
        public void DataRecieveTB_copy(object s, EventArgs e)
        {
            if (tbDataRecieve.Text == "") return;

            if (tbDataRecieve.SelectedText != "")
            {
                Clipboard.SetText(tbDataRecieve.SelectedText);
            }
            else
            {
                Clipboard.SetText(tbDataRecieve.Text);
            }
            
        }
        public void DataRecieveTB_pase(object s, EventArgs e)
        {
            string sTemp = Clipboard.GetText();
            if (sTemp != null)
            {
                tbDataRecieve.Text += sTemp;
            }
        }

        public string UpdateSuffix(int iType)
        {
            string sRet = null;

            switch (iType)
            {
                case 1:
                    sRet = "[" + DateTime.Now.ToString("hh:mm:ss.fff") + "]";
                    break;

                case 2:
                    sRet = "[" + IndextCounter.ToString() + "]";
                    break;

                default:
                    break;
            }

            return sRet;
        }

        public string UpdateStamping(string dataIn)
        {
            string sRet = null;

            if (!tsmiIndexStamping.Checked && !tsmiTimeStamping.Checked)
                return sRet;

            if (FlagIndexStamping)
            {
                string temp2 = UpdateSuffix(2);
                sRet = temp2;
                IndextCounter++;
                FlagIndexStamping = false;
            }
            if (tsmiIndexStamping.Checked)
            {
                if (dataIn == "\r" || dataIn == "\n")
                {
                    FlagIndexStamping = true;
                }
            }

            if (FlagTimeStamping)
            {
                string temp1 = UpdateSuffix(1);
                sRet += temp1;
                FlagTimeStamping = false;
            }
            if (tsmiTimeStamping.Checked)
            {
                if (dataIn == "\r" || dataIn == "\n")
                {
                    FlagTimeStamping = true;
                }
            }

            return sRet;
        }

        public bool UpdateCTSaDTRStatus()
        {
            bool bRet = true;

            lbCTSILow.Image = TestAME.Properties.Resources.D_green;
            lbDSRILow.Image = TestAME.Properties.Resources.D_green;
            lbRTSOLow.Image = TestAME.Properties.Resources.D_green;
            lbDTROLow.Image = TestAME.Properties.Resources.D_green;

            lbCTSIHigh.Image = TestAME.Properties.Resources.D_brown;
            lbDSRIHigh.Image = TestAME.Properties.Resources.D_brown;
            lbRTSOHigh.Image = TestAME.Properties.Resources.D_brown;
            lbDTROHigh.Image = TestAME.Properties.Resources.D_brown;
            
            lbCTSStatus.Enabled = false;
            lbDSRStatus.Enabled = false;
            btRTS.Enabled = false;
            btDTR.Enabled = false;

            tsmiRequestToSend.Checked = false;
            tsmiXonXoff.Checked = false;
            tsmiBoth.Checked = false;
            tsmiNone.Checked = false;
            
            if (HandshakeMode != (HANDSHAKE_TYPE)Properties.Settings.Default.Handshake)
            {
                Properties.Settings.Default.Handshake = (int)HandshakeMode;
                Properties.Settings.Default.Save();
            }

            if (FlagConnectStatus == true)
            {
                if (HandshakeMode == HANDSHAKE_TYPE.BOTH)
                {
                    lbCTSStatus.Enabled = true;
                    lbDSRStatus.Enabled = true;
                    btRTS.Enabled = true;
                    btDTR.Enabled = true;
                    tsmiBoth.Checked = true;
                }
                else if (HandshakeMode == HANDSHAKE_TYPE.REQUEST_TO_SEND)
                {
                    lbCTSStatus.Enabled = true;
                    btRTS.Enabled = true;
                    tsmiRequestToSend.Checked = true;
                }
                else if (HandshakeMode == HANDSHAKE_TYPE.XON_XOFF)
                {
                    lbDSRStatus.Enabled = true;
                    btDTR.Enabled = true;
                    tsmiXonXoff.Checked = true;
                }
                else
                {
                    tsmiNone.Checked = true;
                    return bRet;
                }
                
                if (ComPort.CTSGetting())
                    lbCTSIHigh.Image = TestAME.Properties.Resources.Red;
                else
                    lbCTSILow.Image = TestAME.Properties.Resources.Green;

                if (ComPort.DSRGetting())
                    lbDSRIHigh.Image = TestAME.Properties.Resources.Red;
                else
                    lbDSRILow.Image = TestAME.Properties.Resources.Green;

                if (FlagRTSOutput)
                    lbRTSOHigh.Image = TestAME.Properties.Resources.Red;
                else
                    lbRTSOLow.Image = TestAME.Properties.Resources.Green;

                if (FlagDTROutput)
                    lbDTROHigh.Image = TestAME.Properties.Resources.Red;
                else
                    lbDTROLow.Image = TestAME.Properties.Resources.Green;
            }

            return bRet;
        }

        public bool SendDataMethode(string dataIn)
        {
            bool bRet = false;
            if (ComPort.Write(dataIn, FlagSendLF))
            {
                UpdateDataTransmited(dataIn);
                bRet = true;
            }
            return bRet;
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
        static extern short GetKeyState(int keyCode);
        [DllImport("user32.dll")]
        static extern uint MapVirtualKey(uint uCode, uint uMapType);
        [DllImport("user32.dll")]
        static extern IntPtr GetKeyboardLayout(uint idThread);
        [DllImport("user32.dll")]
        static extern int ToUnicodeEx(uint wVirtKey, uint wScanCode, byte[] lpKeyState, [Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, uint wFlags, IntPtr dwhkl);

//==============================================================================
// Sub-Form Process
//==============================================================================
        /// <summary>
        /// SUB FORM SET UP SERIAL PORT
        /// </summary>
        private void BTSPort_Click(object sender, EventArgs e)
        {
            SubFormSPort = new SW_SerialComSetUp(SPort);
            SubFormSPort.FormClosed += new FormClosedEventHandler(SubFormSPortClosed); 
            SubFormSPort.ShowDialog();
        }
        void SubFormSPortClosed(object sender, FormClosedEventArgs e)  
        {  
            SubFormSPort = null;
            UpdateStatusWindow();
        }

        /// <summary>
        /// SUB FORM USER SETTING COMMAND
        /// </summary>
        private void BTSetupCmd_Click(object sender, EventArgs e)
        {
            SubFormCmd = new SW_SetupUserCommand();
            SubFormCmd.FormClosed += new FormClosedEventHandler(SubFormCmdClosed);
            SubFormCmd.ShowDialog();
        }
        void SubFormCmdClosed(object sender, FormClosedEventArgs e)
        {
            SubFormCmd = null;
            UpdateUserButtonCmd();
        }

        /// <summary>
        /// SUB FORM AME TEST SUPPORT
        /// </summary>
        private void Multi_Cmd_Load(object sender, EventArgs e)
        {
            if (SubFormMultiCmd == null)
            {
                SubFormMultiCmd = new SW_MultiCmd(ComPort);
                SubFormMultiCmd.FormClosed += new FormClosedEventHandler(SubFormMultiCmdClosed);
                SubFormMultiCmd.Show();
            }
        }
        void SubFormMultiCmdClosed(object sender, FormClosedEventArgs e)
        {
            SubFormMultiCmd = null;
        }

        /// <summary>
        /// SUB FORM SAMPLE LABELS SUPPORT
        /// </summary>
        private void SampleLabels_Load(object sender, EventArgs e)
        {
            if (SubFormSampleLabels == null)
            {
                SubFormSampleLabels = new SW_LabelsProgramming();
                SubFormSampleLabels.FormClosed += new FormClosedEventHandler(SubFormSampleLabelsClosed);
                SubFormSampleLabels.Show();
            }
        }
        void SubFormSampleLabelsClosed(object sender, FormClosedEventArgs e)
        {
            SubFormSampleLabels = null;
        }

//==============================================================================
// Event Process
//==============================================================================

        /// <summary>
        /// PROCESS MULTI BUTTON - CONNECTING ACTION
        /// </summary>
        private void BTConnectStatus_Click(object sender, EventArgs e)
        {
            int IndexSender = ConnectStatusBTList.IndexOf(sender as Button);
            switch (IndexSender)
            { 
                case 0: // bt connect
                case 4: // bt temp connect
                    if (FlagConnectStatus == false)
                    {
                        if (ComPort.OpenSPort())
                        {
                            ComPort.SaveComPort();
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

                    if (SubFormMultiCmd != null)
                    { }//SubFormMultiCmd.UpdateSystemInfo(FlagConnectStatus);
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
        
        private void BTRTSorDTR_Click(object sender, EventArgs e)
        {
            if ((sender as Button) == btRTS)
            {
                FlagRTSOutput ^= true;
                ComPort.RTSSetting(FlagRTSOutput);
                UpdateCTSaDTRStatus();
            }
            else if ((sender as Button) == btDTR)
            {
                FlagDTROutput ^= true;
                ComPort.DTRSetting(FlagDTROutput);
                UpdateCTSaDTRStatus();
            }
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

                    IndextCounter = 0;
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
        /// PROCESS MULTI BUTTON - USER COMMAND
        /// </summary>
        private void BTControlUserCmd_Click(object sender, EventArgs e)
        {
            string temp = null;
            int IndexSender = CommandBTList.IndexOf(sender as Button);

            ComPort.Write(cmdListCurrent[IndexSender], UserCmd.GetFlagInsertLF());
            temp = cmdListCurrent[IndexSender];

            if (UserCmd.GetFlagInsertLF())
            {
                temp += '\n';
            }
            UpdateDataTransmited(temp);
        }

        /// <summary>
        /// PROCESS DATA RECIEVE FORM SERIAL PORT
        /// </summary>
        public void AddDataMethod(string dataIn)
        {
            UpdateDataRecieved(dataIn, true); // from SP
        }

        public void Read(string sDataSport)
        {
            this.Invoke(this.myDelegate, new object[] { sDataSport});
        }

        /// <summary>
        /// PROCESS SEND DATA VIA SERIAL PORT
        /// </summary>
        private void btSend_Click(object sender, EventArgs e)
        {
            if ((tbDataSend.Text != null)&& (tbDataSend.Text != ""))
            {
                SendDataMethode(tbDataSend.Text);
            }
        }

        /// <summary>
        /// PROCESS WINDOW KEYBOARD PRESS ON TEXTBOX DATA RECIEVE
        /// </summary>
        private void WindowKeyDown_Event(object sender, KeyEventArgs e)
        {
            int iTemp = 0;
            string sTemp = null;
            e.Handled = true;

            iTemp = KeyCodeToUnicode(e.KeyCode);
            sTemp = ComPort.IntToAssciiStr(iTemp, FlagShowLF, FlagShowSpace);
            UpdateDataRecieved(sTemp, false); // from keyboard

            ComPort.Write(iTemp, FlagSendLF);
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
        /// PROCESS WINDOW KEYBOARD PRESS GLOBAL
        /// </summary>
        protected override bool ProcessCmdKey(ref Message message, Keys keys)
        {
            UpdateKeyboarStatus();
            return false;
        }

        /// <summary>
        /// PROCESS CHARACTER SELECT
        /// </summary>
        private void SelectCharacterSet_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem element in lvCharSet.Items)
            {
                if (element.Selected == true)
                {
                    if (FlagSendTo == true)
                    {
                        if(ComPort.Write(Int32.Parse(element.SubItems[1].Text), FlagSendLF))
                        {
                            string sTemp = null;
                            sTemp = ComPort.IntToAssciiStr(Int32.Parse(element.SubItems[1].Text), FlagShowLF, FlagShowSpace);
                            UpdateDataRecieved(sTemp, false);
                        }
                        break;
                    }
                    else
                    {
                        string temp = ComPort.IntToAssciiStr(Int32.Parse(element.SubItems[1].Text), false, false);
                        tbDataSend.AppendText(temp);
                        break;
                    }
                }
            }
            
        }

        /// <summary>
        /// PROCESS CHANGE USER # CMD SETTING
        /// </summary>
        private void MoveToPreviousUser(object sender, EventArgs e)
        {
            UserCmd.ChangeCurrentUser(false);
            UpdateUserButtonCmd();
        }
        private void MoveToNextUser(object sender, EventArgs e)
        {
            UserCmd.ChangeCurrentUser(true);
            UpdateUserButtonCmd();
        }

        /// <summary>
        /// DETECT COMPORT CHANGE STATUS
        /// </summary>
        private void SPort_PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            if(ComPort.CheckSport() == false)
            {
                TimerCounterCheckComport = 6;
            }
            //UpdateCTSaDTRStatus();

            if (HandshakeMode != HANDSHAKE_TYPE.NONE)
            {
                lbCTSILow.Image = TestAME.Properties.Resources.D_green;
                lbDSRILow.Image = TestAME.Properties.Resources.D_green;
                lbCTSIHigh.Image = TestAME.Properties.Resources.D_brown;
                lbDSRIHigh.Image = TestAME.Properties.Resources.D_brown;

                if (ComPort.CTSGetting())
                    lbCTSIHigh.Image = TestAME.Properties.Resources.Red;
                else
                    lbCTSILow.Image = TestAME.Properties.Resources.Green;

                if (ComPort.DSRGetting())
                    lbDSRIHigh.Image = TestAME.Properties.Resources.Red;
                else
                    lbDSRILow.Image = TestAME.Properties.Resources.Green;
            }
        }

        /// <summary>
        /// SAVE LOG FILE
        /// </summary>
        private void SaveLog_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "text file|*.txt";
            fileDialog.Title = "Save log file !";
            fileDialog.FileName = "Monster_LogFile.txt";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (fileDialog.FileName != "")
                {
                    System.IO.File.WriteAllText(@fileDialog.FileName, tbDataRecieve.Text);
                }
            }
        }
        private void TimeTracking_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("hh : mm : ss tt");

            if (TimerCounterCheckComport > 0)
            {
                if (TimerCounterCheckComport == 1)
                {
                    TimerCounterCheckComport = 0;
                    if (ComPort.CheckSport() == false)
                    {
                        ComPort.CloseSPort();
                        FlagConnectStatus = false;
                        UpdateStatusWindow();
                    }
                }
                else
                    TimerCounterCheckComport--;
            }
        }

        /// <summary>
        /// HANDSHAKE PROTOCOL PROCESS
        /// </summary>
        private void tsmiRequestToSend_Click(object sender, EventArgs e)
        {
            HandshakeMode = HANDSHAKE_TYPE.REQUEST_TO_SEND;
            ComPort.HandshakeSetting(HandshakeMode);
            UpdateCTSaDTRStatus();
        }
        private void tsmiXonXoff_Click(object sender, EventArgs e)
        {
            HandshakeMode = HANDSHAKE_TYPE.XON_XOFF;
            ComPort.HandshakeSetting(HandshakeMode);
            UpdateCTSaDTRStatus();
        }
        private void tsmiBoth_Click(object sender, EventArgs e)
        {
            HandshakeMode = HANDSHAKE_TYPE.BOTH;
            ComPort.HandshakeSetting(HandshakeMode);
            UpdateCTSaDTRStatus();
        }
        private void tsmiNone_Click(object sender, EventArgs e)
        {
            HandshakeMode = HANDSHAKE_TYPE.NONE;
            ComPort.HandshakeSetting(HandshakeMode);
            UpdateCTSaDTRStatus();
        }

        /// <summary>
        /// OTHERS
        /// </summary>
        private void tsmiTimeStamping_Click(object sender, EventArgs e)
        {
            // update time stamping flag
            FlagTimeStamping = false;
            if (tsmiTimeStamping.Checked == true)
            {
                FlagTimeStamping = true;
            }
        }
        private void tsmiIndexStamping_Click(object sender, EventArgs e)
        {
            // update time stamping flag
            FlagIndexStamping = false;
            if (tsmiIndexStamping.Checked == true)
            {
                FlagIndexStamping = true;
            }
        }
        private void tsmiSimpleViewOption_Click(object sender, EventArgs e)
        {
            if (FlagFlipView == false)
            {
                FlagFlipView = true;
                tsmiSimpleView.Checked = true;
                tsmiFullView.Checked = false;

                pnTime.Visible = false;
                gbConnectStatus.Visible = false;
                gbCharSetStatus.Visible = false;
                gbSetUp.Visible = false;
                gbCapStatus.Visible = false;

                btTempConnect.Visible = true;
                lbTempStatus.Visible = true;
                if (SPort.PortName != "") btTempConnect.Text = SPort.PortName;

                this.MinimumSize = new Size(this.MinimumSize.Width - pnTime.Width, this.MinimumSize.Height);
                this.Width = this.Width - pnTime.Width;

                gbCommunicate.Width += pnTime.Width;
                gbLocalCmd.Width += pnTime.Width;
                gbUserCmd.Width += pnTime.Width;
                this.Refresh();
            }
        }
        private void tsmiFullViewOption_Click(object sender, EventArgs e)
        {
            if (FlagFlipView)
            {
                FlagFlipView = false;
                tsmiSimpleView.Checked = false;
                tsmiFullView.Checked = true;

                pnTime.Visible = true;
                gbConnectStatus.Visible = true;
                gbCharSetStatus.Visible = true;
                gbSetUp.Visible = true;
                gbCapStatus.Visible = true;

                btTempConnect.Visible = false;
                lbTempStatus.Visible = false;

                this.MinimumSize = new Size(this.MinimumSize.Width + pnTime.Width, this.MinimumSize.Height);
                this.Width = this.Width + pnTime.Width;

                gbCommunicate.Width -= pnTime.Width;
                gbLocalCmd.Width -= pnTime.Width;
                gbUserCmd.Width -= pnTime.Width;
                this.Refresh();
            }
        }
        private void tsmiClearAllComPort_Click(object sender, EventArgs e)
        {
            RegistryKey regKey = Registry.LocalMachine;
            regKey = regKey.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\COM Name Arbiter");
            try
            {
                foreach (string element in regKey.GetValueNames())
                {
                    try
                    {
                        if (element == "ComDB")
                        {
                            RegistrySecurity rs = new RegistrySecurity(); // it is right string for this code
                            string currentUserStr = Environment.UserDomainName + "\\" + Environment.UserName;
                            rs.AddAccessRule(new RegistryAccessRule(currentUserStr, RegistryRights.WriteKey | RegistryRights.FullControl, AccessControlType.Allow));
                            regKey.SetAccessControl(rs);
                            regKey.SetValue("ComDB", 0, RegistryValueKind.DWord);
                            DialogResult result = MessageBox.Show("Need to restart system to update setting!", "It's up to you!", MessageBoxButtons.YesNo);

                            if (result == System.Windows.Forms.DialogResult.Yes)
                            {
                                Process.Start("shutdown", "-s -f -t 0");
                                this.Close();
                            }
                        }
                    }
                    catch { }
                }
            }
            catch { }
        }
        private void tsmiAutoReconnect_Click(object sender, EventArgs e)
        {
            if (tsmiAutoReconnect.Checked)
            {
                Properties.Settings.Default.AutoReconnect = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.AutoReconnect = false;
                Properties.Settings.Default.Save();
            }
        }
        

        /// <summary>
        /// ABOUT US
        /// </summary>
        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ComTest Version I.01", "**_MonsterClaww_**", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

    }
}

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
// All Atributes.
//==============================================================================
        P_SerialComPort ComPort = null;
        P_UserCommandManagement UserCmd = null;
        List<Button> CommandBTList = null;
        List<Button> ConnectStatusBTList = null;
        List<Button> ControlUIBTList = null;
        static int IndextCounter = 0;

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

        bool FlagCTSOutput = false;
        bool FlagDTROutput = false;

        public delegate void AddDataDelegate(string datain);
        public AddDataDelegate myDelegate;

        SW_SerialComSetUp SubFormSPort = null;
        SW_SetupUserCommand SubFormCmd = null;
        SW_AME_Test SubFormAMETest = null;

//==============================================================================
// Window Actions.
//==============================================================================
        public MW_AmeTest()
        {
            InitializeComponent();
        }

        private void AME_APP_TEST_Load(object sender, EventArgs e)
        {
            ReInitializeAllComponents();
            this.myDelegate = new AddDataDelegate(AddDataMethod);
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
            ComPort = new P_SerialComPort(SPort);
            UserCmd = new P_UserCommandManagement();
            SPort.DataReceived += new SerialDataReceivedEventHandler(SPort_DataReceived);
            ConnectStatusBTList = new List<Button>() { btConnectSP, btDisplayRCData, btShowSpace, btShowLF};
            ControlUIBTList = new List<Button>() { btWrapTextCo, btClearCo, btNewLineCo, btSendLFLo, btClearLo, btCharToCo, btCharToLo };
            CommandBTList = new List<Button>() { btCmd0,btCmd1,btCmd2,btCmd3,btCmd4,btCmd5,btCmd6,btCmd7};
            UpdateStatusWindow();
            UpdateCharSetTable();
            UpdateUserButtonCmd();
            UpdateRightContextManu();
            UpdateKeyboarStatus();
        }

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
        }

        public bool UpdateDataRecieved(string data, bool flagFromSP)
        {
            bool ret = true;

            if (FlagDisplayDataRecieve && (data != null))
            {
                tbDataRecieve.Focus();
                tbDataRecieve.SelectionStart = tbDataRecieve.Text.Length;

                string temp = ComPort.ProcessPureString(data, FlagShowLF, FlagShowSpace);

                if (temp != null)
                {
                    string temp1 = UpdateStamping(temp, !flagFromSP);
                    if (temp1 != null)
                        tbDataRecieve.AppendText(temp1);

                    tbDataRecieve.SelectionStart = tbDataRecieve.TextLength;
                    tbDataRecieve.SelectionLength = 0;

                    if (flagFromSP)
                        tbDataRecieve.SelectionColor = Color.Yellow;
                    tbDataRecieve.AppendText(temp);
                    tbDataRecieve.SelectionColor = tbDataRecieve.ForeColor;
                }
            }

            return ret;
        }

        public bool UpdateDataTransmited(string dataIn)
        {
            bool bRet = false;
            if (dataIn == null) return bRet;

            string temp1 = UpdateStamping(null, false);
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
            tbDataRecieve.Text += Clipboard.GetText();
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

        public string UpdateStamping(string dataIn, bool flagSwitch)
        {
            string sRet = null;

            if (FlagIndexStamping)
            {
                string temp2 = UpdateSuffix(2);
                sRet = temp2;
                IndextCounter++;
            }

            if (FlagTimeStamping)
            {
                string temp1 = UpdateSuffix(1);
                sRet += temp1;
            }

            if (flagSwitch == true)
            {
                if (tsmiIndexStamping.Checked)
                {
                    FlagIndexStamping = false;
                    if (dataIn == "\r" || dataIn == "\n")
                    {
                        FlagIndexStamping = true;
                    }
                }

                if (tsmiTimeStamping.Checked)
                {
                    FlagTimeStamping = false;
                    if (dataIn == "\r" || dataIn == "\n")
                    {
                        FlagTimeStamping = true;
                    }
                }
            }

            return sRet;
        }

        public bool UpdateCTSaDTRStatus()
        {
            bool bRet = true;

            lbCTSILow.Image = TestAME.Properties.Resources.D_green;
            lbDSRILow.Image = TestAME.Properties.Resources.D_green;
            lbCTSOLow.Image = TestAME.Properties.Resources.D_green;
            lbDTROLow.Image = TestAME.Properties.Resources.D_green;

            lbCTSIHigh.Image = TestAME.Properties.Resources.D_brown;
            lbDSRIHigh.Image = TestAME.Properties.Resources.D_brown;
            lbCTSOHigh.Image = TestAME.Properties.Resources.D_brown;
            lbDTROHigh.Image = TestAME.Properties.Resources.D_brown;

            if (FlagConnectStatus == false)
            {
                lbCTSStatus.Enabled = false;
                lbDSRStatus.Enabled = false;
                btCTS.Enabled = false;
                btDTR.Enabled = false;
            }
            else
            {
                lbCTSStatus.Enabled = true;
                lbDSRStatus.Enabled = true;
                btCTS.Enabled = true;
                btDTR.Enabled = true;
            }
            
            return bRet;
        }

        public bool SendDataMethode(string dataIn)
        {
            bool bRet = false;
            if (ComPort.SendData(dataIn, FlagSendLF))
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
        private void AME_Test_Load(object sender, EventArgs e)
        {
            if (SubFormAMETest == null)
            {
                SubFormAMETest = new SW_AME_Test(SendDataMethode);
                SubFormAMETest.FormClosed += new FormClosedEventHandler(SubFormAMETestClosed);
                SubFormAMETest.Show();
                SubFormAMETest.UpdateSystemInfo(FlagConnectStatus);
            }
        }
        void SubFormAMETestClosed(object sender, FormClosedEventArgs e)
        {
            SubFormAMETest = null;
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

                    if (SubFormAMETest != null)
                        SubFormAMETest.UpdateSystemInfo(FlagConnectStatus);
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

            ComPort.SendData(cmdListCurrent[IndexSender], UserCmd.GetFlagInsertLF());
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
        void SPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string sData = null;

            // read all buff
            try 
            {
                sData = sp.ReadExisting();
                this.Invoke(this.myDelegate, new Object[] { sData });
            }
            catch { }
            
        }

        /// <summary>
        /// PROCESS SEND DATA VIA SERIAL PORT
        /// </summary>
        private void btSend_Click(object sender, EventArgs e)
        {
            if (tbDataSend.Text != null)
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

            ComPort.SendData(iTemp, FlagSendLF);
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
                        if(ComPort.SendData(Int32.Parse(element.SubItems[1].Text), FlagSendLF))
                        {
                            UpdateDataRecieved(element.SubItems[1].Text, false);
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
                ComPort.CloseSPort();
                FlagConnectStatus = false;
                UpdateStatusWindow();
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
        }

        private void tsmiTimeStamping_Click(object sender, EventArgs e)
        {
            // update time stamping flag
            FlagTimeStamping = false;
            if (tsmiTimeStamping.Checked == true)
            {
                FlagTimeStamping = true;
            }
        }

        private void indexStamping_Click(object sender, EventArgs e)
        {
            // update time stamping flag
            FlagIndexStamping = false;
            if (tsmiIndexStamping.Checked == true)
            {
                FlagIndexStamping = true;
            }
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nothing to checking... version xx.x !");
        }


    }
}

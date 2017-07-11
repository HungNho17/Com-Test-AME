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
    public partial class SW_AME_Test : Form
    {
        enum TEST_MODE_TYPE
        {
            UNDEF_MODE = 0,
            MANUAL_MODE,
            AUTO_MODE
        };
        //==============================================================================
        // All Atributes.
        //==============================================================================
        P_AME_ExcelFileProcess comExcel = null;
        string pathFileSelected = null;
        List<Button> listBtManual = null;
        List<Button> listBtAuto = null;

        int iCurrentCmdNumber = 0;
        COMMAND_TYPE CurrentCmd;

        int iNumberOfCmd = 0;
        bool FlagFileLoaded = false;
        bool FlagFlipTestMode = false;

        TEST_MODE_TYPE TestMode = TEST_MODE_TYPE.UNDEF_MODE;
        public delegate bool SendDataDelegate(string datain);
        public SendDataDelegate myDelegate;

        // Auto test attributes
        int DefaulIntervalWait = 10; // 10 times of 100ms = 1 seconds
        int iCounterValue = 0;

        //==============================================================================
        // Window Actions.
        //==============================================================================
        public SW_AME_Test()
        {
            InitializeComponent();
            comExcel = new P_AME_ExcelFileProcess();
            listBtManual = new List<Button> { btPrevious, btNext, btSend };
            listBtAuto = new List<Button> { btStart, btPause, btStop };
        }

        public SW_AME_Test(Func<string, bool> function)
        {
            InitializeComponent();
            comExcel = new P_AME_ExcelFileProcess();
            listBtManual = new List<Button> { btPrevious, btNext, btSend };
            listBtAuto = new List<Button> { btStart, btPause, btStop };

            this.myDelegate = new SendDataDelegate(function);
        }

        private void SW_AME_Test_Load(object sender, EventArgs e)
        {
            UpdateCommonInfo();
            btClose.Select();
        }

        private void SW_AME_Test_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (comExcel != null)
            {
                comExcel = null;
            }
        }

        //==============================================================================
        // Internal Actions.
        //==============================================================================

        public bool UpdateSystemInfo(bool SystemStatus)
        {
            bool bRet = false;

            if (SystemStatus == true)
            {
                lbSystemStatus.Text = "Com Port Connected!";
                gbCommonInfo.Enabled = true;
                gbCurrentCmdStatus.Enabled = true;
                rbManual.Checked = true;
            }
            else
            {
                lbSystemStatus.Text = "Com Port Disconnected!";
                gbCommonInfo.Enabled = false;
                gbCurrentCmdStatus.Enabled = false;
                gbManualMode.Enabled = false;
                gbAutoMode.Enabled = false;
                Timer.Enabled = false;
            }

            return bRet;
        }

        public bool UpdateCommonInfo()
        {
            bool bRet = true;
            if (comExcel.IsFileExist() == true)
            {
                lbFileStatus.Text = "Process Done!";
                lbTotalCmd.Text = iNumberOfCmd.ToString();
            }
            else
            {
                lbFileStatus.Text = "No file processed!";
                lbTotalCmd.Text = "...";
            }
            return bRet;
        }

        public bool UpdateCommandInfo()
        {
            bool bRet = false;
            if (comExcel.IsFileExist() == true)
            {
                for (int idx = 0; idx < iNumberOfCmd; idx++)
                {
                    CurrentCmd = comExcel.GetCommand(idx);
                    cbCurrentNumber.Items.Add(CurrentCmd.number.ToString());
                    cbCurrentDesc.Items.Add(CurrentCmd.desc);
                    cbCurrentCmd.Items.Add(CurrentCmd.cmd);
                }
            }
            return bRet;
        }

        public bool UpdateCurrentCmd(int CmdNumber)
        {
            bool bRet = false;
            if (comExcel.IsFileExist() == true)
            {
                if (iNumberOfCmd > 0 && CmdNumber < iNumberOfCmd)
                {
                    CurrentCmd = comExcel.GetCommand(CmdNumber);

                    cbCurrentNumber.SelectedIndex = CmdNumber;
                    cbCurrentDesc.SelectedIndex = CmdNumber;
                    cbCurrentCmd.SelectedIndex = CmdNumber;
                }

            }
            return bRet;
        }

        public bool UpdateStatusTestMode(bool flip)
        {
            bool bRet = true;

            if (TestMode == TEST_MODE_TYPE.MANUAL_MODE)
            {
                lbAutoStatus.Image = TestAME.Properties.Resources.D_green;
                if (flip)
                    lbManualStatus.Image = TestAME.Properties.Resources.Green;
                else
                    lbManualStatus.Image = TestAME.Properties.Resources.D_green;
            }
            else if (TestMode == TEST_MODE_TYPE.AUTO_MODE)
            {
                lbManualStatus.Image = TestAME.Properties.Resources.D_green;
                if (flip)
                    lbAutoStatus.Image = TestAME.Properties.Resources.Green;
                else
                    lbAutoStatus.Image = TestAME.Properties.Resources.D_green;
            }

            return bRet;
        }

        public bool UpdateLocation(int x, int y)
        {
            bool bRet = true;
            this.Location = new Point(x, y);
            return bRet;
        }

        public bool UpdateFeedBackSending(string sRespond)
        {
            bool bRet = false;
            if (TestMode == TEST_MODE_TYPE.AUTO_MODE)
            {
                if (DoVerifyMethode(sRespond))
                {
                    ProcessAutoSendCmd();
                }
            }
            return bRet;
        }
        public bool DoVerifyAction()
        {
            bool bRet = true;

            if (rbPause.Checked)
            {
                iCurrentCmdNumber = 0;
                bRet = false;
            }
            else if (rbStop.Checked)
            {
                iCurrentCmdNumber = 0;
                UpdateCurrentCmd(iCurrentCmdNumber);
                bRet = false;
            }
            return bRet;
        }
        public bool DoVerifyMethode(string sData = null)
        {
            bool bRet = true;
            if (rbYesNo.Checked)
            {
                if (sData == null || sData == " ")
                {
                    bRet = DoVerifyAction();
                }
            }
            else if (rbCompareResp.Checked)
            {
                if (CurrentCmd.resultExpect != sData)
                {
                    bRet = DoVerifyAction();
                }
            }
            return bRet;
        }
        public bool ProcessAutoSendCmd(bool bStart = false)
        {
            bool bRet = false;

            if (iCurrentCmdNumber < iNumberOfCmd)
            {
                if (bStart == false)
                    iCurrentCmdNumber += 1;
            }
            else if (cbLoopTest.Checked)
            {
                iCurrentCmdNumber = 0;
            }
            else
            {
                iCurrentCmdNumber = 0;
                UpdateCurrentCmd(iCurrentCmdNumber);
                btStart.Enabled = true;
                gbMethode.Enabled = true;
                gbAction.Enabled = true;
                return bRet;
            }

            UpdateCurrentCmd(iCurrentCmdNumber);
            this.Invoke(this.myDelegate, new Object[] { (CurrentCmd.cmd + "\r") });

            int tempInterval = 0;
            try
            {
                tempInterval = int.Parse(CurrentCmd.timeWait);
            }
            catch { }
            if (tempInterval == 0) tempInterval = DefaulIntervalWait;
            iCounterValue = tempInterval;

            return bRet;
        }


//==============================================================================
// Event Process
//==============================================================================
        private void btFileBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "*.xls|*.xlsx";
            fileDialog.Title = "Select File Command !";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                tbFilePath.Text = fileDialog.FileName;
                pathFileSelected = tbFilePath.Text;
            }
        }

        private void btLoadProcess_Click(object sender, EventArgs e)
        {
            if (pathFileSelected != null)
            {
                if (comExcel.ExcelOpenFile(pathFileSelected))
                {
                    iNumberOfCmd = comExcel.FileCommandParser();
                    if (iNumberOfCmd > 0)
                    {
                        UpdateCommonInfo();
                        UpdateCommandInfo();
                        UpdateCurrentCmd(iCurrentCmdNumber);
                        FlagFileLoaded = true;
                        TestMode_CheckedChanged(sender,e);
                    }
                }
                else
                    MessageBox.Show("File Invalid!");
            }
        }

        private void TestMode_CheckedChanged(object sender, EventArgs e)
        {
            if (FlagFileLoaded == false) return;
            if (rbManual.Checked == true)
            {
                TestMode = TEST_MODE_TYPE.MANUAL_MODE;
                gbManualMode.Enabled = true;
                gbAutoMode.Enabled = false;
                Timer_WaitRespond.Enabled = false;

            }
            else if (rbAuto.Checked == true)
            {
                TestMode = TEST_MODE_TYPE.AUTO_MODE;
                gbManualMode.Enabled = false;
                gbAutoMode.Enabled = true;
                Timer_WaitRespond.Enabled = true;
                rbDontVerify.Checked = true;
                rbDoNothing.Checked = true;
                iCounterValue = 0;
            }
            Timer.Enabled = true;
        }

        private void btControlManual_Handle(object sender, EventArgs e)
        {
            int IndexBt = listBtManual.IndexOf(sender as Button);
            switch (IndexBt)
            {
                case 0: // previous
                    if (iCurrentCmdNumber > 0) iCurrentCmdNumber -= 1;
                    UpdateCurrentCmd(iCurrentCmdNumber);
                    break;
                case 1: // next
                    if (iCurrentCmdNumber < iNumberOfCmd) iCurrentCmdNumber += 1;
                    UpdateCurrentCmd(iCurrentCmdNumber);
                    break;
                case 2: // send
                    this.Invoke(this.myDelegate, new Object[] { (CurrentCmd.cmd + "\r") });
                    if (iCurrentCmdNumber < iNumberOfCmd) iCurrentCmdNumber += 1;
                    UpdateCurrentCmd(iCurrentCmdNumber);
                    break;
                default:
                    break;

            }
        }

        private void btControlAuto_Handle(object sender, EventArgs e)
        {
            int IndexBt = listBtAuto.IndexOf(sender as Button);
            switch (IndexBt)
            {
                case 0: // start
                    ProcessAutoSendCmd(true);
                    btStart.Enabled = false;
                    gbMethode.Enabled = false;
                    gbAction.Enabled = false;
                    break;
                case 1: // pause
                    iCounterValue = 0;
                    btStart.Enabled = true;

                    break;
                case 2: // stop
                    iCounterValue = 0;
                    iCurrentCmdNumber = 0;
                    UpdateCurrentCmd(iCurrentCmdNumber);
                    btStart.Enabled = true;
                    gbMethode.Enabled = true;
                    gbAction.Enabled = true;
                    break;
                default:
                    break;

            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cbCurrentCmd_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iTempIxd = (sender as ComboBox).SelectedIndex;
            if (iTempIxd < iNumberOfCmd) iCurrentCmdNumber = iTempIxd;
            UpdateCurrentCmd(iTempIxd);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            FlagFlipTestMode ^= true;
            UpdateStatusTestMode(FlagFlipTestMode);
        }
        private void Timer_WaitRespond_Tick(object sender, EventArgs e)
        {
            if (iCounterValue == 1)
            {
                iCounterValue = 0;
                if (DoVerifyMethode())
                {
                    ProcessAutoSendCmd();
                }
            }
            else if (iCounterValue > 0) iCounterValue--;
            
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            iCurrentCmdNumber = 0;
            UpdateCurrentCmd(iCurrentCmdNumber);
        }
    }
}

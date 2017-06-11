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

        int iNumberOfCurrentCmd = 0;
        COMMAND_TYPE CurrentCmd;

        int iNumberOfCmd = 0;
        bool FlagFlip = false;

        TEST_MODE_TYPE TestMode = TEST_MODE_TYPE.UNDEF_MODE;
        public delegate bool SendDataDelegate(string datain);
        public SendDataDelegate myDelegate;

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
                lbSystemStatus.Text = "Device Connected!";
                gbCommonInfo.Enabled = true;
                gbCurrentCmdStatus.Enabled = true;
            }
            else
            {
                lbSystemStatus.Text = "Device Disconnected!";
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

        public bool UpdateAllCommand()
        {
            bool bRet = false;
            if (comExcel.IsFileExist() == true)
            {
                for (int idx = 0; idx < iNumberOfCmd; idx++ )
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
                if(comExcel.ExcelOpenFile(pathFileSelected))
                {
                    iNumberOfCmd = comExcel.FileCommandParser();
                    if (iNumberOfCmd > 0)
                    {
                        UpdateCommonInfo();
                        UpdateAllCommand();
                        UpdateCurrentCmd(iNumberOfCurrentCmd);
                    }
                }
            }
        }

        private void TestMode_CheckedChanged(object sender, EventArgs e)
        {
            if (rbManual.Checked == true)
            {
                TestMode = TEST_MODE_TYPE.MANUAL_MODE;
                gbManualMode.Enabled = true;
                gbAutoMode.Enabled = false;
            }
            else if (rbAuto.Checked == true)
            {
                TestMode = TEST_MODE_TYPE.AUTO_MODE;
                gbManualMode.Enabled = false;
                gbAutoMode.Enabled = true;
            }
            Timer.Enabled = true;
        }

        private void btControlManual_Handle(object sender, EventArgs e)
        {
            int IndexBt = listBtManual.IndexOf(sender as Button);
            switch (IndexBt)
            {
                case 0: // previous
                    if (iNumberOfCurrentCmd > 0) iNumberOfCurrentCmd -= 1;
                    UpdateCurrentCmd(iNumberOfCurrentCmd);
                    break;
                case 1: // next
                    if (iNumberOfCurrentCmd < iNumberOfCmd) iNumberOfCurrentCmd += 1;
                    UpdateCurrentCmd(iNumberOfCurrentCmd);
                    break;
                case 2: // send
                    this.Invoke(this.myDelegate, new Object[] { (CurrentCmd.cmd + "\r") });
                    if (iNumberOfCurrentCmd < iNumberOfCmd) iNumberOfCurrentCmd += 1;
                    UpdateCurrentCmd(iNumberOfCurrentCmd);
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
                    break;
                case 1: // pause
                    break;
                case 2: // stop
                    break;
                default:
                    break;

            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            FlagFlip ^= true;
            UpdateStatusTestMode(FlagFlip);
        }

        private void cbCurrentCmd_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iTempIxd = (sender as ComboBox).SelectedIndex;
            UpdateCurrentCmd(iTempIxd);
        }

    }
}

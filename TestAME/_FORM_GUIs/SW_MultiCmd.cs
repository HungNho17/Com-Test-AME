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
    public partial class SW_MultiCmd : Form
    {
        private enum MODE_CMD
        {
            UNKNOW = 0,
            MANUAL,
            AUTO,
        }

        ISerialComport  m_ComPort           = null;

        List<Button>    m_CmdBtList         = null;

        I_AmeCommands   m_CmdHandler        = null;
        int             m_iNumberOfCmd      = 0;
        int             m_iCurrentIdxCmd    = 0;
        bool            m_bFlagInWait       = false;
        bool            m_bFlagCheckRes     = false;

        Timer           m_AutoTimer         = null;
        MODE_CMD        m_Mode              = MODE_CMD.MANUAL;

        string          sPathFileSelected   = null;
        bool            FlagFileLoaded      = false;

        public delegate void AddDataDelegate(string datain);
        public AddDataDelegate myDelegate;

        public SW_MultiCmd(ISerialComport ComPort)
        {
            m_ComPort = ComPort;
            m_CmdHandler = new P_AmeCommands();
            m_CmdBtList = new List<Button>();

            InitializeComponent();

            this.myDelegate = new AddDataDelegate(AddDataMethod);
            ComPort.RegisterReceiveRealTime(new DataReceiveUpdate(Read));
        }
        
        private void SW_MultiCmd_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (m_CmdHandler != null)
                m_CmdHandler.Closed();
        }

        private bool DataViewInit()
        {
            bool bRet = false;

            if (FlagFileLoaded)
            {
                //Setting type for columns: first to last
                dtgvMain.Columns.Add(new DataGridViewButtonColumn());

                dtgvMain.ColumnHeadersVisible = true;
                dtgvMain.ColumnCount = 7;
                dtgvMain.Columns[0].Name = "Send";
                dtgvMain.Columns[1].Name = "Name";
                dtgvMain.Columns[2].Name = "Command";
                dtgvMain.Columns[3].Name = "Syntax";
                dtgvMain.Columns[4].Name = "Result Expect";
                dtgvMain.Columns[5].Name = "Result Observe";
                dtgvMain.Columns[6].Name = "User Notes";

                dtgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dtgvMain.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dtgvMain.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                dtgvMain.AllowUserToResizeRows = false;
                dtgvMain.MultiSelect = false;

                bRet = true;
            }

            return bRet;
        }

        private bool ToolStripInit()
        {
            bool bRet = false;

            if (FlagFileLoaded)
            {
                tsmiManual.Enabled = true;
                tsmiAutoNoRes.Enabled = true;
                tsmiAutoRes.Enabled = true;

                if (m_Mode == MODE_CMD.MANUAL)
                {
                    tsmiManual.Checked = true;
                    tsmiAutoNoRes.Checked = false;
                    tsmiAutoRes.Checked = false;

                    tsmiStart.Enabled = false;
                    tsmiStop.Enabled = false;
                }
                else if (m_Mode == MODE_CMD.AUTO)
                {
                    tsmiAutoNoRes.Checked = true;
                    tsmiAutoRes.Checked = false;
                    tsmiManual.Checked = false;

                    tsmiStart.Enabled = true;
                    tsmiStop.Enabled = true;
                }

                bRet = true;
            }

            return bRet;
        }

        private bool AutoTimerSetUp()
        {
            bool bRet = false;
            if (m_Mode == MODE_CMD.AUTO)
            {
                m_AutoTimer = new Timer();
                m_AutoTimer.Tick += new EventHandler(timer_Expired);
                
                tsmiStart.Enabled = true;
                tsmiStop.Enabled = true;
            }
            else
            {
                m_AutoTimer.Dispose();
                m_AutoTimer = null;
                
                tsmiStart.Enabled = false;
                tsmiStop.Enabled = false;
            }
            return bRet;
        }

        private bool DataViewAddRow(string[] sContent)
        {
            bool bRet = false;
            if (sContent.Length >= 5)
            {
                dtgvMain.Rows.Add(sContent);
            }
            return bRet;
        }

        private bool UpdateCmdFromFile()
        {
            bool bRet = false;

            if (FlagFileLoaded == true)
            {
                for (int i = 0; i < m_iNumberOfCmd; i++)
                {
                    string[] RowContent = new string[7];
                    COMMAND_TYPE TempCmd = m_CmdHandler.ReadCmd(i);
                    if (TempCmd != null)
                    {
                        RowContent[0] = "Cmd_" + i.ToString();
                        RowContent[1] = TempCmd.m_Name;
                        RowContent[2] = TempCmd.m_Cmd;
                        RowContent[3] = TempCmd.m_CmdSyntax;
                        RowContent[4] = TempCmd.m_ResultExpect;
                        RowContent[5] = TempCmd.m_Result;
                        RowContent[6] = TempCmd.m_UserNote;

                        DataViewAddRow(RowContent);
                    }
                }
            }

            return bRet;
        }

        public void AddDataMethod(string dataIn)
        {
            if (m_bFlagInWait == true)
            {
                dtgvMain.Rows[m_iCurrentIdxCmd].Cells[5].Value = dataIn;
                m_iCurrentIdxCmd++;
                m_bFlagInWait = false;
            }
        }

        public void Read(string sDataSport)
        {
            this.Invoke(this.myDelegate, new object[] { sDataSport});
        }

        private bool SendCmd(int iCmdIdx)
        {
            bool bRet = false;

            if ((iCmdIdx < m_iNumberOfCmd) && (m_iNumberOfCmd > 0))
            {
                dtgvMain.Rows[iCmdIdx].Selected = true;
                try
                {
                    m_ComPort.Write(dtgvMain.Rows[iCmdIdx].Cells[2].Value.ToString() +"\r", false);
                    m_iCurrentIdxCmd = iCmdIdx;
                    m_bFlagInWait = true;
                    bRet = true;
                }
                catch { }
            }

            return bRet;
        }
        
        // Event handler !

        private void tsmiLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Command file |*.xls;*.xlsx;*.csv";
            fileDialog.Title = "Select File Command !";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                sPathFileSelected = fileDialog.FileName;
                lbPathFile.Text = fileDialog.FileName;
            }

            if (sPathFileSelected != null)
            {
                if (m_CmdHandler.LoadAmeCmdFile(sPathFileSelected))
                {
                    m_iNumberOfCmd = m_CmdHandler.GetTotalNumberCmd();
                    if (m_iNumberOfCmd > 0)
                    {
                        FlagFileLoaded = true;

                        DataViewInit();
                        ToolStripInit();
                        UpdateCmdFromFile();
                    }
                }
                else
                    MessageBox.Show("File Invalid!");
            }
        }

        private void dtgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                SendCmd(e.RowIndex);
            }
        }

        private void tsmiReset_Click(object sender, EventArgs e)
        {
            if (dtgvMain.Rows.Count > 0)
            {
                for (int i = 0; i < dtgvMain.Rows.Count; i++)
                {
                    dtgvMain.Rows[i].Cells[5].Value = null;
                }

                dtgvMain.Rows[0].Selected = true;
                m_iCurrentIdxCmd = 0;
                m_bFlagInWait = false;
            }
        }

        private void tsmiMenual_Click(object sender, EventArgs e)
        {
            tsmiManual.Checked = true;
            tsmiAutoNoRes.Checked = false;
            tsmiAutoRes.Checked = false;
            
            m_Mode = MODE_CMD.MANUAL;
            AutoTimerSetUp();
        }

        private void tsmiAuto_Click(object sender, EventArgs e)
        {
            if ((sender as ToolStripMenuItem) == tsmiAutoNoRes)
            {
                tsmiAutoNoRes.Checked = true;
                tsmiAutoRes.Checked = false; 
                tsmiManual.Checked = false;

                m_Mode = MODE_CMD.AUTO;
                m_bFlagCheckRes = false;
                AutoTimerSetUp();
            }
            else if ((sender as ToolStripMenuItem) == tsmiAutoRes)
            {
                tsmiAutoRes.Checked = true;
                tsmiAutoNoRes.Checked = false;
                tsmiManual.Checked = false;
                
                m_Mode = MODE_CMD.AUTO;
                m_bFlagCheckRes = true;
                AutoTimerSetUp();
            }
        }

        private void tsmiAutoControl_Click(object sender, EventArgs e)
        {
            if ((sender as ToolStripMenuItem) == tsmiStart)
            {
                m_AutoTimer.Enabled = true;
            }
            else if ((sender as ToolStripMenuItem) == tsmiStop)
            {
                m_AutoTimer.Enabled = false;
            }
        }

        private void timer_Expired(object sender, EventArgs e)
        {
            if (m_bFlagCheckRes == false)
            {
                if (m_bFlagInWait == true)
                {
                    m_iCurrentIdxCmd++;
                    m_bFlagInWait = false; // keep moving !
                }
            }

            if ((m_iCurrentIdxCmd < m_iNumberOfCmd) && (m_bFlagInWait == false))
            {
                if (SendCmd(m_iCurrentIdxCmd))
                {
                    int iSecWait = 1;

                    COMMAND_TYPE TempCmd = m_CmdHandler.ReadCmd(m_iCurrentIdxCmd);
                    try
                    {
                        iSecWait = int.Parse(TempCmd.m_WaitInSec);
                    }
                    catch { }

                    m_AutoTimer.Interval = (iSecWait * 1000);
                }
            }
            else
            {
                m_AutoTimer.Enabled = false;
                MessageBox.Show("No Respond!");
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiAction_DropDownOpened(object sender, EventArgs e)
        {
            if (m_bFlagInWait == true)
            {
                m_AutoTimer.Enabled = false;
            }
        }

        private void tsmiAction_DropDownClosed(object sender, EventArgs e)
        {
            // No action.
        }
    }
}

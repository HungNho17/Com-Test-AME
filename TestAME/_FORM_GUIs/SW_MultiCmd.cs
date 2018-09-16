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
        ISerialComport  m_ComPort           = null;

        List<Button>    m_CmdBtList         = null;

        I_AmeCommands   m_CmdHandler        = null;
        int             m_iNumberOfCmd      = 0;

        string          sPathFileSelected   = null;
        bool            FlagFileLoaded      = false;

        public SW_MultiCmd(ISerialComport ComPort)
        {
            m_ComPort = ComPort;
            m_CmdHandler = new P_AmeCommands();
            m_CmdBtList = new List<Button>();

            InitializeComponent();
            DataViewInit();
        }

        private void load_tsmi_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "*.xls|*.xlsx";
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
                        UpdateCmdFromFile();
                    }
                }
                else
                    MessageBox.Show("File Invalid!");
            }
        }

        private bool DataViewInit()
        {
            bool bRet = false;
            
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

            bRet = true;

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
                        RowContent[3] = "";
                        RowContent[4] = TempCmd.m_ResultExpect;
                        RowContent[5] = TempCmd.m_Result;
                        RowContent[6] = TempCmd.m_UserNote;

                        DataViewAddRow(RowContent);
                    }
                }
            }

            return bRet;
        }

        private void dtgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                dtgvMain.Rows[e.RowIndex].Selected = true;
                try
                {
                    m_ComPort.Write(dtgvMain.Rows[e.RowIndex].Cells[2].Value.ToString() +"\r", false);
                }
                catch { }
            }
        }
    }
}

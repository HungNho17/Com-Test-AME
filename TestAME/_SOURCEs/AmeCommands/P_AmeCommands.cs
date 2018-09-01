using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace TestAME
{
    class P_AmeCommands : I_AmeCommands
    {
        static string REPORT_FOLDER_PATH        = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"RESOURCEs\AmeCmdReports");
        static string REPORT_FORM_FILE_NAME     = "AmeCmdForm.xlsx";
        static string REPORT_FILE_NAME_FORMAT   = "AmeCmd_{0}.xlsx";

        static string[] FIELD_DEFINE_LIST = new string[]{   "stt",
                                                            "name",
                                                            "cmd",
                                                            "wait time (in sec)",
                                                            "result expect",
                                                            "result observe",
                                                            "user note" };

        // attributes
        private string              m_sReportFormFilePath = null;

        private I_ExcelHandler      m_FileHandler   = null;
        private List<COMMAND_TYPE>  m_ListCommands  = null;
        private int                 m_NumberOfCmd   = 0;
        
        // public api
        public P_AmeCommands()
        {
            m_FileHandler   = new P_ExcelHandler();
            m_ListCommands  = new List<COMMAND_TYPE>();

            m_sReportFormFilePath = REPORT_FOLDER_PATH + "\\" + REPORT_FORM_FILE_NAME;
        }

        ~ P_AmeCommands(){ }
        
        public bool LoadAmeCmdFile(string pathFile)
        {
            bool bRet = false;

            if (m_FileHandler != null)
            {
                if (m_FileHandler.LoadFile(pathFile) == true)
                {
                    if (m_FileHandler.CheckStructure(FIELD_DEFINE_LIST) == true)
                    {

                    }
                }
            }

            return bRet;
        }

        public bool GenerateAmeCmdForm()
        {
            bool bRet = false;

            return bRet;
        }
        
        public int GetTotalNumberCmd()
        {
            return m_NumberOfCmd;
        }
        
        public COMMAND_TYPE ReadCmd(int iCmdNumber)
        {
            COMMAND_TYPE cmdRet = null;

            if ((m_NumberOfCmd > 0) && (iCmdNumber > 0))
            {
                foreach (COMMAND_TYPE CmdElement in m_ListCommands)
                {
                    if (m_ListCommands.IndexOf(CmdElement) == (iCmdNumber - 1))
                    {
                        cmdRet = CmdElement.Clone();
                    }
                }
            }

            return cmdRet;
        }

        public COMMAND_TYPE ReadCmd(string sCmdName)
        {
            COMMAND_TYPE cmdRet = new COMMAND_TYPE();

            if (m_NumberOfCmd > 0)
            {
                foreach (COMMAND_TYPE CmdElement in m_ListCommands)
                {
                    if (CmdElement.m_Name == sCmdName)
                    {
                        cmdRet = CmdElement.Clone();
                    }
                }
            }

            return cmdRet;
        }

        public bool AddCmd(COMMAND_TYPE Cmd)
        {
            bool bRet = false;

            return bRet;
        }

        public bool InsertCmd(COMMAND_TYPE Cmd, int iPosition)
        {
            bool bRet = false;

            return bRet;
        }
        
        public bool ReplaceCmd(COMMAND_TYPE Cmd, int iPosition)
        {
            bool bRet = false;

            return bRet;
        }
        public bool RemoveCmd(int iNumber)
        {
            bool bRet = false;

            return bRet;
        }
    }
}

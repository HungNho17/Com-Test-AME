using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestAME
{
    public class COMMAND_TYPE
    {
        public static string CMD_NAME          = "name";
        public static string CMD_CMD           = "cmd";
        public static string CMD_SYNTAX        = "syntax";
        public static string CMD_WAIT_TIME     = "wait time (in sec)";
        public static string CMD_RESULT_EXPECT = "result expect";
        public static string CMD_RESULT_OBSERV = "result observe";
        public static string CMD_USER_NOTE     = "user note";

        public static string[] FIELD_DEFINE_LIST = new string[]{    CMD_NAME,
                                                                    CMD_CMD,
                                                                    CMD_SYNTAX,
                                                                    CMD_WAIT_TIME,
                                                                    CMD_RESULT_EXPECT,
                                                                    CMD_RESULT_OBSERV,
                                                                    CMD_USER_NOTE };
        
        public string   m_Name;
        public string   m_Cmd;
        public string   m_CmdSyntax;

        public string   m_WaitInSec;
        public string   m_ResultExpect;

        public string   m_Result;
        public string   m_UserNote;

        public COMMAND_TYPE Clone()
        {
            return new COMMAND_TYPE()
            {
                m_Name          = this.m_Name,
                m_Cmd           = this.m_Cmd,
                m_CmdSyntax     = this.m_CmdSyntax,
                m_WaitInSec     = this.m_WaitInSec,
                m_ResultExpect  = this.m_ResultExpect,
                m_Result        = this.m_Result,
                m_UserNote      = this.m_UserNote
            };
        }
    }

    interface I_AmeCommands
    {
        bool            LoadAmeCmdFile (string sFilePath);

        void            Closed();

        bool            GenerateAmeCmdForm ();

        int             GetTotalNumberCmd ();

        COMMAND_TYPE    ReadCmd (int iNumber);
        COMMAND_TYPE    ReadCmd (string CmdName);

        bool            AddCmd (COMMAND_TYPE Cmd);
        bool            InsertCmd (COMMAND_TYPE Cmd, int iPosition);
        bool            ReplaceCmd (COMMAND_TYPE Cmd, int iPosition);
        bool            RemoveCmd (int iNumber);
    }
}

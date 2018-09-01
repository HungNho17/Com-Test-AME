using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestAME
{
    public class COMMAND_TYPE
    {
        public string   m_Name;
        public string   m_Cmd;

        public string   m_WaitInSec;
        public string   m_ResultExpect;
        public string   m_Desc;

        public string   m_Result;
        public string   m_UserNote;

        public COMMAND_TYPE Clone()
        {
            return new COMMAND_TYPE()
            {
                m_Name          = this.m_Name,
                m_Cmd           = this.m_Cmd,
                m_WaitInSec     = this.m_WaitInSec,
                m_ResultExpect  = this.m_ResultExpect,
                m_Desc          = this.m_Desc,
                m_Result        = this.m_Result,
                m_UserNote      = this.m_UserNote
            };
        }
    }

    interface I_AmeCommands
    {
        bool            LoadAmeCmdFile (string sFilePath);
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

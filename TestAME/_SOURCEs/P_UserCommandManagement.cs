using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestAME
{
    class P_UserCommandManagement
    {
        string[] btNameList = new string[8];
        string[] cmdList = new string[8];

        public bool LoadUser1Setup()
        {
            btNameList[0] = Properties.Settings.Default.user1_btName1;
            btNameList[1] = Properties.Settings.Default.user1_btName2;
            btNameList[2] = Properties.Settings.Default.user1_btName3;
            btNameList[3] = Properties.Settings.Default.user1_btName4;
            btNameList[4] = Properties.Settings.Default.user1_btName5;
            btNameList[5] = Properties.Settings.Default.user1_btName6;
            btNameList[6] = Properties.Settings.Default.user1_btName7;
            btNameList[7] = Properties.Settings.Default.user1_btName8;

            cmdList[0] = Properties.Settings.Default.user1_cmd1;
            cmdList[1] = Properties.Settings.Default.user1_cmd2;
            cmdList[2] = Properties.Settings.Default.user1_cmd3;
            cmdList[3] = Properties.Settings.Default.user1_cmd4;
            cmdList[4] = Properties.Settings.Default.user1_cmd5;
            cmdList[5] = Properties.Settings.Default.user1_cmd6;
            cmdList[6] = Properties.Settings.Default.user1_cmd7;
            cmdList[7] = Properties.Settings.Default.user1_cmd8;

            return true;
        }
        public bool LoadUser2Setup()
        {
            btNameList[0] = Properties.Settings.Default.user2_btName1;
            btNameList[1] = Properties.Settings.Default.user2_btName2;
            btNameList[2] = Properties.Settings.Default.user2_btName3;
            btNameList[3] = Properties.Settings.Default.user2_btName4;
            btNameList[4] = Properties.Settings.Default.user2_btName5;
            btNameList[5] = Properties.Settings.Default.user2_btName6;
            btNameList[6] = Properties.Settings.Default.user2_btName7;
            btNameList[7] = Properties.Settings.Default.user2_btName8;

            cmdList[0] = Properties.Settings.Default.user2_cmd1;
            cmdList[1] = Properties.Settings.Default.user2_cmd2;
            cmdList[2] = Properties.Settings.Default.user2_cmd3;
            cmdList[3] = Properties.Settings.Default.user2_cmd4;
            cmdList[4] = Properties.Settings.Default.user2_cmd5;
            cmdList[5] = Properties.Settings.Default.user2_cmd6;
            cmdList[6] = Properties.Settings.Default.user2_cmd7;
            cmdList[7] = Properties.Settings.Default.user2_cmd8;

            return true;
        }
        public bool LoadUser3Setup()
        {
            btNameList[0] = Properties.Settings.Default.user3_btName1;
            btNameList[1] = Properties.Settings.Default.user3_btName2;
            btNameList[2] = Properties.Settings.Default.user3_btName3;
            btNameList[3] = Properties.Settings.Default.user3_btName4;
            btNameList[4] = Properties.Settings.Default.user3_btName5;
            btNameList[5] = Properties.Settings.Default.user3_btName6;
            btNameList[6] = Properties.Settings.Default.user3_btName7;
            btNameList[7] = Properties.Settings.Default.user3_btName8;

            cmdList[0] = Properties.Settings.Default.user3_cmd1;
            cmdList[1] = Properties.Settings.Default.user3_cmd2;
            cmdList[2] = Properties.Settings.Default.user3_cmd3;
            cmdList[3] = Properties.Settings.Default.user3_cmd4;
            cmdList[4] = Properties.Settings.Default.user3_cmd5;
            cmdList[5] = Properties.Settings.Default.user3_cmd6;
            cmdList[6] = Properties.Settings.Default.user3_cmd7;
            cmdList[7] = Properties.Settings.Default.user3_cmd8;

            return true;
        }
        public bool LoadUser4Setup()
        {
            btNameList[0] = Properties.Settings.Default.user4_btName1;
            btNameList[1] = Properties.Settings.Default.user4_btName2;
            btNameList[2] = Properties.Settings.Default.user4_btName3;
            btNameList[3] = Properties.Settings.Default.user4_btName4;
            btNameList[4] = Properties.Settings.Default.user4_btName5;
            btNameList[5] = Properties.Settings.Default.user4_btName6;
            btNameList[6] = Properties.Settings.Default.user4_btName7;
            btNameList[7] = Properties.Settings.Default.user4_btName8;

            cmdList[0] = Properties.Settings.Default.user4_cmd1;
            cmdList[1] = Properties.Settings.Default.user4_cmd2;
            cmdList[2] = Properties.Settings.Default.user4_cmd3;
            cmdList[3] = Properties.Settings.Default.user4_cmd4;
            cmdList[4] = Properties.Settings.Default.user4_cmd5;
            cmdList[5] = Properties.Settings.Default.user4_cmd6;
            cmdList[6] = Properties.Settings.Default.user4_cmd7;
            cmdList[7] = Properties.Settings.Default.user4_cmd8;

            return true;
        }

        public string[] GetCurrentUserSetting(int NameOrCmd)
        {
            string[] sRet = null;
            int currentUser = Properties.Settings.Default.user_current;
            switch (currentUser)
            {
                case 0:
                    LoadUser1Setup();
                    break;
                case 1:
                    LoadUser2Setup();
                    break;
                case 2:
                    LoadUser3Setup();
                    break;
                case 3:
                    LoadUser4Setup();
                    break;
                default:
                    break;
            }

            if (NameOrCmd == 1)
            {
                sRet = btNameList;
            }
            else if (NameOrCmd == 0)
            {
                sRet = cmdList;
            }

            return sRet;
        }
        public string GetCurrentUserName()
        {
            string sRet = null;
            int currentUser = Properties.Settings.Default.user_current;

            switch (currentUser)
            {
                case 0:
                    sRet = Properties.Settings.Default.user1_name;
                    break;
                case 1:
                    sRet = Properties.Settings.Default.user2_name;
                    break;
                case 2:
                    sRet = Properties.Settings.Default.user3_name;
                    break;
                case 3:
                    sRet = Properties.Settings.Default.user4_name;
                    break;
                default:
                    break;
            }

            return sRet;
        }
        public bool ChangeCurrentUser(bool ForwardOrBackward)
        {
            bool bRet = false;
            int idx = Properties.Settings.Default.user_current;

            if (ForwardOrBackward)
            {
                if(idx < 4)
                {
                    if (idx < 3) idx += 1;
                    Properties.Settings.Default.user_current = idx;
                    bRet = true;
                }
            }
            else
            {
                if (idx >= 0)
                {
                    if (idx > 0) idx -= 1;
                    Properties.Settings.Default.user_current = idx;
                    bRet = true;
                }
            }
            return bRet;
        }
        public bool GetFlagInsertLF()
        {
            return Properties.Settings.Default.flagInsertLF;
        }
        public bool GetFlagInsertCR()
        {
            return Properties.Settings.Default.flagInsertCr;
        }
    }
}

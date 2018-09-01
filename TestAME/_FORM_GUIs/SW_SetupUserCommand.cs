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
    public partial class SW_SetupUserCommand : Form
    {
//==============================================================================
// All Atributes.
//==============================================================================
        List<RadioButton> UserList = null;
        int currentUser = 999;

//==============================================================================
// Window Actions.
//==============================================================================
        public SW_SetupUserCommand()
        {
            InitializeComponent();
            UserList = new List<RadioButton>() { rbtUser1,rbtUser2,rbtUser3,rbtUser4};
            LoadCurrentUser();
            LoadUserName();
        }

//==============================================================================
// Internal Actions.
//==============================================================================
        public bool LoadUserName()
        {
            tbUser1Name.Text = Properties.Settings.Default.user1_name;
            tbUser2Name.Text = Properties.Settings.Default.user2_name;
            tbUser3Name.Text = Properties.Settings.Default.user3_name;
            tbUser4Name.Text = Properties.Settings.Default.user4_name;
            return true;
        }
        public bool UpdateUserName()
        {
            Properties.Settings.Default.user1_name = tbUser1Name.Text;
            Properties.Settings.Default.user2_name = tbUser2Name.Text;
            Properties.Settings.Default.user3_name = tbUser3Name.Text;
            Properties.Settings.Default.user4_name = tbUser4Name.Text;
            return true;
        }

        public bool LoadCurrentUser()
        {
            currentUser = Properties.Settings.Default.user_current;
            switch (currentUser)
            { 
                case 0:
                    LoadUser1Setup();
                    rbtUser1.Checked = true;
                    break;
                case 1:
                    LoadUser2Setup();
                    rbtUser2.Checked = true;
                    break;
                case 2:
                    LoadUser3Setup();
                    rbtUser3.Checked = true;
                    break;
                case 3:
                    LoadUser4Setup();
                    rbtUser4.Checked = true;
                    break;
                default:
                    break;
            }

            if (Properties.Settings.Default.flagInsertLF == true)
            {
                FlagInsertLF.Checked = true;
            }
            else
            {
                FlagInsertLF.Checked = false;
            }

            return true;
        }
        public bool UpdateCurrentUser(int currentUser)
        {
            Properties.Settings.Default.user_current = currentUser;
            switch (currentUser)
            {
                case 0:
                    UpdateUser1Setup();
                    break;
                case 1:
                    UpdateUser2Setup();
                    break;
                case 2:
                    UpdateUser3Setup();
                    break;
                case 3:
                    UpdateUser4Setup();
                    break;
                default:
                    break;
            }
            return true;
        }

        public bool LoadUser1Setup()
        { 
            tbName1.Text = Properties.Settings.Default.user1_btName1;
            tbName2.Text = Properties.Settings.Default.user1_btName2;
            tbName3.Text = Properties.Settings.Default.user1_btName3;
            tbName4.Text = Properties.Settings.Default.user1_btName4;
            tbName5.Text = Properties.Settings.Default.user1_btName5;
            tbName6.Text = Properties.Settings.Default.user1_btName6;
            tbName7.Text = Properties.Settings.Default.user1_btName7;
            tbName8.Text = Properties.Settings.Default.user1_btName8;
            tbCmd1.Text  = Properties.Settings.Default.user1_cmd1   ;
            tbCmd2.Text  = Properties.Settings.Default.user1_cmd2   ;
            tbCmd3.Text  = Properties.Settings.Default.user1_cmd3   ;
            tbCmd4.Text  = Properties.Settings.Default.user1_cmd4   ;
            tbCmd5.Text  = Properties.Settings.Default.user1_cmd5   ;
            tbCmd6.Text  = Properties.Settings.Default.user1_cmd6   ;
            tbCmd7.Text  = Properties.Settings.Default.user1_cmd7   ;
            tbCmd8.Text  = Properties.Settings.Default.user1_cmd8   ;

            return true;
        }
        public void UpdateUser1Setup()
        {
            Properties.Settings.Default.user1_btName1 = tbName1.Text;
            Properties.Settings.Default.user1_btName2 = tbName2.Text;
            Properties.Settings.Default.user1_btName3 = tbName3.Text;
            Properties.Settings.Default.user1_btName4 = tbName4.Text;
            Properties.Settings.Default.user1_btName5 = tbName5.Text;
            Properties.Settings.Default.user1_btName6 = tbName6.Text;
            Properties.Settings.Default.user1_btName7 = tbName7.Text;
            Properties.Settings.Default.user1_btName8 = tbName8.Text;

            Properties.Settings.Default.user1_cmd1    = tbCmd1.Text ;
            Properties.Settings.Default.user1_cmd2    = tbCmd2.Text ;
            Properties.Settings.Default.user1_cmd3    = tbCmd3.Text ;
            Properties.Settings.Default.user1_cmd4    = tbCmd4.Text ;
            Properties.Settings.Default.user1_cmd5    = tbCmd5.Text ;
            Properties.Settings.Default.user1_cmd6    = tbCmd6.Text ;
            Properties.Settings.Default.user1_cmd7    = tbCmd7.Text;
            Properties.Settings.Default.user1_cmd8    = tbCmd8.Text;

            Properties.Settings.Default.Save();
        }

        public bool LoadUser2Setup()
        { 
	        tbName1.Text = Properties.Settings.Default.user2_btName1;
	        tbName2.Text = Properties.Settings.Default.user2_btName2;
	        tbName3.Text = Properties.Settings.Default.user2_btName3;
	        tbName4.Text = Properties.Settings.Default.user2_btName4;
	        tbName5.Text = Properties.Settings.Default.user2_btName5;
	        tbName6.Text = Properties.Settings.Default.user2_btName6;
            tbName7.Text = Properties.Settings.Default.user2_btName7;
            tbName8.Text = Properties.Settings.Default.user2_btName8;

	        tbCmd1.Text  = Properties.Settings.Default.user2_cmd1   ;
	        tbCmd2.Text  = Properties.Settings.Default.user2_cmd2   ;
	        tbCmd3.Text  = Properties.Settings.Default.user2_cmd3   ;
	        tbCmd4.Text  = Properties.Settings.Default.user2_cmd4   ;
	        tbCmd5.Text  = Properties.Settings.Default.user2_cmd5   ;
	        tbCmd6.Text  = Properties.Settings.Default.user2_cmd6   ;
            tbCmd7.Text  = Properties.Settings.Default.user2_cmd7   ;
            tbCmd8.Text  = Properties.Settings.Default.user2_cmd8   ;

	        return true;
        }
        public void UpdateUser2Setup()
        {
            Properties.Settings.Default.user2_btName1 = tbName1.Text;
            Properties.Settings.Default.user2_btName2 = tbName2.Text;
            Properties.Settings.Default.user2_btName3 = tbName3.Text;
            Properties.Settings.Default.user2_btName4 = tbName4.Text;
            Properties.Settings.Default.user2_btName5 = tbName5.Text;
            Properties.Settings.Default.user2_btName6 = tbName6.Text;
            Properties.Settings.Default.user2_btName7 = tbName7.Text;
            Properties.Settings.Default.user2_btName8 = tbName8.Text;

            Properties.Settings.Default.user2_cmd1 = tbCmd1.Text;
            Properties.Settings.Default.user2_cmd2 = tbCmd2.Text;
            Properties.Settings.Default.user2_cmd3 = tbCmd3.Text;
            Properties.Settings.Default.user2_cmd4 = tbCmd4.Text;
            Properties.Settings.Default.user2_cmd5 = tbCmd5.Text;
            Properties.Settings.Default.user2_cmd6 = tbCmd6.Text;
            Properties.Settings.Default.user2_cmd7 = tbCmd7.Text;
            Properties.Settings.Default.user2_cmd8 = tbCmd8.Text;

            Properties.Settings.Default.Save();
        }

        public bool LoadUser3Setup()
        {
            tbName1.Text = Properties.Settings.Default.user3_btName1;
            tbName2.Text = Properties.Settings.Default.user3_btName2;
            tbName3.Text = Properties.Settings.Default.user3_btName3;
            tbName4.Text = Properties.Settings.Default.user3_btName4;
            tbName5.Text = Properties.Settings.Default.user3_btName5;
            tbName6.Text = Properties.Settings.Default.user3_btName6;
            tbName7.Text = Properties.Settings.Default.user3_btName7;
            tbName8.Text = Properties.Settings.Default.user3_btName8;

            tbCmd1.Text = Properties.Settings.Default.user3_cmd1;
            tbCmd2.Text = Properties.Settings.Default.user3_cmd2;
            tbCmd3.Text = Properties.Settings.Default.user3_cmd3;
            tbCmd4.Text = Properties.Settings.Default.user3_cmd4;
            tbCmd5.Text = Properties.Settings.Default.user3_cmd5;
            tbCmd6.Text = Properties.Settings.Default.user3_cmd6;
            tbCmd7.Text = Properties.Settings.Default.user3_cmd7;
            tbCmd8.Text = Properties.Settings.Default.user3_cmd8;

            return true;
        }
        public void UpdateUser3Setup()
        {
            Properties.Settings.Default.user3_btName1 = tbName1.Text;
            Properties.Settings.Default.user3_btName2 = tbName2.Text;
            Properties.Settings.Default.user3_btName3 = tbName3.Text;
            Properties.Settings.Default.user3_btName4 = tbName4.Text;
            Properties.Settings.Default.user3_btName5 = tbName5.Text;
            Properties.Settings.Default.user3_btName6 = tbName6.Text;
            Properties.Settings.Default.user3_btName7 = tbName7.Text;
            Properties.Settings.Default.user3_btName8 = tbName8.Text;

            Properties.Settings.Default.user3_cmd1 = tbCmd1.Text;
            Properties.Settings.Default.user3_cmd2 = tbCmd2.Text;
            Properties.Settings.Default.user3_cmd3 = tbCmd3.Text;
            Properties.Settings.Default.user3_cmd4 = tbCmd4.Text;
            Properties.Settings.Default.user3_cmd5 = tbCmd5.Text;
            Properties.Settings.Default.user3_cmd6 = tbCmd6.Text;
            Properties.Settings.Default.user3_cmd7 = tbCmd7.Text;
            Properties.Settings.Default.user3_cmd8 = tbCmd8.Text;

            Properties.Settings.Default.Save();
        }

        public bool LoadUser4Setup()
        {
            tbName1.Text = Properties.Settings.Default.user4_btName1;
            tbName2.Text = Properties.Settings.Default.user4_btName2;
            tbName3.Text = Properties.Settings.Default.user4_btName3;
            tbName4.Text = Properties.Settings.Default.user4_btName4;
            tbName5.Text = Properties.Settings.Default.user4_btName5;
            tbName6.Text = Properties.Settings.Default.user4_btName6;
            tbName7.Text = Properties.Settings.Default.user4_btName7;
            tbName8.Text = Properties.Settings.Default.user4_btName8;

            tbCmd1.Text = Properties.Settings.Default.user4_cmd1;
            tbCmd2.Text = Properties.Settings.Default.user4_cmd2;
            tbCmd3.Text = Properties.Settings.Default.user4_cmd3;
            tbCmd4.Text = Properties.Settings.Default.user4_cmd4;
            tbCmd5.Text = Properties.Settings.Default.user4_cmd5;
            tbCmd6.Text = Properties.Settings.Default.user4_cmd6;
            tbCmd7.Text = Properties.Settings.Default.user4_cmd7;
            tbCmd8.Text = Properties.Settings.Default.user4_cmd8;

            return true;
        }
        public void UpdateUser4Setup()
        {
            Properties.Settings.Default.user4_btName1 = tbName1.Text;
            Properties.Settings.Default.user4_btName2 = tbName2.Text;
            Properties.Settings.Default.user4_btName3 = tbName3.Text;
            Properties.Settings.Default.user4_btName4 = tbName4.Text;
            Properties.Settings.Default.user4_btName5 = tbName5.Text;
            Properties.Settings.Default.user4_btName6 = tbName6.Text;
            Properties.Settings.Default.user4_btName7 = tbName7.Text;
            Properties.Settings.Default.user4_btName8 = tbName8.Text;

            Properties.Settings.Default.user4_cmd1 = tbCmd1.Text;
            Properties.Settings.Default.user4_cmd2 = tbCmd2.Text;
            Properties.Settings.Default.user4_cmd3 = tbCmd3.Text;
            Properties.Settings.Default.user4_cmd4 = tbCmd4.Text;
            Properties.Settings.Default.user4_cmd5 = tbCmd5.Text;
            Properties.Settings.Default.user4_cmd6 = tbCmd6.Text;
            Properties.Settings.Default.user4_cmd7 = tbCmd7.Text;
            Properties.Settings.Default.user4_cmd8 = tbCmd8.Text;

            Properties.Settings.Default.Save();
        }

//==============================================================================
// Event Process
//==============================================================================
        private void btOK_Click(object sender, EventArgs e)
        {
            UpdateCurrentUser(currentUser);
            UpdateUserName();
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbName1.Text = "";
            tbName2.Text = "";
            tbName3.Text = "";
            tbName4.Text = "";
            tbName5.Text = "";
            tbName6.Text = "";
            tbName7.Text = "";
            tbName8.Text = "";

            tbCmd1.Text = "";
            tbCmd2.Text = "";
            tbCmd3.Text = "";
            tbCmd4.Text = "";
            tbCmd5.Text = "";
            tbCmd6.Text = "";
            tbCmd7.Text = "";
            tbCmd8.Text = "";
        }

        private void rbtUser_Selected(object sender, EventArgs e)
        {
            int i = 0;
            foreach (RadioButton element in UserList)
            {
                if ((sender as RadioButton) == element)
                {
                    if (element.Checked == true)
                    {
                        UpdateCurrentUser(currentUser);
                        currentUser = i;
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
                    }
                }
                i++;
            }
        }

        private void FlagInsertLF_CheckedChanged(object sender, EventArgs e)
        {
            if (FlagInsertLF.Checked == true)
            {
                Properties.Settings.Default.flagInsertLF = true;
            }
            else
            {
                Properties.Settings.Default.flagInsertLF = false;
            }
        }
        
    }
}

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
//==============================================================================
// All Atributes.
//==============================================================================
        P_AME_ExcelFileProcess comExcel = null;
        string pathFileSelected = null;

//==============================================================================
// Window Actions.
//==============================================================================
        public SW_AME_Test()
        {
            InitializeComponent();
            comExcel = new P_AME_ExcelFileProcess();
        }

        private void SW_AME_Test_Load(object sender, EventArgs e)
        {
            UpdateFileInformation();
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

        public void UpdateFileInformation()
        {
            if (comExcel.IsFileExist() == true)
            {
                lbFileStatus.Text = "Process Done!";
                lbTotalCmd.Text = comExcel.NumberOfCommand.ToString();
                lbCurrentCmd.Text = "1";
                lbCurrentDesc.Text = comExcel.ListDescription[0];
                lbCurrentContent.Text = comExcel.ListCommand[0];
            }
            else
            {
                lbFileStatus.Text = "No file processed!";
                lbTotalCmd.Text = "...";
                lbCurrentCmd.Text = "...";
                lbCurrentDesc.Text = "...";
                lbCurrentContent.Text = "...";
            }
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
                    if (comExcel.FileCommandParser() > 0)
                    {
                        UpdateFileInformation();
                    }
                }
            }
            
        }

    }
}

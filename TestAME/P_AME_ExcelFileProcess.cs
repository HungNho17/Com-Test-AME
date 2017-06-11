using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace TestAME
{
    public struct COMMAND_TYPE
    {
        public int number;
        public string desc;
        public string cmd;
    };

    class P_AME_ExcelFileProcess
    {
        Excel.Application xlApp = new Excel.Application();
        Excel.Workbook xlWorkbook = null;
        Excel._Worksheet xlWorksheet = null;
        Excel.Range xlRange = null;

        public List<string> ListDescription = null;
        public List<string> ListCommand = null;
        int NumberOfCommand = 0;

        int rowCount = 0;
        int colCount = 0;

        bool FlagFileExist = false;

        public P_AME_ExcelFileProcess()
        {
            ListDescription = new List<string>();
            ListCommand = new List<string>();
        }

        ~ P_AME_ExcelFileProcess()
        {
            if (FlagFileExist)
            {
                this.ExcelCloseFile();
            }
        }

        public bool IsFileExist()
        {
            return FlagFileExist;
        }

        public bool ExcelOpenFile(string pathFile)
        {
            bool bRet = false;
            if (FlagFileExist == false)
            {
                try
                {
                    xlWorkbook = xlApp.Workbooks.Open(@pathFile, ReadOnly: false, Editable: true);
                    xlWorksheet = xlWorkbook.Sheets[1];
                    xlRange = xlWorksheet.UsedRange;

                    rowCount = xlRange.Rows.Count;
                    colCount = xlRange.Columns.Count;

                    FlagFileExist = true;
                    bRet = true;
                }
                catch
                {
                    MessageBox.Show("Can't open this file");
                    return false;
                }

            }
            return bRet;
        }

        public bool ExcelCloseFile()
        {
            bool bRet = false;
            if (FlagFileExist == true)
            {
                try
                {
                    //xlWorkbook.Save();
                    xlWorkbook.Close();
                    FlagFileExist = false;
                    bRet = true;
                }
                catch
                {
                    MessageBox.Show("Can't close this file");
                    return false;
                }
            }
            return bRet;
        }

        public int FileCommandParser()
        {
            int iRet = 0;
            int rowIdx = 0;

            string tempDescription = null;
            string tempCommand = null;

            if (FlagFileExist == true)
            {
                    for (rowIdx = 2; rowIdx < rowCount; rowIdx++)
                    {
                        try
                        {
                            if (xlWorksheet.Cells[rowIdx, 2].value != null)
                                tempDescription = xlWorksheet.Cells[rowIdx, 2].value.ToString();
                            else tempDescription = " "; 
                            ListDescription.Add(tempDescription);
                           
                            if (xlWorksheet.Cells[rowIdx, 3].value != null)
                                tempCommand = xlWorksheet.Cells[rowIdx, 3].value.ToString();
                            else tempCommand = " ";
                            ListCommand.Add(tempCommand);
                            iRet++;
                        }
                        catch { }
                    }
            }

            NumberOfCommand = iRet;
            return iRet;
        }

        public COMMAND_TYPE GetCommand(int CmdNumber)
        {
            COMMAND_TYPE cmdRet = new COMMAND_TYPE();
            cmdRet.number = 0;
            if (CmdNumber < NumberOfCommand)
            {
                cmdRet.number = CmdNumber+1;
                cmdRet.desc = ListDescription[CmdNumber];
                cmdRet.cmd = ListCommand[CmdNumber];
            }
            return cmdRet;
        }
    }
}

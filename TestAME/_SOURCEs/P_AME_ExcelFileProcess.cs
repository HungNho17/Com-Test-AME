using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace SerialComPort
{
    public struct COMMAND_TYPE
    {
        public int number;
        public string desc;
        public string cmd;
        public string timeWait;
        public string resultExpect;
    };

    class P_AME_ExcelFileProcess
    {
        Excel.Application xlApp = new Excel.Application();
        Excel.Workbook xlWorkbook = null;
        Excel._Worksheet xlWorksheet = null;
        Excel.Range xlRange = null;

        public List<COMMAND_TYPE> ListCommands = null;
        int NumberOfCommand = 0;

        int rowCount = 0;
        int colCount = 0;

        bool FlagFileExist = false;

        public P_AME_ExcelFileProcess()
        {
            ListCommands = new List<COMMAND_TYPE>();
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

            COMMAND_TYPE tempCmd = new COMMAND_TYPE();

            if (FlagFileExist == true)
            {
                    for (rowIdx = 2; rowIdx < rowCount; rowIdx++)
                    {
                        try
                        {
                            if (xlWorksheet.Cells[rowIdx, 2].value != null)
                                tempCmd.desc = xlWorksheet.Cells[rowIdx, 2].value.ToString();
                            else tempCmd.desc = " ";
                           
                            if (xlWorksheet.Cells[rowIdx, 3].value != null)
                                tempCmd.cmd = xlWorksheet.Cells[rowIdx, 3].value.ToString();
                            else tempCmd.cmd = " ";

                            if (xlWorksheet.Cells[rowIdx, 4].value != null)
                                tempCmd.timeWait = xlWorksheet.Cells[rowIdx, 4].value.ToString();
                            else tempCmd.timeWait = " ";

                            if (xlWorksheet.Cells[rowIdx, 5].value != null)
                                tempCmd.resultExpect = xlWorksheet.Cells[rowIdx, 5].value.ToString();
                            else tempCmd.resultExpect = " ";

                            tempCmd.number = iRet+1;
                            ListCommands.Add(tempCmd);
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
            if (CmdNumber < NumberOfCommand)
            {
                cmdRet = ListCommands[CmdNumber];
            }
            return cmdRet;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace TestAME
{
    class P_AME_ExcelFileProcess
    {
        Excel.Application xlApp = new Excel.Application();
        Excel.Workbook xlWorkbook = null;
        Excel._Worksheet xlWorksheet = null;
        Excel.Range xlRange = null;

        public List<string> ListDescription = null;
        public List<string> ListCommand = null;
        public int NumberOfCommand = 0;

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
                    NumberOfCommand = rowCount - 1;

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
                    xlWorkbook.Save();
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
                            if (xlWorksheet.Cells[rowIdx, 2] != null)
                            {
                                tempDescription = xlWorksheet.Cells[rowIdx, 2].value.ToString();
                                ListDescription.Add(tempDescription);
                            }
                            if (xlWorksheet.Cells[rowIdx, 3] != null)
                            {
                                tempCommand = xlWorksheet.Cells[rowIdx, 3].value.ToString();
                                ListCommand.Add(tempCommand);
                            }
                        }
                        catch { }
                    }
                    iRet = rowIdx - 1;
            }
            return iRet;
        }
    }
}

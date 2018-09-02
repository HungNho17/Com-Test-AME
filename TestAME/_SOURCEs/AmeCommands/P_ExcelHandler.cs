using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace TestAME
{

    public interface I_ExcelHandler
    {
        bool            LoadFile (string sFilePath);
        bool            CheckStructure (string[] sFieldList);
        List<string[]>  ParseFileAsStructure ();
        bool            CreateCopyFile (string sFileName, List<string[]> lContents);
    }

    public class P_ExcelHandler : I_ExcelHandler
    {
        // attributes
        private Excel.Application   xlApp       = new Excel.Application();
        private Excel.Workbook      xlWorkbook  = null;
        private Excel._Worksheet    xlWorksheet = null;
        private Excel.Range         xlRange     = null;

        private bool                m_bFileOpen     = false;
        private int                 m_iFieldNumber  = 0;
        private int                 m_iRowStartNum  = 1;
        private int                 m_iColStartNum  = 1;

        public P_ExcelHandler(){ }
        ~P_ExcelHandler()
        {
            if (m_bFileOpen == true)
            {
                UnLoadFile();
            }
        }
       
        public bool LoadFile(string sFilePath)
        {
            bool bRet = false;
            
            if (File.Exists(sFilePath) == true)
            {
                if (m_bFileOpen == true)
                {
                    UnLoadFile();
                }

                try
                {
                    xlWorkbook  = xlApp.Workbooks.Open(@sFilePath, ReadOnly: false, Editable: true);
                    xlWorksheet = xlWorkbook.Sheets[1];
                    xlRange     = xlWorksheet.UsedRange;

                    m_bFileOpen = true;
                    bRet = true;
                }
                catch{ ;}
            }

            return bRet;
        }

        public bool CheckStructure(string[] sFieldList)
        {
            bool bRet = false;
            
            if ((m_bFileOpen == true)   ||
                (sFieldList != null)    ||
                (sFieldList.Length > 0))
            {
                for (int iRowIdx = 1; iRowIdx < 100; iRowIdx++)
                {
                    int iIdx = 0;
                    for (int iColIdx = 1; iColIdx < 20; iColIdx++)
                    {
                        if ((xlWorksheet.Cells[iRowIdx, iColIdx].value != null) &&
                            (xlWorksheet.Cells[iRowIdx, iColIdx].value.ToString() == sFieldList[iIdx]))
                        {
                            if (iIdx == 0)
                            {
                                m_iColStartNum = iColIdx;
                            }
                            ++iIdx;
                        }
                    }

                    if (iIdx == sFieldList.Length)
                    {
                        m_iRowStartNum = iRowIdx + 1;
                        m_iFieldNumber = sFieldList.Length;

                        bRet = true;
                        break;
                    }
                }
            }

            return bRet;
        }

        public List<string[]> ParseFileAsStructure()
        {
            List<string[]> lRet = null;

            if (m_iFieldNumber > 0)
            {
                lRet = new List<string[]>();

                for (int iRowIdx = m_iRowStartNum; ; iRowIdx++)
                {
                    int iIdx = 0;
                    string[] sFieldContent = new string[m_iFieldNumber];

                    for (int iColIdx = m_iColStartNum; iColIdx < (m_iColStartNum + m_iFieldNumber); iColIdx++)
                    {
                        if (xlWorksheet.Cells[iRowIdx, iColIdx].value != null)
                                sFieldContent[iIdx++] = xlWorksheet.Cells[iRowIdx, iColIdx].value.ToString();
                        else sFieldContent[iIdx++] = "";
                    }

                    if ((sFieldContent[0] == "") &&
                        (sFieldContent[1] == "") &&
                        (sFieldContent[2] == "") )
                    {
                        break;
                    }

                    lRet.Add(sFieldContent);
                }
            }

            return lRet;
        }

        public bool CreateCopyFile(string sFilePath, List<string[]> lContents)
        {
            bool  bRet = false;

            return bRet;
        }

        // private apis
        private void UnLoadFile()
        {
            if (m_bFileOpen == true)
            {
                try
                {
                    xlWorkbook.Save();
                    xlWorkbook.Close();

                    m_bFileOpen = false;
                }
                catch{ ;}
            }
        }
    }
}

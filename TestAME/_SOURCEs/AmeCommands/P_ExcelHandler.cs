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
        void            Closed();
        bool            CheckStructure (string[] sFieldList);
        List<string[]>  ParseFileAsStructure ();
        bool            CreateCopyFile (string sFileName, List<string[]> lContents);
    }

    public class P_ExcelHandler : I_ExcelHandler
    {
        // attributes
        private Excel.Application   xlApp       = null;
        private Excel.Workbook      xlWorkbook  = null;
        private Excel._Worksheet    xlWorksheet = null;
        private Excel.Range         xlRange     = null;

        private bool                m_bFileOpen     = false;
        private int                 m_iFieldNumber  = 0;
        private int                 m_iRowStartNum  = 1;
        private int                 m_iColStartNum  = 1;

        private List<string[]>      m_lsFileContent = null;

        public P_ExcelHandler()
        {
            xlApp = new Excel.Application();
        }

        ~P_ExcelHandler()
        {
            Closed();
        }
       
        public bool LoadFile(string sFilePath)
        {
            bool bRet = false;

            if (sFilePath != null)
            {
                if (Path.GetExtension(sFilePath) == ".csv")
                {
                    m_lsFileContent = ReadCsvFile(sFilePath);
                }
                else
                {
                    m_lsFileContent = ReadExcelFile(sFilePath);
                }

                if (m_lsFileContent != null && m_lsFileContent.Count > 0)
                {
                    m_bFileOpen = true;
                    bRet = true;
                }
            }
            
            return bRet;
        }

        public void Closed()
        {
            if (xlWorkbook != null)
                xlWorkbook.Close(false);
            if (xlApp != null)
                xlApp.Quit();
        }

        public bool CheckStructure(string[] sFieldList)
        {
            bool bRet = false;
            
            if ((m_bFileOpen == true)   ||
                (sFieldList != null)    ||
                (sFieldList.Length > 0))
            {
                for (int iRowIdx = 0; iRowIdx < m_lsFileContent.Count; iRowIdx++)
                {
                    int iIdx = 0;
                    string[] sRowContent = m_lsFileContent[iRowIdx];

                    for (int iColIdx = 0; iColIdx < sRowContent.Length; iColIdx++)
                    {
                        if ((sRowContent[iColIdx] != null) &&
                            (sRowContent[iColIdx] == sFieldList[iIdx]))
                        {
                            if (iIdx == 0)
                            {
                                m_iColStartNum = iColIdx;
                            }
                            ++iIdx;

                            if (iIdx == sFieldList.Length)
                            {
                                break;
                            }
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

                for (int iRowIdx = m_iRowStartNum; iRowIdx < m_lsFileContent.Count ; iRowIdx++)
                {
                    string[] sRowContent = m_lsFileContent[iRowIdx];

                    if (sRowContent.Length >= (m_iColStartNum + m_iFieldNumber))
                    {
                        int iIdx = 0;
                        string[] sFieldContent = new string[m_iFieldNumber];

                        for (int iColIdx = m_iColStartNum; iColIdx < (m_iColStartNum + m_iFieldNumber); iColIdx++)
                        {
                            sFieldContent[iIdx++] = sRowContent[iColIdx];
                        }

                        lRet.Add(sFieldContent);
                    }
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
        private List<string[]> ReadCsvFile(string sFilePath)
        {
            List<string[]> lsRet = null;

            if (File.Exists(sFilePath) && (Path.GetExtension(sFilePath)==".csv"))
            {
                lsRet = new List<string[]>();
                using (StringReader sReader = new StringReader(File.ReadAllText(sFilePath)))
                {
                    uint uiCount = 0;
                    while (sReader.Peek() > 0)
                    {
                        try
                        {
                            string[] lsTemp = sReader.ReadLine().Split(',');

                            if ((lsTemp[0] == string.Empty) &&
                                (lsTemp[1] == string.Empty) &&
                                (lsTemp[2] == string.Empty))
                            {
                                if (uiCount < 3)
                                {
                                    uiCount++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                uiCount = 0;
                                lsRet.Add(lsTemp);
                            }
                        }
                        catch { }
                    }
                }
            }

            return lsRet;
        }

        private List<string[]> ReadExcelFile(string sFilePath)
        {
            List<string[]> lsRet = null;

            if (File.Exists(sFilePath))
            {
                lsRet = new List<string[]>();
                
                try
                {
                    xlWorkbook  = xlApp.Workbooks.Open(@sFilePath, ReadOnly: false, Editable: true);
                    xlWorksheet = xlWorkbook.Sheets[1];
                    xlRange     = xlWorksheet.UsedRange;
                }
                catch{}

                uint uiCount = 0;
                for (int iRowIdx = 1/*first row*/; ; iRowIdx++)
                {
                    int iIdx = 0;
                    string[] sFieldContent = new string[10];

                    for (int iColIdx = 1/*first column*/; iColIdx < 10; iColIdx++)
                    {
                        if (xlWorksheet.Cells[iRowIdx, iColIdx].value != null)
                                sFieldContent[iIdx++] = xlWorksheet.Cells[iRowIdx, iColIdx].value.ToString();
                        else sFieldContent[iIdx++] = string.Empty;
                    }

                    if ((sFieldContent[0] == string.Empty) &&
                        (sFieldContent[1] == string.Empty) &&
                        (sFieldContent[2] == string.Empty))
                    {
                        if (uiCount < 3)
                        {
                            uiCount++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        uiCount = 0;
                        lsRet.Add(sFieldContent);
                    }
                }
            }

            return lsRet;
        }
    }
}

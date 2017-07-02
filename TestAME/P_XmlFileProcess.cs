using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace TestAME
{
    public struct ImageInfo
    {
        public string ImageName;
        public string Group;
        public string Desc;
        public string Conte;
    };

    class P_XmlFileProcess
    {
        

        //==============================================================================
        // Attributes.
        //==============================================================================
        #region ATTRIBUTES
        string XMLFilePath = null;
        bool FlagFileLoaded = false;

        XmlDocument XMLFileCurr = null;
        XmlNodeList XMLNodeListFile = null;

        List<ImageInfo> ListOfImageInfo = null;
        #endregion

        //==============================================================================
        // Operations -- API PUBLIC
        //==============================================================================
        #region API_PUBLIC
        public P_XmlFileProcess(string iPathFile)
        {
            XMLFileCurr = new XmlDocument();
            ListOfImageInfo = new List<ImageInfo>() { };
            if (XML_FileCheck(iPathFile))
            {
                XMLNodeListFile = XMLFileCurr.SelectNodes("/Image");
            }
            XMLFilePath = iPathFile;
            XMLFileCurr.Load(XMLFilePath);
            FlagFileLoaded = true;
        }

        public List<ImageInfo> GetImageListInfo()
        {
            List<ImageInfo> listRet = new List<ImageInfo>();
            ImageInfo tempImageInfo = new ImageInfo();

            XmlNode root = XMLFileCurr.SelectSingleNode("ImageManage");
            XMLNodeListFile = root.SelectNodes("Image");
            foreach (XmlNode element in XMLNodeListFile)
            {
                tempImageInfo.ImageName = ((XmlElement)element).GetAttribute("name");
                tempImageInfo.Group = ((XmlElement)((XmlElement)element).SelectSingleNode("Group")).GetAttribute("name");
                tempImageInfo.Desc = ((XmlElement)((XmlElement)element).SelectSingleNode("Desc")).GetAttribute("name");
                tempImageInfo.Conte = ((XmlElement)((XmlElement)element).SelectSingleNode("Conte")).GetAttribute("name");
                listRet.Add(tempImageInfo);
            }

            try
            {
                if (listRet.Count > 0)
                {
                    ListOfImageInfo = listRet;
                }
            } catch { }

            

            return listRet;
        }

        public bool AddNewImage(string iImageName, string iGroup, string iImageDesc, string iImageConte)
        {
            bool bRet = true;
            XMLFileCurr.Load(XMLFilePath);

            XmlElement eImage = XMLFileCurr.CreateElement("Image", null);
            eImage.SetAttribute("name", iImageName);

            XmlElement eGroup = XMLFileCurr.CreateElement("Group", null);
            eGroup.SetAttribute("name", iGroup);
            eImage.AppendChild(eGroup);

            XmlElement eImageDesc = XMLFileCurr.CreateElement("Desc", null);
            eImageDesc.SetAttribute("name", iImageDesc);
            eImage.AppendChild(eImageDesc);

            XmlElement eImageConte = XMLFileCurr.CreateElement("Conte", null);
            eImageConte.SetAttribute("name", iImageConte);
            eImage.AppendChild(eImageConte);
            
            XMLFileCurr.DocumentElement.AppendChild(eImage);
            XMLFileCurr.Save(XMLFilePath);

            return bRet;
        }

        public bool RemoveImage(string iImageName)
        {
            bool bRet = false;
            XMLFileCurr.Load(XMLFilePath);

            XmlNode root = XMLFileCurr.SelectSingleNode ("/ImageManage");
            XMLNodeListFile = root.SelectNodes("Image");
            foreach (XmlNode element in XMLNodeListFile)
            {
                XmlElement temp = (XmlElement)element;
                if (temp.GetAttribute("name") == iImageName)
                {
                    element.ParentNode.RemoveChild(element);
                    XMLFileCurr.Save(XMLFilePath);
                    bRet = true;
                    break;
                }
            }

            return bRet;
        }
        #endregion
        //==============================================================================
        // Operations -- API PRIVATE
        //==============================================================================
        #region API_PRIVATE
        private bool XML_FileCheck(string iPathFile)
        {
            bool bRet = true;
            if (File.Exists(iPathFile) == false)
            {
                XDocument doc = new XDocument(  new XElement("ImageManage", "\n\n\n\n"));
                doc.Save(iPathFile);
                bRet = false;
            }
            return bRet;
        }
        #endregion
    }
}

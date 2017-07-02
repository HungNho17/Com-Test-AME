using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Xml;

namespace TestAME
{
    public partial class SW_LabelsProgramming : Form
    {

        //==============================================================================
        // Atributes.
        //==============================================================================
        #region ATTRIBUTES

        Size Image_Small = new Size(270, 90);
        Size Image_Medium = new Size(360, 90);
        Size Image_Normal = new Size(450, 90);

        string ImageResourceName = "\\ImageResource";
        string ImageResourcePath = null;

        string sGroup = null;
        string sDesc = null;
        string sConte = null;

        string XMLFileName = "\\ImageManage.XML";
        P_XmlFileProcess ImageManageXML = null;
        List<ImageInfo> ListOfImageInfo = null;
        List<ImageInfo> ListOfImageGroup = null;
        int iTotalImageValid = 0;
        int iTotalImageInGroupSelected = 0;
        int iImageIndexSelected = 0;
        #endregion
        //==============================================================================
        // Operations -- WINDOW ACTIONS
        //==============================================================================
        #region WINDOW_ACTION

        public SW_LabelsProgramming()
        {
            InitializeComponent();
        }
        private void SW_LabelsProgramming_Load(object sender, EventArgs e)
        {
            UpdateRightContextMenu();
            CheckImageResource();

            ImageManageXML = new P_XmlFileProcess(ImageResourcePath+ XMLFileName);
            UpdateImageResourceInfo();
        }
        #endregion
        //==============================================================================
        // Operations -- API ACTIONS
        //==============================================================================
        #region API_ACTIONS

        #endregion
        //==============================================================================
        // Operations -- INTERNAL ACTIONS
        //==============================================================================
        #region INTERNAL_ACTIONS

        private bool UpdateImageResourceInfo()
        {
            bool bRet = false;
            if (ImageManageXML != null)
            {
                iTotalImageValid = 0;
                ListOfImageInfo = ImageManageXML.GetImageListInfo();
                try
                {
                    iTotalImageValid = ListOfImageInfo.Count;
                }
                catch { }
                if (iTotalImageValid > 0)
                {
                    foreach (ImageInfo element in ListOfImageInfo)
                    {
                        if (cbGroup.Items.Count > 0)
                        {
                            try
                            {
                                foreach (string element1 in cbGroup.Items)
                                {
                                    if (element1 != element.Group)
                                    {
                                        cbGroup.Items.Add(element.Group);
                                    }
                                }
                            } catch { }
                        }
                        else
                            cbGroup.Items.Add(element.Group);
                    }

                    UpdateGroupSelected(0);
                }
                else
                    MessageBox.Show("No Label stored!");
                bRet = true;
            }
            return bRet;
        }
        private bool UpdateGroupSelected(int index)
        {
            bool bRet = false;
            if (cbGroup.Items.Count > 0 && index < cbGroup.Items.Count)
            {
                cbGroup.SelectedIndex = index;
                ListOfImageGroup = new List<ImageInfo>();
                iTotalImageInGroupSelected = 0;
                cbDesc.Items.Clear();
                cbCont.Items.Clear();
                iImageIndexSelected = 0;

                foreach (ImageInfo element in ListOfImageInfo)
                {
                    if (cbGroup.Text == element.Group)
                    {
                        ListOfImageGroup.Add(element);
                        iTotalImageInGroupSelected++;
                        cbDesc.Items.Add(element.Desc);
                        cbCont.Items.Add(element.Conte);
                    }
                }

                UpdateImageSelected(iImageIndexSelected);
            }
            return bRet;
        }
        private bool UpdateImageSelected(int idx)
        {
            bool bRet = false;
            if (idx < iTotalImageInGroupSelected && iTotalImageInGroupSelected > 0)
            {
                ImageInfo ImageInfo = ListOfImageGroup[idx];
                Bitmap temp = LoadPicture(ImageInfo.ImageName);
                if(temp != null)
                {
                    pbCurrentPicture.Image = temp;
                    iImageIndexSelected = idx;
                    cbDesc.SelectedIndex = iImageIndexSelected;
                    cbCont.SelectedIndex = iImageIndexSelected;
                    bRet = true;
                }
            }
            return bRet;
        }
        private bool VerifyImageInfo(string sGroup,string sDesc,string sCont)
        {
            bool bRet = true;

            if (sGroup == "" || sDesc == "" || sCont == "") return false;

            if (ListOfImageInfo != null)
            {
                foreach (ImageInfo element in ListOfImageInfo)
                {
                    if (sGroup == element.Group && sDesc == element.Desc && sCont == element.Conte)
                    {
                        bRet = false;
                        break;
                    }
                }
            }
            return bRet;
        }
        private bool CheckImageResource()
        {
            bool bRet = false;
            string DirectorPath = Directory.GetCurrentDirectory();
            ImageResourcePath = DirectorPath + ImageResourceName;
            if (Directory.Exists(ImageResourcePath))
            {
                bRet = true;
            }
            else
            {
                try
                {
                    Directory.CreateDirectory(ImageResourcePath);
                    bRet = true;
                }
                catch
                { }
            }
            return bRet;
        }
        private bool CheckResourceManage()
        {
            bool bRet = false;

            return bRet;
        }

        private bool UpdateRightContextMenu()
        {
            bool bRet = true;
            
            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Copy", new EventHandler(CurrentPicture_copy));
            cm.MenuItems.Add("Paste", new EventHandler(CurrentPicture_paste));
            pbCurrentPicture.ContextMenu = cm; 

            return bRet;
        }
        private void CurrentPicture_copy(Object s, EventArgs e)
        {
            if (pbCurrentPicture.Image != null)
            {
                Clipboard.SetImage(pbCurrentPicture.Image);
            }
        }
        private void CurrentPicture_paste(Object s, EventArgs e)
        {
            if (Clipboard.GetImage() != null)
            {
                SetPicture(Clipboard.GetImage(), Image_Normal);
            }
        }

        private string ImageNameGenerate()
        {
            string sRet = null;
            string sTemp = null;
            int iTemp = 0;

            try
            {
                ImageInfo LastElement = ListOfImageInfo.Last();
                sTemp = string.Join("",LastElement.ImageName.Where(char.IsDigit));
                iTemp = int.Parse(sTemp);
            }
            catch { }
            
            iTemp += 1;
            sRet = "image_" + iTemp.ToString();

            return sRet;
        }
        private bool SetPicture(Image iImage, Size iSize)
        {
            bool bRet = true;

            pbCurrentPicture.Size = iSize;
            pbCurrentPicture.Image = iImage;
            pbCurrentPicture.Image = new Bitmap(pbCurrentPicture.Image, iSize);

            int x = (pbCurrentPicture.Parent.ClientSize.Width / 2) - (pbCurrentPicture.Width / 2);
            int y = (pbCurrentPicture.Parent.ClientSize.Height / 2) - (pbCurrentPicture.Height / 2);
            pbCurrentPicture.Location = new Point(x,y);
            pbCurrentPicture.Refresh();

            return bRet;
        }
        private bool SavePicture(Image iImage, string iImageName)
        {
            bool bRet = false;
            string sTempPath = ImageResourcePath + "\\" + iImageName;
            Bitmap bTempImage = new Bitmap(iImage);
            bTempImage.Save(sTempPath, ImageFormat.Png);
            return bRet;
        }
        private bool RemovePicture(string iImageName)
        {
            bool bRet = false;
            string sTempPath = ImageResourcePath + "\\" + iImageName;
            if (File.Exists(sTempPath))
            {
                try
                {
                    File.Delete(sTempPath);
                }
                catch { }
            }
            return bRet;
        }
        private Bitmap LoadPicture(string iImageName)
        {
            Bitmap ImageRet = null;

            string sTempPath = ImageResourcePath + "\\" + iImageName;
            if (File.Exists(sTempPath))
            {
                ImageRet = new Bitmap(Image.FromFile(sTempPath));
            }

            return ImageRet;
        }

        #endregion
        //==============================================================================
        // Operations -- SUB-FORM PROCESS
        //==============================================================================
        #region SUB-FORM_PROCESS

        #endregion
        //==============================================================================
        // Operations -- EVENT PROCESS
        //==============================================================================
        #region EVENT_PROCESS
        private void tsmiChangeResolution_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tempObject = sender as ToolStripMenuItem;
            tsmiSmall.Checked = false;
            tsmiMedium.Checked = false;
            tsmiNormal.Checked = false;

            if (tempObject == tsmiSmall)
            {
                tsmiSmall.Checked = true;
                SetPicture(pbCurrentPicture.Image, Image_Small);
            }
            else if (tempObject == tsmiMedium)
            {
                tsmiMedium.Checked = true;
                SetPicture(pbCurrentPicture.Image, Image_Medium);
            }
            else if (tempObject == tsmiNormal)
            {
                tsmiNormal.Checked = true;
                SetPicture(pbCurrentPicture.Image, Image_Normal);
            }
        }
        private void tsmiEditPicture_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tempObject = sender as ToolStripMenuItem;
            tsmiEditEnable.Checked = false;
            tsmiEditDisable.Checked = false;

            if (tempObject == tsmiEditEnable)
            {
                tsmiEditEnable.Checked = true;
                btAddImage.Enabled = true;
                btDeleteImage.Enabled = true;
                btClear.Enabled = true;
            }
            else if (tempObject == tsmiEditDisable)
            {
                tsmiEditDisable.Checked = true;
                btAddImage.Enabled = false;
                btDeleteImage.Enabled = false;
                btClear.Enabled = false;
            }
        }
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            pbCurrentPicture.Image = null;
            cbGroup.Text = "";
            cbDesc.Text = "";
            cbCont.Text = "";
        }
        private void btAddImage_Click(object sender, EventArgs e)
        {
            if (pbCurrentPicture.Image != null)
            {
                if (VerifyImageInfo(cbGroup.Text, cbDesc.Text, cbCont.Text))
                {
                    string sName = ImageNameGenerate();
                    SavePicture(pbCurrentPicture.Image, sName);
                    ImageManageXML.AddNewImage(sName, cbGroup.Text, cbDesc.Text, cbCont.Text);
                    UpdateImageResourceInfo();
                    sGroup = cbGroup.Text; sDesc = cbDesc.Text; sConte = cbCont.Text;
                    MessageBox.Show("Add done !");
                }
                else
                {
                    MessageBox.Show("Info invalid !");
                }
            }
        }
        private void btDeleteImage_Click(object sender, EventArgs e)
        {
            if (iImageIndexSelected < iTotalImageValid)
            {
                ImageInfo ImageSelect = ListOfImageInfo[iImageIndexSelected];
                RemovePicture(ImageSelect.ImageName);
                ImageManageXML.RemoveImage (ImageSelect.ImageName);
                UpdateImageResourceInfo();
                if (iImageIndexSelected > iTotalImageValid)
                    iImageIndexSelected = iTotalImageValid - 1;
            }
            
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btControlSelect_Handle(object sender, EventArgs e)
        {
            if ((sender as Button) == btPreviousImage)
            {
                if (iImageIndexSelected > 0)
                {
                    iImageIndexSelected--;
                    UpdateImageSelected(iImageIndexSelected);
                }
            }
            else if ((sender as Button) == btNextImage)
            {
                if (iImageIndexSelected < iTotalImageInGroupSelected)
                {
                    iImageIndexSelected++;
                    UpdateImageSelected(iImageIndexSelected);
                }
            }
        }

        private void cbImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iTempIxd = (sender as ComboBox).SelectedIndex;
            if ((sender as ComboBox) == cbGroup)
            {
                UpdateGroupSelected(iTempIxd);
            }
            else
            {
                if (iTempIxd < iTotalImageInGroupSelected) iImageIndexSelected = iTempIxd;
                UpdateImageSelected(iTempIxd);
            }
        }
        #endregion

    }
}

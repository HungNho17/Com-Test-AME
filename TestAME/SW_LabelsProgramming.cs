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

        Bitmap ImageCurrent = null;
        string ImageGroup = null;
        string ImageDesc = null;
        string ImageConte = null;

        string XMLFileName = "\\ImageManage.XML";
        P_XmlFileProcess ImageManageXML = null;
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
            UpdateRightContextManu();
            CheckImageResource();

            ImageManageXML = new P_XmlFileProcess(ImageResourcePath+ XMLFileName);
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
        private bool UpdateRightContextManu()
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
        private Bitmap LoadPicture(string iImageName)
        {
            Bitmap ImageRet = null;

            string sTempPath = ImageResourcePath + "\\" + iImageName;
            if (File.Exists(sTempPath))
            {
                ImageRet = (Bitmap) Image.FromFile(sTempPath);
            }

            return ImageRet;
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

        private void tsmiSmall_Click(object sender, EventArgs e)
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
        private void btClear_Click(object sender, EventArgs e)
        {
            Bitmap temp = LoadPicture("image_001");
            pbCurrentPicture.Image = temp;
        }

        private void btAddImage_Click(object sender, EventArgs e)
        {
            if (pbCurrentPicture.Image != null)
            {
                if (cbGroup.Text == "" || cbDesc.Text == "" || cbCont.Text == "")
                {
                    MessageBox.Show("Please give enough information in _Group, _Desc, _Conte !");
                }
                else
                {
                    SavePicture(pbCurrentPicture.Image, "image_001");
                    ImageManageXML.AddNewImage("image_001", cbGroup.Text, cbDesc.Text, cbCont.Text);
                    MessageBox.Show("Add done !");
                }
            }
        }

        private void btDeleteImage_Click(object sender, EventArgs e)
        {
            RemovePicture("image_001");
            ImageManageXML.RemoveImage ("image_001");
        }


        #endregion
    }
}

namespace TestAME
{
    partial class SW_LabelsProgramming
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbCurrentPicture = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.choseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditEnable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditDisable = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMedium = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btPreviousImage = new System.Windows.Forms.Button();
            this.btNextImage = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.cbDesc = new System.Windows.Forms.ComboBox();
            this.cbCont = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btClear = new System.Windows.Forms.Button();
            this.pnPicture = new System.Windows.Forms.Panel();
            this.btAddImage = new System.Windows.Forms.Button();
            this.btDeleteImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentPicture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnPicture.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCurrentPicture
            // 
            this.pbCurrentPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCurrentPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbCurrentPicture.Location = new System.Drawing.Point(23, 39);
            this.pbCurrentPicture.Name = "pbCurrentPicture";
            this.pbCurrentPicture.Size = new System.Drawing.Size(450, 90);
            this.pbCurrentPicture.TabIndex = 0;
            this.pbCurrentPicture.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.choseToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(544, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // choseToolStripMenuItem
            // 
            this.choseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.choseToolStripMenuItem.Name = "choseToolStripMenuItem";
            this.choseToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.choseToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newLabelToolStripMenuItem,
            this.pictureSizeToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // newLabelToolStripMenuItem
            // 
            this.newLabelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditEnable,
            this.tsmiEditDisable});
            this.newLabelToolStripMenuItem.Name = "newLabelToolStripMenuItem";
            this.newLabelToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.newLabelToolStripMenuItem.Text = "Edit Picture";
            // 
            // tsmiEditEnable
            // 
            this.tsmiEditEnable.CheckOnClick = true;
            this.tsmiEditEnable.Name = "tsmiEditEnable";
            this.tsmiEditEnable.Size = new System.Drawing.Size(112, 22);
            this.tsmiEditEnable.Text = "Enable";
            this.tsmiEditEnable.Click += new System.EventHandler(this.tsmiEditPicture_Click);
            // 
            // tsmiEditDisable
            // 
            this.tsmiEditDisable.Checked = true;
            this.tsmiEditDisable.CheckOnClick = true;
            this.tsmiEditDisable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiEditDisable.Name = "tsmiEditDisable";
            this.tsmiEditDisable.Size = new System.Drawing.Size(112, 22);
            this.tsmiEditDisable.Text = "Disable";
            this.tsmiEditDisable.Click += new System.EventHandler(this.tsmiEditPicture_Click);
            // 
            // pictureSizeToolStripMenuItem
            // 
            this.pictureSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSmall,
            this.tsmiMedium,
            this.tsmiNormal});
            this.pictureSizeToolStripMenuItem.Name = "pictureSizeToolStripMenuItem";
            this.pictureSizeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.pictureSizeToolStripMenuItem.Text = "Picture Size";
            // 
            // tsmiSmall
            // 
            this.tsmiSmall.CheckOnClick = true;
            this.tsmiSmall.Name = "tsmiSmall";
            this.tsmiSmall.Size = new System.Drawing.Size(119, 22);
            this.tsmiSmall.Text = "Small";
            this.tsmiSmall.Click += new System.EventHandler(this.tsmiChangeResolution_Click);
            // 
            // tsmiMedium
            // 
            this.tsmiMedium.CheckOnClick = true;
            this.tsmiMedium.Name = "tsmiMedium";
            this.tsmiMedium.Size = new System.Drawing.Size(119, 22);
            this.tsmiMedium.Text = "Medium";
            this.tsmiMedium.Click += new System.EventHandler(this.tsmiChangeResolution_Click);
            // 
            // tsmiNormal
            // 
            this.tsmiNormal.Checked = true;
            this.tsmiNormal.CheckOnClick = true;
            this.tsmiNormal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiNormal.Name = "tsmiNormal";
            this.tsmiNormal.Size = new System.Drawing.Size(119, 22);
            this.tsmiNormal.Text = "Normal";
            this.tsmiNormal.Click += new System.EventHandler(this.tsmiChangeResolution_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // btPreviousImage
            // 
            this.btPreviousImage.Location = new System.Drawing.Point(21, 311);
            this.btPreviousImage.Name = "btPreviousImage";
            this.btPreviousImage.Size = new System.Drawing.Size(75, 23);
            this.btPreviousImage.TabIndex = 2;
            this.btPreviousImage.Text = "Previous";
            this.btPreviousImage.UseVisualStyleBackColor = true;
            this.btPreviousImage.Click += new System.EventHandler(this.btControlSelect_Handle);
            // 
            // btNextImage
            // 
            this.btNextImage.Location = new System.Drawing.Point(102, 311);
            this.btNextImage.Name = "btNextImage";
            this.btNextImage.Size = new System.Drawing.Size(75, 23);
            this.btNextImage.TabIndex = 3;
            this.btNextImage.Text = "Next";
            this.btNextImage.UseVisualStyleBackColor = true;
            this.btNextImage.Click += new System.EventHandler(this.btControlSelect_Handle);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(446, 311);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "_Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "_Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "_Content";
            // 
            // cbGroup
            // 
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Location = new System.Drawing.Point(77, 9);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(326, 21);
            this.cbGroup.TabIndex = 8;
            this.cbGroup.SelectedIndexChanged += new System.EventHandler(this.cbImage_SelectedIndexChanged);
            // 
            // cbDesc
            // 
            this.cbDesc.FormattingEnabled = true;
            this.cbDesc.Location = new System.Drawing.Point(77, 35);
            this.cbDesc.Name = "cbDesc";
            this.cbDesc.Size = new System.Drawing.Size(326, 21);
            this.cbDesc.TabIndex = 9;
            this.cbDesc.SelectedIndexChanged += new System.EventHandler(this.cbImage_SelectedIndexChanged);
            // 
            // cbCont
            // 
            this.cbCont.FormattingEnabled = true;
            this.cbCont.Location = new System.Drawing.Point(77, 62);
            this.cbCont.Name = "cbCont";
            this.cbCont.Size = new System.Drawing.Size(326, 21);
            this.cbCont.TabIndex = 10;
            this.cbCont.SelectedIndexChanged += new System.EventHandler(this.cbImage_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btClear);
            this.panel1.Controls.Add(this.pnPicture);
            this.panel1.Controls.Add(this.btAddImage);
            this.panel1.Controls.Add(this.btDeleteImage);
            this.panel1.Controls.Add(this.cbCont);
            this.panel1.Controls.Add(this.cbDesc);
            this.panel1.Controls.Add(this.cbGroup);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 274);
            this.panel1.TabIndex = 11;
            // 
            // btClear
            // 
            this.btClear.Enabled = false;
            this.btClear.Location = new System.Drawing.Point(420, 62);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(90, 21);
            this.btClear.TabIndex = 12;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // pnPicture
            // 
            this.pnPicture.BackColor = System.Drawing.Color.White;
            this.pnPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPicture.Controls.Add(this.pbCurrentPicture);
            this.pnPicture.Location = new System.Drawing.Point(12, 96);
            this.pnPicture.Name = "pnPicture";
            this.pnPicture.Size = new System.Drawing.Size(498, 172);
            this.pnPicture.TabIndex = 13;
            // 
            // btAddImage
            // 
            this.btAddImage.Enabled = false;
            this.btAddImage.Location = new System.Drawing.Point(420, 8);
            this.btAddImage.Name = "btAddImage";
            this.btAddImage.Size = new System.Drawing.Size(90, 21);
            this.btAddImage.TabIndex = 12;
            this.btAddImage.Text = "Add";
            this.btAddImage.UseVisualStyleBackColor = true;
            this.btAddImage.Click += new System.EventHandler(this.btAddImage_Click);
            // 
            // btDeleteImage
            // 
            this.btDeleteImage.Enabled = false;
            this.btDeleteImage.Location = new System.Drawing.Point(420, 35);
            this.btDeleteImage.Name = "btDeleteImage";
            this.btDeleteImage.Size = new System.Drawing.Size(90, 21);
            this.btDeleteImage.TabIndex = 11;
            this.btDeleteImage.Text = "Delete";
            this.btDeleteImage.UseVisualStyleBackColor = true;
            this.btDeleteImage.Click += new System.EventHandler(this.btDeleteImage_Click);
            // 
            // SW_LabelsProgramming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 341);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btNextImage);
            this.Controls.Add(this.btPreviousImage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(560, 380);
            this.MinimumSize = new System.Drawing.Size(560, 380);
            this.Name = "SW_LabelsProgramming";
            this.ShowIcon = false;
            this.Text = "SAMPLE LABELS";
            this.Load += new System.EventHandler(this.SW_LabelsProgramming_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentPicture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnPicture.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCurrentPicture;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem choseToolStripMenuItem;
        private System.Windows.Forms.Button btPreviousImage;
        private System.Windows.Forms.Button btNextImage;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.ComboBox cbDesc;
        private System.Windows.Forms.ComboBox cbCont;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btAddImage;
        private System.Windows.Forms.Button btDeleteImage;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newLabelToolStripMenuItem;
        private System.Windows.Forms.Panel pnPicture;
        private System.Windows.Forms.ToolStripMenuItem pictureSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSmall;
        private System.Windows.Forms.ToolStripMenuItem tsmiMedium;
        private System.Windows.Forms.ToolStripMenuItem tsmiNormal;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditEnable;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditDisable;
    }
}
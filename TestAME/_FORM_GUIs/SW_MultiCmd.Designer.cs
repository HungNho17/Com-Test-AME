namespace TestAME
{
    partial class SW_MultiCmd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SW_MultiCmd));
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManual = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAutoRes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAutoNoRes = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiReset = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgvMain = new System.Windows.Forms.DataGridView();
            this.lbPathFile = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btPaused = new System.Windows.Forms.Button();
            this.mnsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsMain
            // 
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.actionToolStripMenuItem});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(693, 24);
            this.mnsMain.TabIndex = 0;
            this.mnsMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.tsmiLoad_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveAsToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiManual,
            this.toolStripSeparator3,
            this.tsmiAutoRes,
            this.tsmiAutoNoRes});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.settingToolStripMenuItem.Text = "Mode";
            // 
            // tsmiManual
            // 
            this.tsmiManual.Enabled = false;
            this.tsmiManual.Name = "tsmiManual";
            this.tsmiManual.Size = new System.Drawing.Size(195, 22);
            this.tsmiManual.Text = "Manual";
            this.tsmiManual.Click += new System.EventHandler(this.tsmiMenual_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(192, 6);
            // 
            // tsmiAutoRes
            // 
            this.tsmiAutoRes.Enabled = false;
            this.tsmiAutoRes.Name = "tsmiAutoRes";
            this.tsmiAutoRes.Size = new System.Drawing.Size(195, 22);
            this.tsmiAutoRes.Text = "Auto With Respond";
            this.tsmiAutoRes.Click += new System.EventHandler(this.tsmiAuto_Click);
            // 
            // tsmiAutoNoRes
            // 
            this.tsmiAutoNoRes.Enabled = false;
            this.tsmiAutoNoRes.Name = "tsmiAutoNoRes";
            this.tsmiAutoNoRes.Size = new System.Drawing.Size(195, 22);
            this.tsmiAutoNoRes.Text = "Auto Without Respond";
            this.tsmiAutoNoRes.Click += new System.EventHandler(this.tsmiAuto_Click);
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tsmiStart,
            this.tsmiStop,
            this.toolStripSeparator2,
            this.tsmiReset});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // tsmiStart
            // 
            this.tsmiStart.Enabled = false;
            this.tsmiStart.Name = "tsmiStart";
            this.tsmiStart.Size = new System.Drawing.Size(152, 22);
            this.tsmiStart.Text = "Start";
            this.tsmiStart.Click += new System.EventHandler(this.tsmiAutoControl_Click);
            // 
            // tsmiStop
            // 
            this.tsmiStop.Enabled = false;
            this.tsmiStop.Name = "tsmiStop";
            this.tsmiStop.Size = new System.Drawing.Size(152, 22);
            this.tsmiStop.Text = "Stop";
            this.tsmiStop.Click += new System.EventHandler(this.tsmiAutoControl_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // tsmiReset
            // 
            this.tsmiReset.Name = "tsmiReset";
            this.tsmiReset.Size = new System.Drawing.Size(152, 22);
            this.tsmiReset.Text = "Reset";
            this.tsmiReset.Click += new System.EventHandler(this.tsmiReset_Click);
            // 
            // dtgvMain
            // 
            this.dtgvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMain.Location = new System.Drawing.Point(0, 29);
            this.dtgvMain.Name = "dtgvMain";
            this.dtgvMain.ReadOnly = true;
            this.dtgvMain.RowHeadersVisible = false;
            this.dtgvMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvMain.Size = new System.Drawing.Size(693, 320);
            this.dtgvMain.TabIndex = 1;
            this.dtgvMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMain_CellContentClick);
            // 
            // lbPathFile
            // 
            this.lbPathFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPathFile.AutoSize = true;
            this.lbPathFile.Location = new System.Drawing.Point(-1, 355);
            this.lbPathFile.Name = "lbPathFile";
            this.lbPathFile.Size = new System.Drawing.Size(16, 13);
            this.lbPathFile.TabIndex = 4;
            this.lbPathFile.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = global::TestAME.Properties.Resources.Red;
            this.label2.Location = new System.Drawing.Point(471, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // btPaused
            // 
            this.btPaused.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btPaused.Location = new System.Drawing.Point(606, 1);
            this.btPaused.Name = "btPaused";
            this.btPaused.Size = new System.Drawing.Size(75, 23);
            this.btPaused.TabIndex = 5;
            this.btPaused.Text = "PAUSED";
            this.btPaused.UseVisualStyleBackColor = true;
            this.btPaused.Click += new System.EventHandler(this.btPaused_Click);
            // 
            // SW_MultiCmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 371);
            this.Controls.Add(this.btPaused);
            this.Controls.Add(this.lbPathFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgvMain);
            this.Controls.Add(this.mnsMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsMain;
            this.Name = "SW_MultiCmd";
            this.Text = "Multi Commands Support";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SW_MultiCmd_FormClosed);
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtgvMain;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiStart;
        private System.Windows.Forms.ToolStripMenuItem tsmiStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPathFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiReset;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutoNoRes;
        private System.Windows.Forms.ToolStripMenuItem tsmiManual;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutoRes;
        private System.Windows.Forms.Button btPaused;
    }
}
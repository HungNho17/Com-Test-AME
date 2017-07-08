namespace TestAME
{
    partial class MW_AmeTest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MW_AmeTest));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSimpleView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFullView = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sampleLabelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aMESupportTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTimeStamping = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIndexStamping = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setUpUserCMDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbCommunicate = new System.Windows.Forms.GroupBox();
            this.lbTempStatus = new System.Windows.Forms.Label();
            this.tbDataRecieve = new System.Windows.Forms.RichTextBox();
            this.btTempConnect = new System.Windows.Forms.Button();
            this.lbWrapText = new System.Windows.Forms.Label();
            this.btNewLineCo = new System.Windows.Forms.Button();
            this.btClearCo = new System.Windows.Forms.Button();
            this.btWrapTextCo = new System.Windows.Forms.Button();
            this.gbLocalCmd = new System.Windows.Forms.GroupBox();
            this.lbSendLF = new System.Windows.Forms.Label();
            this.btSend = new System.Windows.Forms.Button();
            this.btClearLo = new System.Windows.Forms.Button();
            this.btSendLFLo = new System.Windows.Forms.Button();
            this.tbDataSend = new System.Windows.Forms.TextBox();
            this.gbUserCmd = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btCmd0 = new System.Windows.Forms.Button();
            this.btCmd4 = new System.Windows.Forms.Button();
            this.btCmd5 = new System.Windows.Forms.Button();
            this.btCmd7 = new System.Windows.Forms.Button();
            this.btCmd3 = new System.Windows.Forms.Button();
            this.btCmd6 = new System.Windows.Forms.Button();
            this.btCmd2 = new System.Windows.Forms.Button();
            this.btCmd1 = new System.Windows.Forms.Button();
            this.lbNext = new System.Windows.Forms.Label();
            this.lbPrevious = new System.Windows.Forms.Label();
            this.lbCurrentUser = new System.Windows.Forms.Label();
            this.SPort = new System.IO.Ports.SerialPort(this.components);
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTime = new System.Windows.Forms.Label();
            this.pnTime = new System.Windows.Forms.Panel();
            this.gbSetUp = new System.Windows.Forms.GroupBox();
            this.BTSPort = new System.Windows.Forms.Button();
            this.BTSetupCmd = new System.Windows.Forms.Button();
            this.gbCapStatus = new System.Windows.Forms.GroupBox();
            this.lbSclr = new System.Windows.Forms.Label();
            this.lbNum = new System.Windows.Forms.Label();
            this.lbCap = new System.Windows.Forms.Label();
            this.gbCharSetStatus = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lvCharSet = new System.Windows.Forms.ListView();
            this.Char = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Decimal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbToLocalCMD = new System.Windows.Forms.Label();
            this.lbToCommunicate = new System.Windows.Forms.Label();
            this.btCharToLo = new System.Windows.Forms.Button();
            this.btCharToCo = new System.Windows.Forms.Button();
            this.gbConnectStatus = new System.Windows.Forms.GroupBox();
            this.lbDSRILow = new System.Windows.Forms.Label();
            this.lbDSRIHigh = new System.Windows.Forms.Label();
            this.lbDSRStatus = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbDTROLow = new System.Windows.Forms.Label();
            this.lbDTROHigh = new System.Windows.Forms.Label();
            this.btDTR = new System.Windows.Forms.Button();
            this.lbCTSOHigh = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbCTSOLow = new System.Windows.Forms.Label();
            this.lbCTSIHigh = new System.Windows.Forms.Label();
            this.lbCTSILow = new System.Windows.Forms.Label();
            this.lbCTSStatus = new System.Windows.Forms.Label();
            this.btCTS = new System.Windows.Forms.Button();
            this.lbShowLF = new System.Windows.Forms.Label();
            this.lbShowSpace = new System.Windows.Forms.Label();
            this.lbDisplayRCData = new System.Windows.Forms.Label();
            this.lbConnect = new System.Windows.Forms.Label();
            this.btConnectSP = new System.Windows.Forms.Button();
            this.btDisplayRCData = new System.Windows.Forms.Button();
            this.btShowSpace = new System.Windows.Forms.Button();
            this.btShowLF = new System.Windows.Forms.Button();
            this.clearAllSerialPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.gbCommunicate.SuspendLayout();
            this.gbLocalCmd.SuspendLayout();
            this.gbUserCmd.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnTime.SuspendLayout();
            this.gbSetUp.SuspendLayout();
            this.gbCapStatus.SuspendLayout();
            this.gbCharSetStatus.SuspendLayout();
            this.gbConnectStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tsmiView,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveLog_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.AME_APP_TEST_Close);
            // 
            // tsmiView
            // 
            this.tsmiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSimpleView,
            this.tsmiFullView});
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(44, 20);
            this.tsmiView.Text = "View";
            // 
            // tsmiSimpleView
            // 
            this.tsmiSimpleView.CheckOnClick = true;
            this.tsmiSimpleView.Name = "tsmiSimpleView";
            this.tsmiSimpleView.Size = new System.Drawing.Size(110, 22);
            this.tsmiSimpleView.Text = "Simple";
            this.tsmiSimpleView.Click += new System.EventHandler(this.simpleViewOption_Click);
            // 
            // tsmiFullView
            // 
            this.tsmiFullView.CheckOnClick = true;
            this.tsmiFullView.Name = "tsmiFullView";
            this.tsmiFullView.Size = new System.Drawing.Size(110, 22);
            this.tsmiFullView.Text = "Full";
            this.tsmiFullView.Click += new System.EventHandler(this.fullViewOption_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sampleLabelsToolStripMenuItem,
            this.aMESupportTestToolStripMenuItem,
            this.tsmiLogSetting,
            this.configurationToolStripMenuItem,
            this.clearAllSerialPortToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // sampleLabelsToolStripMenuItem
            // 
            this.sampleLabelsToolStripMenuItem.Name = "sampleLabelsToolStripMenuItem";
            this.sampleLabelsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.sampleLabelsToolStripMenuItem.Text = "Sample Labels";
            this.sampleLabelsToolStripMenuItem.Click += new System.EventHandler(this.SampleLabels_Load);
            // 
            // aMESupportTestToolStripMenuItem
            // 
            this.aMESupportTestToolStripMenuItem.Name = "aMESupportTestToolStripMenuItem";
            this.aMESupportTestToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.aMESupportTestToolStripMenuItem.Text = "Multi Commands";
            this.aMESupportTestToolStripMenuItem.Click += new System.EventHandler(this.AME_Test_Load);
            // 
            // tsmiLogSetting
            // 
            this.tsmiLogSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTimeStamping,
            this.tsmiIndexStamping});
            this.tsmiLogSetting.Name = "tsmiLogSetting";
            this.tsmiLogSetting.Size = new System.Drawing.Size(171, 22);
            this.tsmiLogSetting.Text = "Log Setting";
            // 
            // tsmiTimeStamping
            // 
            this.tsmiTimeStamping.CheckOnClick = true;
            this.tsmiTimeStamping.DoubleClickEnabled = true;
            this.tsmiTimeStamping.Name = "tsmiTimeStamping";
            this.tsmiTimeStamping.Size = new System.Drawing.Size(139, 22);
            this.tsmiTimeStamping.Text = "Time Stamp";
            this.tsmiTimeStamping.Click += new System.EventHandler(this.tsmiTimeStamping_Click);
            // 
            // tsmiIndexStamping
            // 
            this.tsmiIndexStamping.CheckOnClick = true;
            this.tsmiIndexStamping.Name = "tsmiIndexStamping";
            this.tsmiIndexStamping.Size = new System.Drawing.Size(139, 22);
            this.tsmiIndexStamping.Text = "Index Stamp";
            this.tsmiIndexStamping.Click += new System.EventHandler(this.indexStamping_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setUpUserCMDToolStripMenuItem,
            this.serialPortToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // setUpUserCMDToolStripMenuItem
            // 
            this.setUpUserCMDToolStripMenuItem.Name = "setUpUserCMDToolStripMenuItem";
            this.setUpUserCMDToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.setUpUserCMDToolStripMenuItem.Text = "User CMD";
            this.setUpUserCMDToolStripMenuItem.Click += new System.EventHandler(this.BTSetupCmd_Click);
            // 
            // serialPortToolStripMenuItem
            // 
            this.serialPortToolStripMenuItem.Name = "serialPortToolStripMenuItem";
            this.serialPortToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.serialPortToolStripMenuItem.Text = "Serial Port";
            this.serialPortToolStripMenuItem.Click += new System.EventHandler(this.BTSPort_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // gbCommunicate
            // 
            this.gbCommunicate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCommunicate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbCommunicate.Controls.Add(this.lbTempStatus);
            this.gbCommunicate.Controls.Add(this.tbDataRecieve);
            this.gbCommunicate.Controls.Add(this.btTempConnect);
            this.gbCommunicate.Controls.Add(this.lbWrapText);
            this.gbCommunicate.Controls.Add(this.btNewLineCo);
            this.gbCommunicate.Controls.Add(this.btClearCo);
            this.gbCommunicate.Controls.Add(this.btWrapTextCo);
            this.gbCommunicate.Location = new System.Drawing.Point(0, 40);
            this.gbCommunicate.Name = "gbCommunicate";
            this.gbCommunicate.Size = new System.Drawing.Size(574, 232);
            this.gbCommunicate.TabIndex = 1;
            this.gbCommunicate.TabStop = false;
            this.gbCommunicate.Text = "Communications (Recieved = Yellow, Transmitted = Green):";
            // 
            // lbTempStatus
            // 
            this.lbTempStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTempStatus.AutoSize = true;
            this.lbTempStatus.Image = ((System.Drawing.Image)(resources.GetObject("lbTempStatus.Image")));
            this.lbTempStatus.Location = new System.Drawing.Point(483, 119);
            this.lbTempStatus.Name = "lbTempStatus";
            this.lbTempStatus.Size = new System.Drawing.Size(16, 13);
            this.lbTempStatus.TabIndex = 29;
            this.lbTempStatus.Text = "   ";
            this.lbTempStatus.Visible = false;
            // 
            // tbDataRecieve
            // 
            this.tbDataRecieve.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDataRecieve.BackColor = System.Drawing.Color.Black;
            this.tbDataRecieve.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDataRecieve.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbDataRecieve.ForeColor = System.Drawing.Color.Lime;
            this.tbDataRecieve.Location = new System.Drawing.Point(12, 19);
            this.tbDataRecieve.Name = "tbDataRecieve";
            this.tbDataRecieve.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.tbDataRecieve.Size = new System.Drawing.Size(465, 198);
            this.tbDataRecieve.TabIndex = 11;
            this.tbDataRecieve.Text = "";
            this.tbDataRecieve.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WindowKeyDown_Event);
            this.tbDataRecieve.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WindowKeyPress_Event);
            this.tbDataRecieve.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WindowKeyUp_Event);
            // 
            // btTempConnect
            // 
            this.btTempConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btTempConnect.Location = new System.Drawing.Point(502, 115);
            this.btTempConnect.Name = "btTempConnect";
            this.btTempConnect.Size = new System.Drawing.Size(66, 20);
            this.btTempConnect.TabIndex = 28;
            this.btTempConnect.Text = "Serial Port";
            this.btTempConnect.UseVisualStyleBackColor = true;
            this.btTempConnect.Visible = false;
            this.btTempConnect.Click += new System.EventHandler(this.BTConnectStatus_Click);
            // 
            // lbWrapText
            // 
            this.lbWrapText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWrapText.AutoSize = true;
            this.lbWrapText.Image = ((System.Drawing.Image)(resources.GetObject("lbWrapText.Image")));
            this.lbWrapText.Location = new System.Drawing.Point(483, 145);
            this.lbWrapText.Name = "lbWrapText";
            this.lbWrapText.Size = new System.Drawing.Size(16, 13);
            this.lbWrapText.TabIndex = 10;
            this.lbWrapText.Text = "   ";
            // 
            // btNewLineCo
            // 
            this.btNewLineCo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btNewLineCo.Location = new System.Drawing.Point(486, 193);
            this.btNewLineCo.Name = "btNewLineCo";
            this.btNewLineCo.Size = new System.Drawing.Size(82, 20);
            this.btNewLineCo.TabIndex = 3;
            this.btNewLineCo.Text = "New Line";
            this.btNewLineCo.UseVisualStyleBackColor = true;
            this.btNewLineCo.Click += new System.EventHandler(this.BTControlUI_Click);
            // 
            // btClearCo
            // 
            this.btClearCo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClearCo.Location = new System.Drawing.Point(486, 167);
            this.btClearCo.Name = "btClearCo";
            this.btClearCo.Size = new System.Drawing.Size(82, 20);
            this.btClearCo.TabIndex = 2;
            this.btClearCo.Text = "Clear Text";
            this.btClearCo.UseVisualStyleBackColor = true;
            this.btClearCo.Click += new System.EventHandler(this.BTControlUI_Click);
            // 
            // btWrapTextCo
            // 
            this.btWrapTextCo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btWrapTextCo.Location = new System.Drawing.Point(502, 141);
            this.btWrapTextCo.Name = "btWrapTextCo";
            this.btWrapTextCo.Size = new System.Drawing.Size(66, 20);
            this.btWrapTextCo.TabIndex = 1;
            this.btWrapTextCo.Text = "Wrap Text";
            this.btWrapTextCo.UseVisualStyleBackColor = true;
            this.btWrapTextCo.Click += new System.EventHandler(this.BTControlUI_Click);
            // 
            // gbLocalCmd
            // 
            this.gbLocalCmd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLocalCmd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbLocalCmd.Controls.Add(this.lbSendLF);
            this.gbLocalCmd.Controls.Add(this.btSend);
            this.gbLocalCmd.Controls.Add(this.btClearLo);
            this.gbLocalCmd.Controls.Add(this.btSendLFLo);
            this.gbLocalCmd.Controls.Add(this.tbDataSend);
            this.gbLocalCmd.Location = new System.Drawing.Point(0, 278);
            this.gbLocalCmd.Name = "gbLocalCmd";
            this.gbLocalCmd.Size = new System.Drawing.Size(574, 115);
            this.gbLocalCmd.TabIndex = 2;
            this.gbLocalCmd.TabStop = false;
            this.gbLocalCmd.Text = "Local Command:";
            // 
            // lbSendLF
            // 
            this.lbSendLF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSendLF.AutoSize = true;
            this.lbSendLF.Image = ((System.Drawing.Image)(resources.GetObject("lbSendLF.Image")));
            this.lbSendLF.Location = new System.Drawing.Point(483, 37);
            this.lbSendLF.Name = "lbSendLF";
            this.lbSendLF.Size = new System.Drawing.Size(16, 13);
            this.lbSendLF.TabIndex = 11;
            this.lbSendLF.Text = "   ";
            // 
            // btSend
            // 
            this.btSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSend.Location = new System.Drawing.Point(486, 85);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(82, 20);
            this.btSend.TabIndex = 3;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // btClearLo
            // 
            this.btClearLo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClearLo.Location = new System.Drawing.Point(486, 59);
            this.btClearLo.Name = "btClearLo";
            this.btClearLo.Size = new System.Drawing.Size(82, 20);
            this.btClearLo.TabIndex = 2;
            this.btClearLo.Text = "Clear Text";
            this.btClearLo.UseVisualStyleBackColor = true;
            this.btClearLo.Click += new System.EventHandler(this.BTControlUI_Click);
            // 
            // btSendLFLo
            // 
            this.btSendLFLo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSendLFLo.Location = new System.Drawing.Point(502, 33);
            this.btSendLFLo.Name = "btSendLFLo";
            this.btSendLFLo.Size = new System.Drawing.Size(66, 20);
            this.btSendLFLo.TabIndex = 1;
            this.btSendLFLo.Text = "Send LF";
            this.btSendLFLo.UseVisualStyleBackColor = true;
            this.btSendLFLo.Click += new System.EventHandler(this.BTControlUI_Click);
            // 
            // tbDataSend
            // 
            this.tbDataSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDataSend.BackColor = System.Drawing.Color.Black;
            this.tbDataSend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDataSend.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDataSend.ForeColor = System.Drawing.Color.Lime;
            this.tbDataSend.Location = new System.Drawing.Point(12, 19);
            this.tbDataSend.Multiline = true;
            this.tbDataSend.Name = "tbDataSend";
            this.tbDataSend.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDataSend.Size = new System.Drawing.Size(465, 90);
            this.tbDataSend.TabIndex = 0;
            this.tbDataSend.WordWrap = false;
            // 
            // gbUserCmd
            // 
            this.gbUserCmd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUserCmd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbUserCmd.Controls.Add(this.tableLayoutPanel1);
            this.gbUserCmd.Controls.Add(this.lbNext);
            this.gbUserCmd.Controls.Add(this.lbPrevious);
            this.gbUserCmd.Controls.Add(this.lbCurrentUser);
            this.gbUserCmd.Location = new System.Drawing.Point(0, 405);
            this.gbUserCmd.Name = "gbUserCmd";
            this.gbUserCmd.Size = new System.Drawing.Size(574, 106);
            this.gbUserCmd.TabIndex = 3;
            this.gbUserCmd.TabStop = false;
            this.gbUserCmd.Text = "User Commands:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btCmd0, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btCmd4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btCmd5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btCmd7, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btCmd3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btCmd6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btCmd2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btCmd1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(556, 71);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // btCmd0
            // 
            this.btCmd0.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btCmd0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCmd0.Enabled = false;
            this.btCmd0.Location = new System.Drawing.Point(3, 6);
            this.btCmd0.Name = "btCmd0";
            this.btCmd0.Size = new System.Drawing.Size(133, 23);
            this.btCmd0.TabIndex = 0;
            this.btCmd0.Text = "undefine";
            this.btCmd0.UseVisualStyleBackColor = true;
            this.btCmd0.Click += new System.EventHandler(this.BTControlUserCmd_Click);
            // 
            // btCmd4
            // 
            this.btCmd4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btCmd4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCmd4.Enabled = false;
            this.btCmd4.Location = new System.Drawing.Point(3, 41);
            this.btCmd4.Name = "btCmd4";
            this.btCmd4.Size = new System.Drawing.Size(133, 23);
            this.btCmd4.TabIndex = 1;
            this.btCmd4.Text = "undefine";
            this.btCmd4.UseVisualStyleBackColor = true;
            this.btCmd4.Click += new System.EventHandler(this.BTControlUserCmd_Click);
            // 
            // btCmd5
            // 
            this.btCmd5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btCmd5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCmd5.Enabled = false;
            this.btCmd5.Location = new System.Drawing.Point(142, 41);
            this.btCmd5.Name = "btCmd5";
            this.btCmd5.Size = new System.Drawing.Size(133, 23);
            this.btCmd5.TabIndex = 3;
            this.btCmd5.Text = "undefine";
            this.btCmd5.UseVisualStyleBackColor = true;
            this.btCmd5.Click += new System.EventHandler(this.BTControlUserCmd_Click);
            // 
            // btCmd7
            // 
            this.btCmd7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btCmd7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCmd7.Enabled = false;
            this.btCmd7.Location = new System.Drawing.Point(420, 41);
            this.btCmd7.Name = "btCmd7";
            this.btCmd7.Size = new System.Drawing.Size(133, 23);
            this.btCmd7.TabIndex = 7;
            this.btCmd7.Text = "undefine";
            this.btCmd7.UseVisualStyleBackColor = true;
            this.btCmd7.Click += new System.EventHandler(this.BTControlUserCmd_Click);
            // 
            // btCmd3
            // 
            this.btCmd3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btCmd3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCmd3.Enabled = false;
            this.btCmd3.Location = new System.Drawing.Point(420, 6);
            this.btCmd3.Name = "btCmd3";
            this.btCmd3.Size = new System.Drawing.Size(133, 23);
            this.btCmd3.TabIndex = 6;
            this.btCmd3.Text = "undefine";
            this.btCmd3.UseVisualStyleBackColor = true;
            this.btCmd3.Click += new System.EventHandler(this.BTControlUserCmd_Click);
            // 
            // btCmd6
            // 
            this.btCmd6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btCmd6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCmd6.Enabled = false;
            this.btCmd6.Location = new System.Drawing.Point(281, 41);
            this.btCmd6.Name = "btCmd6";
            this.btCmd6.Size = new System.Drawing.Size(133, 23);
            this.btCmd6.TabIndex = 5;
            this.btCmd6.Text = "undefine";
            this.btCmd6.UseVisualStyleBackColor = true;
            this.btCmd6.Click += new System.EventHandler(this.BTControlUserCmd_Click);
            // 
            // btCmd2
            // 
            this.btCmd2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btCmd2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCmd2.Enabled = false;
            this.btCmd2.Location = new System.Drawing.Point(281, 6);
            this.btCmd2.Name = "btCmd2";
            this.btCmd2.Size = new System.Drawing.Size(133, 23);
            this.btCmd2.TabIndex = 4;
            this.btCmd2.Text = "undefine";
            this.btCmd2.UseVisualStyleBackColor = true;
            this.btCmd2.Click += new System.EventHandler(this.BTControlUserCmd_Click);
            // 
            // btCmd1
            // 
            this.btCmd1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btCmd1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCmd1.Enabled = false;
            this.btCmd1.Location = new System.Drawing.Point(142, 6);
            this.btCmd1.Name = "btCmd1";
            this.btCmd1.Size = new System.Drawing.Size(133, 23);
            this.btCmd1.TabIndex = 2;
            this.btCmd1.Text = "undefine";
            this.btCmd1.UseVisualStyleBackColor = true;
            this.btCmd1.Click += new System.EventHandler(this.BTControlUserCmd_Click);
            // 
            // lbNext
            // 
            this.lbNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNext.AutoSize = true;
            this.lbNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNext.Location = new System.Drawing.Point(547, 0);
            this.lbNext.Name = "lbNext";
            this.lbNext.Size = new System.Drawing.Size(21, 13);
            this.lbNext.TabIndex = 10;
            this.lbNext.Text = ">>";
            this.lbNext.Click += new System.EventHandler(this.MoveToNextUser);
            // 
            // lbPrevious
            // 
            this.lbPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPrevious.AutoSize = true;
            this.lbPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrevious.Location = new System.Drawing.Point(520, 0);
            this.lbPrevious.Name = "lbPrevious";
            this.lbPrevious.Size = new System.Drawing.Size(21, 13);
            this.lbPrevious.TabIndex = 9;
            this.lbPrevious.Text = "<<";
            this.lbPrevious.Click += new System.EventHandler(this.MoveToPreviousUser);
            // 
            // lbCurrentUser
            // 
            this.lbCurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCurrentUser.AutoSize = true;
            this.lbCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentUser.Location = new System.Drawing.Point(97, 0);
            this.lbCurrentUser.Name = "lbCurrentUser";
            this.lbCurrentUser.Size = new System.Drawing.Size(19, 13);
            this.lbCurrentUser.TabIndex = 8;
            this.lbCurrentUser.Text = "...";
            this.lbCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SPort
            // 
            this.SPort.ReadTimeout = 10;
            this.SPort.PinChanged += new System.IO.Ports.SerialPinChangedEventHandler(this.SPort_PinChanged);
            this.SPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SPort_DataReceived);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.TimeTracking_Tick);
            // 
            // lbTime
            // 
            this.lbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(76, 2);
            this.lbTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(103, 17);
            this.lbTime.TabIndex = 10;
            this.lbTime.Text = "... : ... : ... ...";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnTime
            // 
            this.pnTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTime.BackColor = System.Drawing.Color.MintCream;
            this.pnTime.Controls.Add(this.lbTime);
            this.pnTime.Location = new System.Drawing.Point(586, 1);
            this.pnTime.Margin = new System.Windows.Forms.Padding(2);
            this.pnTime.Name = "pnTime";
            this.pnTime.Size = new System.Drawing.Size(208, 22);
            this.pnTime.TabIndex = 11;
            // 
            // gbSetUp
            // 
            this.gbSetUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSetUp.Controls.Add(this.BTSPort);
            this.gbSetUp.Controls.Add(this.BTSetupCmd);
            this.gbSetUp.Location = new System.Drawing.Point(598, 442);
            this.gbSetUp.Name = "gbSetUp";
            this.gbSetUp.Size = new System.Drawing.Size(184, 43);
            this.gbSetUp.TabIndex = 14;
            this.gbSetUp.TabStop = false;
            // 
            // BTSPort
            // 
            this.BTSPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTSPort.Location = new System.Drawing.Point(94, 13);
            this.BTSPort.Name = "BTSPort";
            this.BTSPort.Size = new System.Drawing.Size(74, 23);
            this.BTSPort.TabIndex = 7;
            this.BTSPort.Text = "Serial Port";
            this.BTSPort.UseVisualStyleBackColor = true;
            this.BTSPort.Click += new System.EventHandler(this.BTSPort_Click);
            // 
            // BTSetupCmd
            // 
            this.BTSetupCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTSetupCmd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTSetupCmd.Location = new System.Drawing.Point(12, 13);
            this.BTSetupCmd.Name = "BTSetupCmd";
            this.BTSetupCmd.Size = new System.Drawing.Size(73, 23);
            this.BTSetupCmd.TabIndex = 6;
            this.BTSetupCmd.Text = "Set Up";
            this.BTSetupCmd.UseVisualStyleBackColor = true;
            this.BTSetupCmd.Click += new System.EventHandler(this.BTSetupCmd_Click);
            // 
            // gbCapStatus
            // 
            this.gbCapStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCapStatus.Controls.Add(this.lbSclr);
            this.gbCapStatus.Controls.Add(this.lbNum);
            this.gbCapStatus.Controls.Add(this.lbCap);
            this.gbCapStatus.Location = new System.Drawing.Point(598, 482);
            this.gbCapStatus.Name = "gbCapStatus";
            this.gbCapStatus.Size = new System.Drawing.Size(183, 29);
            this.gbCapStatus.TabIndex = 13;
            this.gbCapStatus.TabStop = false;
            // 
            // lbSclr
            // 
            this.lbSclr.AutoSize = true;
            this.lbSclr.Enabled = false;
            this.lbSclr.Location = new System.Drawing.Point(132, 10);
            this.lbSclr.Name = "lbSclr";
            this.lbSclr.Size = new System.Drawing.Size(35, 13);
            this.lbSclr.TabIndex = 2;
            this.lbSclr.Text = "SCLR";
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.Enabled = false;
            this.lbNum.Location = new System.Drawing.Point(91, 10);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(32, 13);
            this.lbNum.TabIndex = 1;
            this.lbNum.Text = "NUM";
            // 
            // lbCap
            // 
            this.lbCap.AutoSize = true;
            this.lbCap.Enabled = false;
            this.lbCap.Location = new System.Drawing.Point(54, 10);
            this.lbCap.Name = "lbCap";
            this.lbCap.Size = new System.Drawing.Size(28, 13);
            this.lbCap.TabIndex = 0;
            this.lbCap.Text = "CAP";
            // 
            // gbCharSetStatus
            // 
            this.gbCharSetStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCharSetStatus.Controls.Add(this.label4);
            this.gbCharSetStatus.Controls.Add(this.lvCharSet);
            this.gbCharSetStatus.Controls.Add(this.label3);
            this.gbCharSetStatus.Controls.Add(this.label2);
            this.gbCharSetStatus.Controls.Add(this.label1);
            this.gbCharSetStatus.Controls.Add(this.lbToLocalCMD);
            this.gbCharSetStatus.Controls.Add(this.lbToCommunicate);
            this.gbCharSetStatus.Controls.Add(this.btCharToLo);
            this.gbCharSetStatus.Controls.Add(this.btCharToCo);
            this.gbCharSetStatus.Location = new System.Drawing.Point(598, 274);
            this.gbCharSetStatus.Name = "gbCharSetStatus";
            this.gbCharSetStatus.Size = new System.Drawing.Size(184, 175);
            this.gbCharSetStatus.TabIndex = 12;
            this.gbCharSetStatus.TabStop = false;
            this.gbCharSetStatus.Text = "Charracter Set:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Double-click char to send";
            // 
            // lvCharSet
            // 
            this.lvCharSet.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvCharSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvCharSet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Char,
            this.Decimal,
            this.Hex});
            this.lvCharSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCharSet.FullRowSelect = true;
            this.lvCharSet.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvCharSet.Location = new System.Drawing.Point(22, 38);
            this.lvCharSet.MultiSelect = false;
            this.lvCharSet.Name = "lvCharSet";
            this.lvCharSet.RightToLeftLayout = true;
            this.lvCharSet.Size = new System.Drawing.Size(146, 59);
            this.lvCharSet.TabIndex = 17;
            this.lvCharSet.UseCompatibleStateImageBehavior = false;
            this.lvCharSet.View = System.Windows.Forms.View.Details;
            // 
            // Char
            // 
            this.Char.Text = "";
            this.Char.Width = 50;
            // 
            // Decimal
            // 
            this.Decimal.Text = "";
            this.Decimal.Width = 30;
            // 
            // Hex
            // 
            this.Hex.Text = "";
            this.Hex.Width = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Hex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Decimal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Char";
            // 
            // lbToLocalCMD
            // 
            this.lbToLocalCMD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbToLocalCMD.AutoSize = true;
            this.lbToLocalCMD.Image = ((System.Drawing.Image)(resources.GetObject("lbToLocalCMD.Image")));
            this.lbToLocalCMD.Location = new System.Drawing.Point(21, 150);
            this.lbToLocalCMD.Name = "lbToLocalCMD";
            this.lbToLocalCMD.Size = new System.Drawing.Size(16, 13);
            this.lbToLocalCMD.TabIndex = 13;
            this.lbToLocalCMD.Text = "   ";
            // 
            // lbToCommunicate
            // 
            this.lbToCommunicate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbToCommunicate.AutoSize = true;
            this.lbToCommunicate.Image = ((System.Drawing.Image)(resources.GetObject("lbToCommunicate.Image")));
            this.lbToCommunicate.Location = new System.Drawing.Point(21, 124);
            this.lbToCommunicate.Name = "lbToCommunicate";
            this.lbToCommunicate.Size = new System.Drawing.Size(16, 13);
            this.lbToCommunicate.TabIndex = 12;
            this.lbToCommunicate.Text = "   ";
            // 
            // btCharToLo
            // 
            this.btCharToLo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCharToLo.Location = new System.Drawing.Point(42, 144);
            this.btCharToLo.Name = "btCharToLo";
            this.btCharToLo.Size = new System.Drawing.Size(126, 20);
            this.btCharToLo.TabIndex = 2;
            this.btCharToLo.Text = "To Local Command";
            this.btCharToLo.UseVisualStyleBackColor = true;
            this.btCharToLo.Click += new System.EventHandler(this.BTControlUI_Click);
            // 
            // btCharToCo
            // 
            this.btCharToCo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCharToCo.Location = new System.Drawing.Point(42, 120);
            this.btCharToCo.Name = "btCharToCo";
            this.btCharToCo.Size = new System.Drawing.Size(126, 20);
            this.btCharToCo.TabIndex = 1;
            this.btCharToCo.Text = "To Communications";
            this.btCharToCo.UseVisualStyleBackColor = true;
            this.btCharToCo.Click += new System.EventHandler(this.BTControlUI_Click);
            // 
            // gbConnectStatus
            // 
            this.gbConnectStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbConnectStatus.Controls.Add(this.lbDSRILow);
            this.gbConnectStatus.Controls.Add(this.lbDSRIHigh);
            this.gbConnectStatus.Controls.Add(this.lbDSRStatus);
            this.gbConnectStatus.Controls.Add(this.label16);
            this.gbConnectStatus.Controls.Add(this.lbDTROLow);
            this.gbConnectStatus.Controls.Add(this.lbDTROHigh);
            this.gbConnectStatus.Controls.Add(this.btDTR);
            this.gbConnectStatus.Controls.Add(this.lbCTSOHigh);
            this.gbConnectStatus.Controls.Add(this.label15);
            this.gbConnectStatus.Controls.Add(this.lbCTSOLow);
            this.gbConnectStatus.Controls.Add(this.lbCTSIHigh);
            this.gbConnectStatus.Controls.Add(this.lbCTSILow);
            this.gbConnectStatus.Controls.Add(this.lbCTSStatus);
            this.gbConnectStatus.Controls.Add(this.btCTS);
            this.gbConnectStatus.Controls.Add(this.lbShowLF);
            this.gbConnectStatus.Controls.Add(this.lbShowSpace);
            this.gbConnectStatus.Controls.Add(this.lbDisplayRCData);
            this.gbConnectStatus.Controls.Add(this.lbConnect);
            this.gbConnectStatus.Controls.Add(this.btConnectSP);
            this.gbConnectStatus.Controls.Add(this.btDisplayRCData);
            this.gbConnectStatus.Controls.Add(this.btShowSpace);
            this.gbConnectStatus.Controls.Add(this.btShowLF);
            this.gbConnectStatus.Location = new System.Drawing.Point(598, 40);
            this.gbConnectStatus.Name = "gbConnectStatus";
            this.gbConnectStatus.Size = new System.Drawing.Size(184, 228);
            this.gbConnectStatus.TabIndex = 11;
            this.gbConnectStatus.TabStop = false;
            this.gbConnectStatus.Text = "Connection Status";
            // 
            // lbDSRILow
            // 
            this.lbDSRILow.AutoSize = true;
            this.lbDSRILow.Image = ((System.Drawing.Image)(resources.GetObject("lbDSRILow.Image")));
            this.lbDSRILow.Location = new System.Drawing.Point(21, 39);
            this.lbDSRILow.Name = "lbDSRILow";
            this.lbDSRILow.Size = new System.Drawing.Size(16, 13);
            this.lbDSRILow.TabIndex = 27;
            this.lbDSRILow.Text = "   ";
            // 
            // lbDSRIHigh
            // 
            this.lbDSRIHigh.AutoSize = true;
            this.lbDSRIHigh.Image = ((System.Drawing.Image)(resources.GetObject("lbDSRIHigh.Image")));
            this.lbDSRIHigh.Location = new System.Drawing.Point(36, 39);
            this.lbDSRIHigh.Name = "lbDSRIHigh";
            this.lbDSRIHigh.Size = new System.Drawing.Size(16, 13);
            this.lbDSRIHigh.TabIndex = 26;
            this.lbDSRIHigh.Text = "   ";
            // 
            // lbDSRStatus
            // 
            this.lbDSRStatus.AutoSize = true;
            this.lbDSRStatus.Location = new System.Drawing.Point(54, 39);
            this.lbDSRStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDSRStatus.Name = "lbDSRStatus";
            this.lbDSRStatus.Size = new System.Drawing.Size(86, 13);
            this.lbDSRStatus.TabIndex = 21;
            this.lbDSRStatus.Text = "DSR (Input H/S)";
            this.lbDSRStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 46);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(163, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "__________________________";
            // 
            // lbDTROLow
            // 
            this.lbDTROLow.AutoSize = true;
            this.lbDTROLow.Image = ((System.Drawing.Image)(resources.GetObject("lbDTROLow.Image")));
            this.lbDTROLow.Location = new System.Drawing.Point(21, 92);
            this.lbDTROLow.Name = "lbDTROLow";
            this.lbDTROLow.Size = new System.Drawing.Size(16, 13);
            this.lbDTROLow.TabIndex = 23;
            this.lbDTROLow.Text = "   ";
            // 
            // lbDTROHigh
            // 
            this.lbDTROHigh.AutoSize = true;
            this.lbDTROHigh.Image = ((System.Drawing.Image)(resources.GetObject("lbDTROHigh.Image")));
            this.lbDTROHigh.Location = new System.Drawing.Point(36, 92);
            this.lbDTROHigh.Name = "lbDTROHigh";
            this.lbDTROHigh.Size = new System.Drawing.Size(16, 13);
            this.lbDTROHigh.TabIndex = 24;
            this.lbDTROHigh.Text = "   ";
            // 
            // btDTR
            // 
            this.btDTR.Location = new System.Drawing.Point(52, 89);
            this.btDTR.Margin = new System.Windows.Forms.Padding(2);
            this.btDTR.Name = "btDTR";
            this.btDTR.Size = new System.Drawing.Size(116, 19);
            this.btDTR.TabIndex = 23;
            this.btDTR.Text = "DTR (Output H/S)";
            this.btDTR.UseVisualStyleBackColor = true;
            // 
            // lbCTSOHigh
            // 
            this.lbCTSOHigh.AutoSize = true;
            this.lbCTSOHigh.Image = ((System.Drawing.Image)(resources.GetObject("lbCTSOHigh.Image")));
            this.lbCTSOHigh.Location = new System.Drawing.Point(36, 68);
            this.lbCTSOHigh.Name = "lbCTSOHigh";
            this.lbCTSOHigh.Size = new System.Drawing.Size(16, 13);
            this.lbCTSOHigh.TabIndex = 22;
            this.lbCTSOHigh.Text = "   ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 101);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(163, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "__________________________";
            // 
            // lbCTSOLow
            // 
            this.lbCTSOLow.AutoSize = true;
            this.lbCTSOLow.Image = ((System.Drawing.Image)(resources.GetObject("lbCTSOLow.Image")));
            this.lbCTSOLow.Location = new System.Drawing.Point(21, 68);
            this.lbCTSOLow.Name = "lbCTSOLow";
            this.lbCTSOLow.Size = new System.Drawing.Size(16, 13);
            this.lbCTSOLow.TabIndex = 21;
            this.lbCTSOLow.Text = "   ";
            // 
            // lbCTSIHigh
            // 
            this.lbCTSIHigh.AutoSize = true;
            this.lbCTSIHigh.Image = ((System.Drawing.Image)(resources.GetObject("lbCTSIHigh.Image")));
            this.lbCTSIHigh.Location = new System.Drawing.Point(36, 25);
            this.lbCTSIHigh.Name = "lbCTSIHigh";
            this.lbCTSIHigh.Size = new System.Drawing.Size(16, 13);
            this.lbCTSIHigh.TabIndex = 18;
            this.lbCTSIHigh.Text = "   ";
            // 
            // lbCTSILow
            // 
            this.lbCTSILow.AutoSize = true;
            this.lbCTSILow.Image = ((System.Drawing.Image)(resources.GetObject("lbCTSILow.Image")));
            this.lbCTSILow.Location = new System.Drawing.Point(21, 25);
            this.lbCTSILow.Name = "lbCTSILow";
            this.lbCTSILow.Size = new System.Drawing.Size(16, 13);
            this.lbCTSILow.TabIndex = 17;
            this.lbCTSILow.Text = "   ";
            // 
            // lbCTSStatus
            // 
            this.lbCTSStatus.AutoSize = true;
            this.lbCTSStatus.Location = new System.Drawing.Point(56, 25);
            this.lbCTSStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCTSStatus.Name = "lbCTSStatus";
            this.lbCTSStatus.Size = new System.Drawing.Size(84, 13);
            this.lbCTSStatus.TabIndex = 16;
            this.lbCTSStatus.Text = "CTS (Input H/S)";
            this.lbCTSStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCTS
            // 
            this.btCTS.Location = new System.Drawing.Point(52, 66);
            this.btCTS.Margin = new System.Windows.Forms.Padding(2);
            this.btCTS.Name = "btCTS";
            this.btCTS.Size = new System.Drawing.Size(116, 19);
            this.btCTS.TabIndex = 14;
            this.btCTS.Text = "CTS (Output H/S)";
            this.btCTS.UseVisualStyleBackColor = true;
            // 
            // lbShowLF
            // 
            this.lbShowLF.AutoSize = true;
            this.lbShowLF.Image = ((System.Drawing.Image)(resources.GetObject("lbShowLF.Image")));
            this.lbShowLF.Location = new System.Drawing.Point(21, 199);
            this.lbShowLF.Name = "lbShowLF";
            this.lbShowLF.Size = new System.Drawing.Size(16, 13);
            this.lbShowLF.TabIndex = 12;
            this.lbShowLF.Text = "   ";
            // 
            // lbShowSpace
            // 
            this.lbShowSpace.AutoSize = true;
            this.lbShowSpace.Image = ((System.Drawing.Image)(resources.GetObject("lbShowSpace.Image")));
            this.lbShowSpace.Location = new System.Drawing.Point(21, 173);
            this.lbShowSpace.Name = "lbShowSpace";
            this.lbShowSpace.Size = new System.Drawing.Size(16, 13);
            this.lbShowSpace.TabIndex = 11;
            this.lbShowSpace.Text = "   ";
            // 
            // lbDisplayRCData
            // 
            this.lbDisplayRCData.AutoSize = true;
            this.lbDisplayRCData.Image = ((System.Drawing.Image)(resources.GetObject("lbDisplayRCData.Image")));
            this.lbDisplayRCData.Location = new System.Drawing.Point(21, 149);
            this.lbDisplayRCData.Name = "lbDisplayRCData";
            this.lbDisplayRCData.Size = new System.Drawing.Size(16, 13);
            this.lbDisplayRCData.TabIndex = 10;
            this.lbDisplayRCData.Text = "   ";
            // 
            // lbConnect
            // 
            this.lbConnect.AutoSize = true;
            this.lbConnect.Image = ((System.Drawing.Image)(resources.GetObject("lbConnect.Image")));
            this.lbConnect.Location = new System.Drawing.Point(21, 124);
            this.lbConnect.Name = "lbConnect";
            this.lbConnect.Size = new System.Drawing.Size(16, 13);
            this.lbConnect.TabIndex = 9;
            this.lbConnect.Text = "   ";
            // 
            // btConnectSP
            // 
            this.btConnectSP.Location = new System.Drawing.Point(42, 121);
            this.btConnectSP.Name = "btConnectSP";
            this.btConnectSP.Size = new System.Drawing.Size(126, 20);
            this.btConnectSP.TabIndex = 3;
            this.btConnectSP.Text = "Serial Port";
            this.btConnectSP.UseVisualStyleBackColor = true;
            this.btConnectSP.Click += new System.EventHandler(this.BTConnectStatus_Click);
            // 
            // btDisplayRCData
            // 
            this.btDisplayRCData.Location = new System.Drawing.Point(42, 145);
            this.btDisplayRCData.Name = "btDisplayRCData";
            this.btDisplayRCData.Size = new System.Drawing.Size(126, 20);
            this.btDisplayRCData.TabIndex = 2;
            this.btDisplayRCData.Text = "Display Received Data";
            this.btDisplayRCData.UseVisualStyleBackColor = true;
            this.btDisplayRCData.Click += new System.EventHandler(this.BTConnectStatus_Click);
            // 
            // btShowSpace
            // 
            this.btShowSpace.Location = new System.Drawing.Point(42, 170);
            this.btShowSpace.Name = "btShowSpace";
            this.btShowSpace.Size = new System.Drawing.Size(126, 20);
            this.btShowSpace.TabIndex = 1;
            this.btShowSpace.Text = "Show Space In { }";
            this.btShowSpace.UseVisualStyleBackColor = true;
            this.btShowSpace.Click += new System.EventHandler(this.BTConnectStatus_Click);
            // 
            // btShowLF
            // 
            this.btShowLF.Location = new System.Drawing.Point(42, 196);
            this.btShowLF.Name = "btShowLF";
            this.btShowLF.Size = new System.Drawing.Size(126, 20);
            this.btShowLF.TabIndex = 0;
            this.btShowLF.Text = "Show CR / LF in { }";
            this.btShowLF.UseVisualStyleBackColor = true;
            this.btShowLF.Click += new System.EventHandler(this.BTConnectStatus_Click);
            // 
            // clearAllSerialPortToolStripMenuItem
            // 
            this.clearAllSerialPortToolStripMenuItem.Name = "clearAllSerialPortToolStripMenuItem";
            this.clearAllSerialPortToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.clearAllSerialPortToolStripMenuItem.Text = "Clear All SerialPort";
            this.clearAllSerialPortToolStripMenuItem.Click += new System.EventHandler(this.clearAllSerialPortToolStripMenuItem_Click);
            // 
            // MW_AmeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 516);
            this.Controls.Add(this.gbSetUp);
            this.Controls.Add(this.gbCapStatus);
            this.Controls.Add(this.pnTime);
            this.Controls.Add(this.gbUserCmd);
            this.Controls.Add(this.gbCharSetStatus);
            this.Controls.Add(this.gbConnectStatus);
            this.Controls.Add(this.gbLocalCmd);
            this.Controls.Add(this.gbCommunicate);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(810, 555);
            this.Name = "MW_AmeTest";
            this.Text = "DATALOGIC R&D - Serial Com Test Support";
            this.Load += new System.EventHandler(this.AME_APP_TEST_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbCommunicate.ResumeLayout(false);
            this.gbCommunicate.PerformLayout();
            this.gbLocalCmd.ResumeLayout(false);
            this.gbLocalCmd.PerformLayout();
            this.gbUserCmd.ResumeLayout(false);
            this.gbUserCmd.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnTime.ResumeLayout(false);
            this.pnTime.PerformLayout();
            this.gbSetUp.ResumeLayout(false);
            this.gbCapStatus.ResumeLayout(false);
            this.gbCapStatus.PerformLayout();
            this.gbCharSetStatus.ResumeLayout(false);
            this.gbCharSetStatus.PerformLayout();
            this.gbConnectStatus.ResumeLayout(false);
            this.gbConnectStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbCommunicate;
        private System.Windows.Forms.Button btNewLineCo;
        private System.Windows.Forms.Button btClearCo;
        private System.Windows.Forms.Button btWrapTextCo;
        private System.Windows.Forms.GroupBox gbLocalCmd;
        private System.Windows.Forms.TextBox tbDataSend;
        private System.Windows.Forms.GroupBox gbUserCmd;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Button btClearLo;
        private System.Windows.Forms.Button btSendLFLo;
        private System.Windows.Forms.Button btCmd7;
        private System.Windows.Forms.Button btCmd3;
        private System.Windows.Forms.Button btCmd6;
        private System.Windows.Forms.Button btCmd2;
        private System.Windows.Forms.Button btCmd5;
        private System.Windows.Forms.Button btCmd1;
        private System.Windows.Forms.Button btCmd4;
        private System.Windows.Forms.Button btCmd0;
        private System.IO.Ports.SerialPort SPort;
        private System.Windows.Forms.Label lbWrapText;
        private System.Windows.Forms.Label lbSendLF;
        private System.Windows.Forms.RichTextBox tbDataRecieve;
        private System.Windows.Forms.Label lbNext;
        private System.Windows.Forms.Label lbPrevious;
        private System.Windows.Forms.Label lbCurrentUser;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Panel pnTime;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogSetting;
        private System.Windows.Forms.ToolStripMenuItem aMESupportTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiTimeStamping;
        private System.Windows.Forms.ToolStripMenuItem tsmiIndexStamping;
        private System.Windows.Forms.ToolStripMenuItem sampleLabelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiView;
        private System.Windows.Forms.ToolStripMenuItem tsmiSimpleView;
        private System.Windows.Forms.ToolStripMenuItem tsmiFullView;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setUpUserCMDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serialPortToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbSetUp;
        private System.Windows.Forms.Button BTSPort;
        private System.Windows.Forms.Button BTSetupCmd;
        private System.Windows.Forms.GroupBox gbCapStatus;
        private System.Windows.Forms.Label lbSclr;
        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.Label lbCap;
        private System.Windows.Forms.GroupBox gbCharSetStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvCharSet;
        private System.Windows.Forms.ColumnHeader Char;
        private System.Windows.Forms.ColumnHeader Decimal;
        private System.Windows.Forms.ColumnHeader Hex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbToLocalCMD;
        private System.Windows.Forms.Label lbToCommunicate;
        private System.Windows.Forms.Button btCharToLo;
        private System.Windows.Forms.Button btCharToCo;
        private System.Windows.Forms.GroupBox gbConnectStatus;
        private System.Windows.Forms.Label lbDSRILow;
        private System.Windows.Forms.Label lbDSRIHigh;
        private System.Windows.Forms.Label lbDSRStatus;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbDTROLow;
        private System.Windows.Forms.Label lbDTROHigh;
        private System.Windows.Forms.Button btDTR;
        private System.Windows.Forms.Label lbCTSOHigh;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbCTSOLow;
        private System.Windows.Forms.Label lbCTSIHigh;
        private System.Windows.Forms.Label lbCTSILow;
        private System.Windows.Forms.Label lbCTSStatus;
        private System.Windows.Forms.Button btCTS;
        private System.Windows.Forms.Label lbShowLF;
        private System.Windows.Forms.Label lbShowSpace;
        private System.Windows.Forms.Label lbDisplayRCData;
        private System.Windows.Forms.Label lbConnect;
        private System.Windows.Forms.Button btConnectSP;
        private System.Windows.Forms.Button btDisplayRCData;
        private System.Windows.Forms.Button btShowSpace;
        private System.Windows.Forms.Button btShowLF;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbTempStatus;
        private System.Windows.Forms.Button btTempConnect;
        private System.Windows.Forms.ToolStripMenuItem clearAllSerialPortToolStripMenuItem;
    }
}


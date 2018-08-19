namespace TestAME
{
    partial class SW_AME_Test
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
            this.btLoadProcess = new System.Windows.Forms.Button();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btFileBrowser = new System.Windows.Forms.Button();
            this.gbCommonInfo = new System.Windows.Forms.GroupBox();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.lbTotalCmd = new System.Windows.Forms.Label();
            this.lbFileStatus = new System.Windows.Forms.Label();
            this.lbSystemStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotalCmd1 = new System.Windows.Forms.Label();
            this.lbFileStatus1 = new System.Windows.Forms.Label();
            this.gbManualMode = new System.Windows.Forms.GroupBox();
            this.lbManualStatus = new System.Windows.Forms.Label();
            this.btSend = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btPrevious = new System.Windows.Forms.Button();
            this.gbAutoMode = new System.Windows.Forms.GroupBox();
            this.cbLoopTest = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbAction = new System.Windows.Forms.GroupBox();
            this.rbStop = new System.Windows.Forms.RadioButton();
            this.rbPause = new System.Windows.Forms.RadioButton();
            this.rbDoNothing = new System.Windows.Forms.RadioButton();
            this.gbMethode = new System.Windows.Forms.GroupBox();
            this.rbCompareResp = new System.Windows.Forms.RadioButton();
            this.rbYesNo = new System.Windows.Forms.RadioButton();
            this.rbDontVerify = new System.Windows.Forms.RadioButton();
            this.lbAutoStatus = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btPause = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.gbCurrentCmdStatus = new System.Windows.Forms.GroupBox();
            this.cbCurrentNumber = new System.Windows.Forms.ComboBox();
            this.cbCurrentCmd = new System.Windows.Forms.ComboBox();
            this.cbCurrentDesc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Timer_WaitRespond = new System.Windows.Forms.Timer(this.components);
            this.gbCommonInfo.SuspendLayout();
            this.gbManualMode.SuspendLayout();
            this.gbAutoMode.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbAction.SuspendLayout();
            this.gbMethode.SuspendLayout();
            this.gbCurrentCmdStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLoadProcess
            // 
            this.btLoadProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoadProcess.Location = new System.Drawing.Point(4, 18);
            this.btLoadProcess.Margin = new System.Windows.Forms.Padding(2);
            this.btLoadProcess.Name = "btLoadProcess";
            this.btLoadProcess.Size = new System.Drawing.Size(55, 20);
            this.btLoadProcess.TabIndex = 0;
            this.btLoadProcess.Text = "LOAD";
            this.btLoadProcess.UseVisualStyleBackColor = true;
            this.btLoadProcess.Click += new System.EventHandler(this.btLoadProcess_Click);
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(66, 19);
            this.tbFilePath.Margin = new System.Windows.Forms.Padding(2);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(240, 20);
            this.tbFilePath.TabIndex = 1;
            // 
            // btFileBrowser
            // 
            this.btFileBrowser.Location = new System.Drawing.Point(310, 19);
            this.btFileBrowser.Margin = new System.Windows.Forms.Padding(2);
            this.btFileBrowser.Name = "btFileBrowser";
            this.btFileBrowser.Size = new System.Drawing.Size(55, 20);
            this.btFileBrowser.TabIndex = 2;
            this.btFileBrowser.Text = "...";
            this.btFileBrowser.UseVisualStyleBackColor = true;
            this.btFileBrowser.Click += new System.EventHandler(this.btFileBrowser_Click);
            // 
            // gbCommonInfo
            // 
            this.gbCommonInfo.Controls.Add(this.rbManual);
            this.gbCommonInfo.Controls.Add(this.rbAuto);
            this.gbCommonInfo.Controls.Add(this.lbTotalCmd);
            this.gbCommonInfo.Controls.Add(this.lbFileStatus);
            this.gbCommonInfo.Controls.Add(this.lbSystemStatus);
            this.gbCommonInfo.Controls.Add(this.label3);
            this.gbCommonInfo.Controls.Add(this.lbTotalCmd1);
            this.gbCommonInfo.Controls.Add(this.lbFileStatus1);
            this.gbCommonInfo.Controls.Add(this.btFileBrowser);
            this.gbCommonInfo.Controls.Add(this.tbFilePath);
            this.gbCommonInfo.Controls.Add(this.btLoadProcess);
            this.gbCommonInfo.Enabled = false;
            this.gbCommonInfo.Location = new System.Drawing.Point(5, 22);
            this.gbCommonInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gbCommonInfo.Name = "gbCommonInfo";
            this.gbCommonInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gbCommonInfo.Size = new System.Drawing.Size(373, 122);
            this.gbCommonInfo.TabIndex = 3;
            this.gbCommonInfo.TabStop = false;
            this.gbCommonInfo.Text = "Common Information";
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Location = new System.Drawing.Point(246, 94);
            this.rbManual.Margin = new System.Windows.Forms.Padding(2);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(60, 17);
            this.rbManual.TabIndex = 8;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
            this.rbManual.CheckedChanged += new System.EventHandler(this.TestMode_CheckedChanged);
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Location = new System.Drawing.Point(318, 94);
            this.rbAuto.Margin = new System.Windows.Forms.Padding(2);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(47, 17);
            this.rbAuto.TabIndex = 7;
            this.rbAuto.TabStop = true;
            this.rbAuto.Text = "Auto";
            this.rbAuto.UseVisualStyleBackColor = true;
            this.rbAuto.CheckedChanged += new System.EventHandler(this.TestMode_CheckedChanged);
            // 
            // lbTotalCmd
            // 
            this.lbTotalCmd.AutoSize = true;
            this.lbTotalCmd.Location = new System.Drawing.Point(122, 78);
            this.lbTotalCmd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalCmd.Name = "lbTotalCmd";
            this.lbTotalCmd.Size = new System.Drawing.Size(16, 13);
            this.lbTotalCmd.TabIndex = 8;
            this.lbTotalCmd.Text = "...";
            // 
            // lbFileStatus
            // 
            this.lbFileStatus.AutoSize = true;
            this.lbFileStatus.Location = new System.Drawing.Point(122, 62);
            this.lbFileStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFileStatus.Name = "lbFileStatus";
            this.lbFileStatus.Size = new System.Drawing.Size(16, 13);
            this.lbFileStatus.TabIndex = 7;
            this.lbFileStatus.Text = "...";
            // 
            // lbSystemStatus
            // 
            this.lbSystemStatus.AutoSize = true;
            this.lbSystemStatus.Location = new System.Drawing.Point(122, 46);
            this.lbSystemStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSystemStatus.Name = "lbSystemStatus";
            this.lbSystemStatus.Size = new System.Drawing.Size(16, 13);
            this.lbSystemStatus.TabIndex = 6;
            this.lbSystemStatus.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "- System status:";
            // 
            // lbTotalCmd1
            // 
            this.lbTotalCmd1.AutoSize = true;
            this.lbTotalCmd1.Location = new System.Drawing.Point(13, 78);
            this.lbTotalCmd1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalCmd1.Name = "lbTotalCmd1";
            this.lbTotalCmd1.Size = new System.Drawing.Size(97, 13);
            this.lbTotalCmd1.TabIndex = 4;
            this.lbTotalCmd1.Text = "- Total commands: ";
            // 
            // lbFileStatus1
            // 
            this.lbFileStatus1.AutoSize = true;
            this.lbFileStatus1.Location = new System.Drawing.Point(13, 62);
            this.lbFileStatus1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFileStatus1.Name = "lbFileStatus1";
            this.lbFileStatus1.Size = new System.Drawing.Size(65, 13);
            this.lbFileStatus1.TabIndex = 3;
            this.lbFileStatus1.Text = "- File Status:";
            // 
            // gbManualMode
            // 
            this.gbManualMode.Controls.Add(this.lbManualStatus);
            this.gbManualMode.Controls.Add(this.btSend);
            this.gbManualMode.Controls.Add(this.btNext);
            this.gbManualMode.Controls.Add(this.btPrevious);
            this.gbManualMode.Enabled = false;
            this.gbManualMode.Location = new System.Drawing.Point(5, 261);
            this.gbManualMode.Margin = new System.Windows.Forms.Padding(2);
            this.gbManualMode.Name = "gbManualMode";
            this.gbManualMode.Padding = new System.Windows.Forms.Padding(2);
            this.gbManualMode.Size = new System.Drawing.Size(373, 46);
            this.gbManualMode.TabIndex = 4;
            this.gbManualMode.TabStop = false;
            this.gbManualMode.Text = "Manual Test Mode";
            // 
            // lbManualStatus
            // 
            this.lbManualStatus.AutoSize = true;
            this.lbManualStatus.Image = global::TestAME.Properties.Resources.D_green;
            this.lbManualStatus.Location = new System.Drawing.Point(5, 21);
            this.lbManualStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbManualStatus.Name = "lbManualStatus";
            this.lbManualStatus.Size = new System.Drawing.Size(13, 13);
            this.lbManualStatus.TabIndex = 9;
            this.lbManualStatus.Text = "  ";
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(300, 17);
            this.btSend.Margin = new System.Windows.Forms.Padding(2);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(65, 20);
            this.btSend.TabIndex = 2;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btControlManual_Handle);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(206, 17);
            this.btNext.Margin = new System.Windows.Forms.Padding(2);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(65, 20);
            this.btNext.TabIndex = 1;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btControlManual_Handle);
            // 
            // btPrevious
            // 
            this.btPrevious.Location = new System.Drawing.Point(112, 17);
            this.btPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btPrevious.Name = "btPrevious";
            this.btPrevious.Size = new System.Drawing.Size(65, 20);
            this.btPrevious.TabIndex = 0;
            this.btPrevious.Text = "Previous";
            this.btPrevious.UseVisualStyleBackColor = true;
            this.btPrevious.Click += new System.EventHandler(this.btControlManual_Handle);
            // 
            // gbAutoMode
            // 
            this.gbAutoMode.Controls.Add(this.cbLoopTest);
            this.gbAutoMode.Controls.Add(this.groupBox1);
            this.gbAutoMode.Controls.Add(this.lbAutoStatus);
            this.gbAutoMode.Controls.Add(this.btStart);
            this.gbAutoMode.Controls.Add(this.btStop);
            this.gbAutoMode.Controls.Add(this.btPause);
            this.gbAutoMode.Enabled = false;
            this.gbAutoMode.Location = new System.Drawing.Point(5, 311);
            this.gbAutoMode.Margin = new System.Windows.Forms.Padding(2);
            this.gbAutoMode.Name = "gbAutoMode";
            this.gbAutoMode.Padding = new System.Windows.Forms.Padding(2);
            this.gbAutoMode.Size = new System.Drawing.Size(373, 169);
            this.gbAutoMode.TabIndex = 5;
            this.gbAutoMode.TabStop = false;
            this.gbAutoMode.Text = "Auto Test Mode";
            // 
            // cbLoopTest
            // 
            this.cbLoopTest.AutoSize = true;
            this.cbLoopTest.Location = new System.Drawing.Point(33, 22);
            this.cbLoopTest.Name = "cbLoopTest";
            this.cbLoopTest.Size = new System.Drawing.Size(74, 17);
            this.cbLoopTest.TabIndex = 11;
            this.cbLoopTest.Text = "Loop Test";
            this.cbLoopTest.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbAction);
            this.groupBox1.Controls.Add(this.gbMethode);
            this.groupBox1.Location = new System.Drawing.Point(8, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 110);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verify Respond";
            // 
            // gbAction
            // 
            this.gbAction.Controls.Add(this.rbStop);
            this.gbAction.Controls.Add(this.rbPause);
            this.gbAction.Controls.Add(this.rbDoNothing);
            this.gbAction.Location = new System.Drawing.Point(189, 19);
            this.gbAction.Name = "gbAction";
            this.gbAction.Size = new System.Drawing.Size(161, 82);
            this.gbAction.TabIndex = 1;
            this.gbAction.TabStop = false;
            this.gbAction.Text = "Action On Fail";
            // 
            // rbStop
            // 
            this.rbStop.AutoSize = true;
            this.rbStop.Location = new System.Drawing.Point(17, 62);
            this.rbStop.Name = "rbStop";
            this.rbStop.Size = new System.Drawing.Size(47, 17);
            this.rbStop.TabIndex = 2;
            this.rbStop.TabStop = true;
            this.rbStop.Text = "Stop";
            this.rbStop.UseVisualStyleBackColor = true;
            // 
            // rbPause
            // 
            this.rbPause.AutoSize = true;
            this.rbPause.Location = new System.Drawing.Point(17, 39);
            this.rbPause.Name = "rbPause";
            this.rbPause.Size = new System.Drawing.Size(55, 17);
            this.rbPause.TabIndex = 1;
            this.rbPause.TabStop = true;
            this.rbPause.Text = "Pause";
            this.rbPause.UseVisualStyleBackColor = true;
            // 
            // rbDoNothing
            // 
            this.rbDoNothing.AutoSize = true;
            this.rbDoNothing.Location = new System.Drawing.Point(17, 16);
            this.rbDoNothing.Name = "rbDoNothing";
            this.rbDoNothing.Size = new System.Drawing.Size(77, 17);
            this.rbDoNothing.TabIndex = 0;
            this.rbDoNothing.TabStop = true;
            this.rbDoNothing.Text = "Do nothing";
            this.rbDoNothing.UseVisualStyleBackColor = true;
            // 
            // gbMethode
            // 
            this.gbMethode.Controls.Add(this.rbCompareResp);
            this.gbMethode.Controls.Add(this.rbYesNo);
            this.gbMethode.Controls.Add(this.rbDontVerify);
            this.gbMethode.Location = new System.Drawing.Point(8, 19);
            this.gbMethode.Name = "gbMethode";
            this.gbMethode.Size = new System.Drawing.Size(175, 82);
            this.gbMethode.TabIndex = 0;
            this.gbMethode.TabStop = false;
            this.gbMethode.Text = "Methode";
            // 
            // rbCompareResp
            // 
            this.rbCompareResp.AutoSize = true;
            this.rbCompareResp.Location = new System.Drawing.Point(9, 62);
            this.rbCompareResp.Name = "rbCompareResp";
            this.rbCompareResp.Size = new System.Drawing.Size(113, 17);
            this.rbCompareResp.TabIndex = 2;
            this.rbCompareResp.TabStop = true;
            this.rbCompareResp.Text = "Compare Respond";
            this.rbCompareResp.UseVisualStyleBackColor = true;
            // 
            // rbYesNo
            // 
            this.rbYesNo.AutoSize = true;
            this.rbYesNo.Location = new System.Drawing.Point(9, 39);
            this.rbYesNo.Name = "rbYesNo";
            this.rbYesNo.Size = new System.Drawing.Size(68, 17);
            this.rbYesNo.TabIndex = 1;
            this.rbYesNo.TabStop = true;
            this.rbYesNo.Text = "Yes / No";
            this.rbYesNo.UseVisualStyleBackColor = true;
            // 
            // rbDontVerify
            // 
            this.rbDontVerify.AutoSize = true;
            this.rbDontVerify.Location = new System.Drawing.Point(9, 16);
            this.rbDontVerify.Name = "rbDontVerify";
            this.rbDontVerify.Size = new System.Drawing.Size(85, 17);
            this.rbDontVerify.TabIndex = 0;
            this.rbDontVerify.TabStop = true;
            this.rbDontVerify.Text = "Do not verify";
            this.rbDontVerify.UseVisualStyleBackColor = true;
            // 
            // lbAutoStatus
            // 
            this.lbAutoStatus.AutoSize = true;
            this.lbAutoStatus.Image = global::TestAME.Properties.Resources.D_green;
            this.lbAutoStatus.Location = new System.Drawing.Point(4, 23);
            this.lbAutoStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAutoStatus.Name = "lbAutoStatus";
            this.lbAutoStatus.Size = new System.Drawing.Size(13, 13);
            this.lbAutoStatus.TabIndex = 8;
            this.lbAutoStatus.Text = "  ";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(112, 19);
            this.btStart.Margin = new System.Windows.Forms.Padding(2);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(65, 20);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btControlAuto_Handle);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(300, 19);
            this.btStop.Margin = new System.Windows.Forms.Padding(2);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(65, 20);
            this.btStop.TabIndex = 1;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btControlAuto_Handle);
            // 
            // btPause
            // 
            this.btPause.Location = new System.Drawing.Point(206, 19);
            this.btPause.Margin = new System.Windows.Forms.Padding(2);
            this.btPause.Name = "btPause";
            this.btPause.Size = new System.Drawing.Size(65, 20);
            this.btPause.TabIndex = 0;
            this.btPause.Text = "Pause";
            this.btPause.UseVisualStyleBackColor = true;
            this.btPause.Click += new System.EventHandler(this.btControlAuto_Handle);
            // 
            // btReset
            // 
            this.btReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btReset.Location = new System.Drawing.Point(79, 485);
            this.btReset.Margin = new System.Windows.Forms.Padding(2);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(65, 20);
            this.btReset.TabIndex = 16;
            this.btReset.Text = "RESET";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btClose.Location = new System.Drawing.Point(305, 485);
            this.btClose.Margin = new System.Windows.Forms.Padding(2);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(65, 20);
            this.btClose.TabIndex = 18;
            this.btClose.Text = "CLOSE";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // gbCurrentCmdStatus
            // 
            this.gbCurrentCmdStatus.Controls.Add(this.cbCurrentNumber);
            this.gbCurrentCmdStatus.Controls.Add(this.cbCurrentCmd);
            this.gbCurrentCmdStatus.Controls.Add(this.cbCurrentDesc);
            this.gbCurrentCmdStatus.Controls.Add(this.label5);
            this.gbCurrentCmdStatus.Controls.Add(this.label2);
            this.gbCurrentCmdStatus.Controls.Add(this.label1);
            this.gbCurrentCmdStatus.Location = new System.Drawing.Point(5, 149);
            this.gbCurrentCmdStatus.Name = "gbCurrentCmdStatus";
            this.gbCurrentCmdStatus.Size = new System.Drawing.Size(373, 107);
            this.gbCurrentCmdStatus.TabIndex = 19;
            this.gbCurrentCmdStatus.TabStop = false;
            this.gbCurrentCmdStatus.Text = "Current Command Status";
            // 
            // cbCurrentNumber
            // 
            this.cbCurrentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCurrentNumber.FormattingEnabled = true;
            this.cbCurrentNumber.Location = new System.Drawing.Point(66, 19);
            this.cbCurrentNumber.Name = "cbCurrentNumber";
            this.cbCurrentNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbCurrentNumber.Size = new System.Drawing.Size(144, 21);
            this.cbCurrentNumber.TabIndex = 20;
            this.cbCurrentNumber.SelectedIndexChanged += new System.EventHandler(this.cbCurrentCmd_SelectedIndexChanged);
            // 
            // cbCurrentCmd
            // 
            this.cbCurrentCmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCurrentCmd.ForeColor = System.Drawing.Color.Blue;
            this.cbCurrentCmd.FormattingEnabled = true;
            this.cbCurrentCmd.Location = new System.Drawing.Point(66, 75);
            this.cbCurrentCmd.Name = "cbCurrentCmd";
            this.cbCurrentCmd.Size = new System.Drawing.Size(299, 21);
            this.cbCurrentCmd.TabIndex = 19;
            this.cbCurrentCmd.SelectedIndexChanged += new System.EventHandler(this.cbCurrentCmd_SelectedIndexChanged);
            // 
            // cbCurrentDesc
            // 
            this.cbCurrentDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCurrentDesc.ForeColor = System.Drawing.Color.Red;
            this.cbCurrentDesc.FormattingEnabled = true;
            this.cbCurrentDesc.Location = new System.Drawing.Point(66, 47);
            this.cbCurrentDesc.Name = "cbCurrentDesc";
            this.cbCurrentDesc.Size = new System.Drawing.Size(299, 21);
            this.cbCurrentDesc.TabIndex = 18;
            this.cbCurrentDesc.SelectedIndexChanged += new System.EventHandler(this.cbCurrentCmd_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "_Cmd:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "_Desc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "_Number:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(9, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 20);
            this.button1.TabIndex = 20;
            this.button1.Text = "HELP";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Timer
            // 
            this.Timer.Interval = 300;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Timer_WaitRespond
            // 
            this.Timer_WaitRespond.Tick += new System.EventHandler(this.Timer_WaitRespond_Tick);
            // 
            // SW_AME_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 516);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbCurrentCmdStatus);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.gbAutoMode);
            this.Controls.Add(this.gbManualMode);
            this.Controls.Add(this.gbCommonInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(400, 4000);
            this.MinimumSize = new System.Drawing.Size(400, 555);
            this.Name = "SW_AME_Test";
            this.ShowIcon = false;
            this.Text = "List Commands Support Test";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SW_AME_Test_FormClosed);
            this.Load += new System.EventHandler(this.SW_AME_Test_Load);
            this.gbCommonInfo.ResumeLayout(false);
            this.gbCommonInfo.PerformLayout();
            this.gbManualMode.ResumeLayout(false);
            this.gbManualMode.PerformLayout();
            this.gbAutoMode.ResumeLayout(false);
            this.gbAutoMode.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbAction.ResumeLayout(false);
            this.gbAction.PerformLayout();
            this.gbMethode.ResumeLayout(false);
            this.gbMethode.PerformLayout();
            this.gbCurrentCmdStatus.ResumeLayout(false);
            this.gbCurrentCmdStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btLoadProcess;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btFileBrowser;
        private System.Windows.Forms.GroupBox gbCommonInfo;
        private System.Windows.Forms.Label lbTotalCmd;
        private System.Windows.Forms.Label lbFileStatus;
        private System.Windows.Forms.Label lbSystemStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotalCmd1;
        private System.Windows.Forms.Label lbFileStatus1;
        private System.Windows.Forms.GroupBox gbManualMode;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btPrevious;
        private System.Windows.Forms.GroupBox gbAutoMode;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btPause;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label lbManualStatus;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.Label lbAutoStatus;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.GroupBox gbCurrentCmdStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ComboBox cbCurrentCmd;
        private System.Windows.Forms.ComboBox cbCurrentNumber;
        private System.Windows.Forms.ComboBox cbCurrentDesc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbAction;
        private System.Windows.Forms.RadioButton rbStop;
        private System.Windows.Forms.RadioButton rbPause;
        private System.Windows.Forms.RadioButton rbDoNothing;
        private System.Windows.Forms.GroupBox gbMethode;
        private System.Windows.Forms.RadioButton rbCompareResp;
        private System.Windows.Forms.RadioButton rbYesNo;
        private System.Windows.Forms.RadioButton rbDontVerify;
        private System.Windows.Forms.Timer Timer_WaitRespond;
        private System.Windows.Forms.CheckBox cbLoopTest;
    }
}
namespace WindowsFormsApplication2
{
    partial class EDALogTool
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonLink1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonFind1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemShowCurrentLink = new System.Windows.Forms.ToolStripMenuItem();
            this.linkResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.옵션ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.alwaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAfterCompareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogEditor = new System.Windows.Forms.OpenFileDialog();
            this.richTextBoxLink1_1 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxLink1_2 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxLink1_3 = new System.Windows.Forms.RichTextBox();
            this.tabControlTrace = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxHDR = new System.Windows.Forms.CheckBox();
            this.checkBoxTIME_STAMP = new System.Windows.Forms.CheckBox();
            this.checkBoxEQPID = new System.Windows.Forms.CheckBox();
            this.checkBoxLOTID = new System.Windows.Forms.CheckBox();
            this.checkBoxRECPID = new System.Windows.Forms.CheckBox();
            this.checkBoxCARIDMAP = new System.Windows.Forms.CheckBox();
            this.checkBoxFROM_EDA_CONSUMER = new System.Windows.Forms.CheckBox();
            this.checkBoxDCPLANID = new System.Windows.Forms.CheckBox();
            this.checkBoxDCPINTERVAL = new System.Windows.Forms.CheckBox();
            this.checkBoxSAMPLENUMBER = new System.Windows.Forms.CheckBox();
            this.checkBoxSAMPLETIME = new System.Windows.Forms.CheckBox();
            this.checkBoxINNERSAMPLETIME = new System.Windows.Forms.CheckBox();
            this.checkBoxSENSOR_VALUES = new System.Windows.Forms.CheckBox();
            this.checkBoxEES_SERVER_TIME = new System.Windows.Forms.CheckBox();
            this.checkBoxUTC_SERVER_TIME = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.richTextBoxSkewEQPList = new System.Windows.Forms.RichTextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxDCPSplit = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableMsgBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSkewLink = new System.Windows.Forms.Button();
            this.buttonSkewCompare = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxDataType_1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonTOOLDATA = new System.Windows.Forms.RadioButton();
            this.radioButtonTOOLALARM = new System.Windows.Forms.RadioButton();
            this.radioButtonTOOLEVENTS = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBoxEQPIDList_1 = new System.Windows.Forms.GroupBox();
            this.groupBoxDCPList_1 = new System.Windows.Forms.GroupBox();
            this.groupBoxETC_1 = new System.Windows.Forms.GroupBox();
            this.groupBoxTimeAfter_1 = new System.Windows.Forms.GroupBox();
            this.textBoxTimeAfter_1 = new System.Windows.Forms.TextBox();
            this.groupBoxTimeBefore_1 = new System.Windows.Forms.GroupBox();
            this.textBoxTimeBefore_1 = new System.Windows.Forms.TextBox();
            this.groupBoxDataType_2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.groupBoxEQPIDList_2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxLink2_1 = new System.Windows.Forms.RichTextBox();
            this.groupBoxDCPList_2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxLink2_2 = new System.Windows.Forms.RichTextBox();
            this.groupBoxETC_2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxLink2_3 = new System.Windows.Forms.RichTextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBoxTimeAfter_2 = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.textBoxTimeBefore_2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonLink2 = new System.Windows.Forms.Button();
            this.buttonFind2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBoxConsumerLog = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.richTextBoxSoapMessage = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.richTextBoxXML = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.treeViewXML = new System.Windows.Forms.TreeView();
            this.contextMenuStripTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonConvertXML = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControlTrace.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxDataType_1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxEQPIDList_1.SuspendLayout();
            this.groupBoxDCPList_1.SuspendLayout();
            this.groupBoxETC_1.SuspendLayout();
            this.groupBoxTimeAfter_1.SuspendLayout();
            this.groupBoxTimeBefore_1.SuspendLayout();
            this.groupBoxDataType_2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBoxEQPIDList_2.SuspendLayout();
            this.groupBoxDCPList_2.SuspendLayout();
            this.groupBoxETC_2.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.contextMenuStripTreeView.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLink1
            // 
            this.buttonLink1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLink1.Location = new System.Drawing.Point(3, 3);
            this.buttonLink1.Name = "buttonLink1";
            this.buttonLink1.Size = new System.Drawing.Size(129, 30);
            this.buttonLink1.TabIndex = 0;
            this.buttonLink1.Text = "Link Consumer";
            this.buttonLink1.UseVisualStyleBackColor = true;
            this.buttonLink1.Click += new System.EventHandler(this.buttonLink1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // buttonFind1
            // 
            this.buttonFind1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFind1.Location = new System.Drawing.Point(138, 3);
            this.buttonFind1.Name = "buttonFind1";
            this.buttonFind1.Size = new System.Drawing.Size(129, 30);
            this.buttonFind1.TabIndex = 1;
            this.buttonFind1.Text = "Find";
            this.buttonFind1.UseVisualStyleBackColor = true;
            this.buttonFind1.Click += new System.EventHandler(this.buttonFind1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.옵션ToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemShowCurrentLink,
            this.linkResetToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.파일ToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItemShowCurrentLink
            // 
            this.toolStripMenuItemShowCurrentLink.Name = "toolStripMenuItemShowCurrentLink";
            this.toolStripMenuItemShowCurrentLink.Size = new System.Drawing.Size(179, 22);
            this.toolStripMenuItemShowCurrentLink.Text = "Show Current Links";
            this.toolStripMenuItemShowCurrentLink.Click += new System.EventHandler(this.toolStripMenuItemShowCurrentLink_Click);
            // 
            // linkResetToolStripMenuItem
            // 
            this.linkResetToolStripMenuItem.Name = "linkResetToolStripMenuItem";
            this.linkResetToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.linkResetToolStripMenuItem.Text = "Link Reset";
            this.linkResetToolStripMenuItem.Click += new System.EventHandler(this.linkResetToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(176, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // 옵션ToolStripMenuItem
            // 
            this.옵션ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeEditorToolStripMenuItem,
            this.toolStripSeparator3,
            this.alwaysToolStripMenuItem,
            this.openAfterCompareToolStripMenuItem,
            this.autoToolStripMenuItem,
            this.toolStripSeparator1,
            this.settingsToolStripMenuItem});
            this.옵션ToolStripMenuItem.Name = "옵션ToolStripMenuItem";
            this.옵션ToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.옵션ToolStripMenuItem.Text = "Option";
            // 
            // changeEditorToolStripMenuItem
            // 
            this.changeEditorToolStripMenuItem.Name = "changeEditorToolStripMenuItem";
            this.changeEditorToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.changeEditorToolStripMenuItem.Text = "Change Text Editor(disabled)";
            this.changeEditorToolStripMenuItem.Click += new System.EventHandler(this.changeEditorToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(225, 6);
            // 
            // alwaysToolStripMenuItem
            // 
            this.alwaysToolStripMenuItem.CheckOnClick = true;
            this.alwaysToolStripMenuItem.Name = "alwaysToolStripMenuItem";
            this.alwaysToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.alwaysToolStripMenuItem.Text = "Always on Top";
            this.alwaysToolStripMenuItem.CheckedChanged += new System.EventHandler(this.alwaysToolStripMenuItem_CheckedChanged);
            // 
            // openAfterCompareToolStripMenuItem
            // 
            this.openAfterCompareToolStripMenuItem.Checked = true;
            this.openAfterCompareToolStripMenuItem.CheckOnClick = true;
            this.openAfterCompareToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.openAfterCompareToolStripMenuItem.Name = "openAfterCompareToolStripMenuItem";
            this.openAfterCompareToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.openAfterCompareToolStripMenuItem.Text = "Auto Open Text File";
            // 
            // autoToolStripMenuItem
            // 
            this.autoToolStripMenuItem.Checked = true;
            this.autoToolStripMenuItem.CheckOnClick = true;
            this.autoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoToolStripMenuItem.Name = "autoToolStripMenuItem";
            this.autoToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.autoToolStripMenuItem.Text = "Auto Capitalization";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(225, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.settingsToolStripMenuItem.Text = "Settings(disabled)";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.howToUseToolStripMenuItem.Text = "How to use(disabled)";
            this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.howToUseToolStripMenuItem_Click);
            // 
            // openFileDialogEditor
            // 
            this.openFileDialogEditor.FileName = "openFileDialogEditor";
            // 
            // richTextBoxLink1_1
            // 
            this.richTextBoxLink1_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLink1_1.Location = new System.Drawing.Point(3, 17);
            this.richTextBoxLink1_1.Name = "richTextBoxLink1_1";
            this.richTextBoxLink1_1.Size = new System.Drawing.Size(270, 55);
            this.richTextBoxLink1_1.TabIndex = 0;
            this.richTextBoxLink1_1.Text = "";
            this.richTextBoxLink1_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBoxLink1_1_KeyPress);
            // 
            // richTextBoxLink1_2
            // 
            this.richTextBoxLink1_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLink1_2.Location = new System.Drawing.Point(3, 17);
            this.richTextBoxLink1_2.Name = "richTextBoxLink1_2";
            this.richTextBoxLink1_2.Size = new System.Drawing.Size(270, 55);
            this.richTextBoxLink1_2.TabIndex = 0;
            this.richTextBoxLink1_2.Text = "";
            this.richTextBoxLink1_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBoxLink1_2_KeyPress);
            // 
            // richTextBoxLink1_3
            // 
            this.richTextBoxLink1_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLink1_3.Location = new System.Drawing.Point(3, 17);
            this.richTextBoxLink1_3.Name = "richTextBoxLink1_3";
            this.richTextBoxLink1_3.Size = new System.Drawing.Size(270, 55);
            this.richTextBoxLink1_3.TabIndex = 0;
            this.richTextBoxLink1_3.Text = "";
            // 
            // tabControlTrace
            // 
            this.tabControlTrace.Controls.Add(this.tabPage1);
            this.tabControlTrace.Controls.Add(this.tabPage3);
            this.tabControlTrace.Controls.Add(this.tabPage2);
            this.tabControlTrace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTrace.Location = new System.Drawing.Point(0, 24);
            this.tabControlTrace.Name = "tabControlTrace";
            this.tabControlTrace.SelectedIndex = 0;
            this.tabControlTrace.Size = new System.Drawing.Size(984, 537);
            this.tabControlTrace.TabIndex = 11;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(976, 511);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "TOOLDATA Skew";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.77869F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.221312F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel8, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(976, 511);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.groupBox7, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.groupBox8, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.groupBox9, 0, 2);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(879, 505);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.flowLayoutPanel3);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(873, 144);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Data Attributes";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.checkBoxHDR);
            this.flowLayoutPanel3.Controls.Add(this.checkBoxTIME_STAMP);
            this.flowLayoutPanel3.Controls.Add(this.checkBoxEQPID);
            this.flowLayoutPanel3.Controls.Add(this.checkBoxLOTID);
            this.flowLayoutPanel3.Controls.Add(this.checkBoxRECPID);
            this.flowLayoutPanel3.Controls.Add(this.checkBoxCARIDMAP);
            this.flowLayoutPanel3.Controls.Add(this.checkBoxFROM_EDA_CONSUMER);
            this.flowLayoutPanel3.Controls.Add(this.checkBoxDCPLANID);
            this.flowLayoutPanel3.Controls.Add(this.checkBoxDCPINTERVAL);
            this.flowLayoutPanel3.Controls.Add(this.checkBoxSAMPLENUMBER);
            this.flowLayoutPanel3.Controls.Add(this.checkBoxSAMPLETIME);
            this.flowLayoutPanel3.Controls.Add(this.checkBoxINNERSAMPLETIME);
            this.flowLayoutPanel3.Controls.Add(this.checkBoxSENSOR_VALUES);
            this.flowLayoutPanel3.Controls.Add(this.checkBoxEES_SERVER_TIME);
            this.flowLayoutPanel3.Controls.Add(this.checkBoxUTC_SERVER_TIME);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(867, 124);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // checkBoxHDR
            // 
            this.checkBoxHDR.AutoSize = true;
            this.checkBoxHDR.Checked = true;
            this.checkBoxHDR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHDR.Location = new System.Drawing.Point(3, 3);
            this.checkBoxHDR.Name = "checkBoxHDR";
            this.checkBoxHDR.Size = new System.Drawing.Size(48, 16);
            this.checkBoxHDR.TabIndex = 0;
            this.checkBoxHDR.Text = "HDR";
            this.checkBoxHDR.UseVisualStyleBackColor = true;
            // 
            // checkBoxTIME_STAMP
            // 
            this.checkBoxTIME_STAMP.AutoSize = true;
            this.checkBoxTIME_STAMP.Checked = true;
            this.checkBoxTIME_STAMP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTIME_STAMP.Location = new System.Drawing.Point(57, 3);
            this.checkBoxTIME_STAMP.Name = "checkBoxTIME_STAMP";
            this.checkBoxTIME_STAMP.Size = new System.Drawing.Size(103, 16);
            this.checkBoxTIME_STAMP.TabIndex = 1;
            this.checkBoxTIME_STAMP.Text = "TIME_STAMP";
            this.checkBoxTIME_STAMP.UseVisualStyleBackColor = true;
            // 
            // checkBoxEQPID
            // 
            this.checkBoxEQPID.AutoSize = true;
            this.checkBoxEQPID.Checked = true;
            this.checkBoxEQPID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEQPID.Location = new System.Drawing.Point(166, 3);
            this.checkBoxEQPID.Name = "checkBoxEQPID";
            this.checkBoxEQPID.Size = new System.Drawing.Size(60, 16);
            this.checkBoxEQPID.TabIndex = 2;
            this.checkBoxEQPID.Text = "EQPID";
            this.checkBoxEQPID.UseVisualStyleBackColor = true;
            // 
            // checkBoxLOTID
            // 
            this.checkBoxLOTID.AutoSize = true;
            this.checkBoxLOTID.Checked = true;
            this.checkBoxLOTID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLOTID.Location = new System.Drawing.Point(232, 3);
            this.checkBoxLOTID.Name = "checkBoxLOTID";
            this.checkBoxLOTID.Size = new System.Drawing.Size(59, 16);
            this.checkBoxLOTID.TabIndex = 3;
            this.checkBoxLOTID.Text = "LOTID";
            this.checkBoxLOTID.UseVisualStyleBackColor = true;
            // 
            // checkBoxRECPID
            // 
            this.checkBoxRECPID.AutoSize = true;
            this.checkBoxRECPID.Checked = true;
            this.checkBoxRECPID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRECPID.Location = new System.Drawing.Point(297, 3);
            this.checkBoxRECPID.Name = "checkBoxRECPID";
            this.checkBoxRECPID.Size = new System.Drawing.Size(68, 16);
            this.checkBoxRECPID.TabIndex = 4;
            this.checkBoxRECPID.Text = "RECPID";
            this.checkBoxRECPID.UseVisualStyleBackColor = true;
            // 
            // checkBoxCARIDMAP
            // 
            this.checkBoxCARIDMAP.AutoSize = true;
            this.checkBoxCARIDMAP.Checked = true;
            this.checkBoxCARIDMAP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCARIDMAP.Location = new System.Drawing.Point(371, 3);
            this.checkBoxCARIDMAP.Name = "checkBoxCARIDMAP";
            this.checkBoxCARIDMAP.Size = new System.Drawing.Size(87, 16);
            this.checkBoxCARIDMAP.TabIndex = 5;
            this.checkBoxCARIDMAP.Text = "CARIDMAP";
            this.checkBoxCARIDMAP.UseVisualStyleBackColor = true;
            // 
            // checkBoxFROM_EDA_CONSUMER
            // 
            this.checkBoxFROM_EDA_CONSUMER.AutoSize = true;
            this.checkBoxFROM_EDA_CONSUMER.Checked = true;
            this.checkBoxFROM_EDA_CONSUMER.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFROM_EDA_CONSUMER.Location = new System.Drawing.Point(464, 3);
            this.checkBoxFROM_EDA_CONSUMER.Name = "checkBoxFROM_EDA_CONSUMER";
            this.checkBoxFROM_EDA_CONSUMER.Size = new System.Drawing.Size(165, 16);
            this.checkBoxFROM_EDA_CONSUMER.TabIndex = 6;
            this.checkBoxFROM_EDA_CONSUMER.Text = "FROM_EDA_CONSUMER";
            this.checkBoxFROM_EDA_CONSUMER.UseVisualStyleBackColor = true;
            // 
            // checkBoxDCPLANID
            // 
            this.checkBoxDCPLANID.AutoSize = true;
            this.checkBoxDCPLANID.Checked = true;
            this.checkBoxDCPLANID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDCPLANID.Location = new System.Drawing.Point(635, 3);
            this.checkBoxDCPLANID.Name = "checkBoxDCPLANID";
            this.checkBoxDCPLANID.Size = new System.Drawing.Size(84, 16);
            this.checkBoxDCPLANID.TabIndex = 7;
            this.checkBoxDCPLANID.Text = "DCPLANID";
            this.checkBoxDCPLANID.UseVisualStyleBackColor = true;
            // 
            // checkBoxDCPINTERVAL
            // 
            this.checkBoxDCPINTERVAL.AutoSize = true;
            this.checkBoxDCPINTERVAL.Checked = true;
            this.checkBoxDCPINTERVAL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDCPINTERVAL.Location = new System.Drawing.Point(725, 3);
            this.checkBoxDCPINTERVAL.Name = "checkBoxDCPINTERVAL";
            this.checkBoxDCPINTERVAL.Size = new System.Drawing.Size(108, 16);
            this.checkBoxDCPINTERVAL.TabIndex = 8;
            this.checkBoxDCPINTERVAL.Text = "DCPINTERVAL";
            this.checkBoxDCPINTERVAL.UseVisualStyleBackColor = true;
            // 
            // checkBoxSAMPLENUMBER
            // 
            this.checkBoxSAMPLENUMBER.AutoSize = true;
            this.checkBoxSAMPLENUMBER.Checked = true;
            this.checkBoxSAMPLENUMBER.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSAMPLENUMBER.Location = new System.Drawing.Point(3, 25);
            this.checkBoxSAMPLENUMBER.Name = "checkBoxSAMPLENUMBER";
            this.checkBoxSAMPLENUMBER.Size = new System.Drawing.Size(126, 16);
            this.checkBoxSAMPLENUMBER.TabIndex = 9;
            this.checkBoxSAMPLENUMBER.Text = "SAMPLENUMBER";
            this.checkBoxSAMPLENUMBER.UseVisualStyleBackColor = true;
            // 
            // checkBoxSAMPLETIME
            // 
            this.checkBoxSAMPLETIME.AutoSize = true;
            this.checkBoxSAMPLETIME.Checked = true;
            this.checkBoxSAMPLETIME.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSAMPLETIME.Enabled = false;
            this.checkBoxSAMPLETIME.Location = new System.Drawing.Point(135, 25);
            this.checkBoxSAMPLETIME.Name = "checkBoxSAMPLETIME";
            this.checkBoxSAMPLETIME.Size = new System.Drawing.Size(104, 16);
            this.checkBoxSAMPLETIME.TabIndex = 10;
            this.checkBoxSAMPLETIME.Text = "SAMPLETIME";
            this.checkBoxSAMPLETIME.UseVisualStyleBackColor = true;
            // 
            // checkBoxINNERSAMPLETIME
            // 
            this.checkBoxINNERSAMPLETIME.AutoSize = true;
            this.checkBoxINNERSAMPLETIME.Checked = true;
            this.checkBoxINNERSAMPLETIME.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxINNERSAMPLETIME.Location = new System.Drawing.Point(245, 25);
            this.checkBoxINNERSAMPLETIME.Name = "checkBoxINNERSAMPLETIME";
            this.checkBoxINNERSAMPLETIME.Size = new System.Drawing.Size(141, 16);
            this.checkBoxINNERSAMPLETIME.TabIndex = 12;
            this.checkBoxINNERSAMPLETIME.Text = "INNERSAMPLETIME";
            this.checkBoxINNERSAMPLETIME.UseVisualStyleBackColor = true;
            // 
            // checkBoxSENSOR_VALUES
            // 
            this.checkBoxSENSOR_VALUES.AutoSize = true;
            this.checkBoxSENSOR_VALUES.Location = new System.Drawing.Point(392, 25);
            this.checkBoxSENSOR_VALUES.Name = "checkBoxSENSOR_VALUES";
            this.checkBoxSENSOR_VALUES.Size = new System.Drawing.Size(127, 16);
            this.checkBoxSENSOR_VALUES.TabIndex = 13;
            this.checkBoxSENSOR_VALUES.Text = "SENSOR_VALUES";
            this.checkBoxSENSOR_VALUES.UseVisualStyleBackColor = true;
            // 
            // checkBoxEES_SERVER_TIME
            // 
            this.checkBoxEES_SERVER_TIME.AutoSize = true;
            this.checkBoxEES_SERVER_TIME.Checked = true;
            this.checkBoxEES_SERVER_TIME.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEES_SERVER_TIME.Location = new System.Drawing.Point(525, 25);
            this.checkBoxEES_SERVER_TIME.Name = "checkBoxEES_SERVER_TIME";
            this.checkBoxEES_SERVER_TIME.Size = new System.Drawing.Size(138, 16);
            this.checkBoxEES_SERVER_TIME.TabIndex = 14;
            this.checkBoxEES_SERVER_TIME.Text = "EES_SERVER_TIME";
            this.checkBoxEES_SERVER_TIME.UseVisualStyleBackColor = true;
            // 
            // checkBoxUTC_SERVER_TIME
            // 
            this.checkBoxUTC_SERVER_TIME.AutoSize = true;
            this.checkBoxUTC_SERVER_TIME.Checked = true;
            this.checkBoxUTC_SERVER_TIME.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUTC_SERVER_TIME.Location = new System.Drawing.Point(669, 25);
            this.checkBoxUTC_SERVER_TIME.Name = "checkBoxUTC_SERVER_TIME";
            this.checkBoxUTC_SERVER_TIME.Size = new System.Drawing.Size(139, 16);
            this.checkBoxUTC_SERVER_TIME.TabIndex = 15;
            this.checkBoxUTC_SERVER_TIME.Text = "UTC_SERVER_TIME";
            this.checkBoxUTC_SERVER_TIME.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.richTextBoxSkewEQPList);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(3, 153);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(873, 171);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "EQPID List";
            // 
            // richTextBoxSkewEQPList
            // 
            this.richTextBoxSkewEQPList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxSkewEQPList.Location = new System.Drawing.Point(3, 17);
            this.richTextBoxSkewEQPList.Name = "richTextBoxSkewEQPList";
            this.richTextBoxSkewEQPList.Size = new System.Drawing.Size(867, 151);
            this.richTextBoxSkewEQPList.TabIndex = 0;
            this.richTextBoxSkewEQPList.Text = "";
            this.richTextBoxSkewEQPList.TextChanged += new System.EventHandler(this.richTextBoxSkewEQPList_TextChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.flowLayoutPanel4);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(3, 330);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(873, 172);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Option";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.checkBoxDCPSplit);
            this.flowLayoutPanel4.Controls.Add(this.checkBoxEnableMsgBox);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(867, 152);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // checkBoxDCPSplit
            // 
            this.checkBoxDCPSplit.AutoSize = true;
            this.checkBoxDCPSplit.Location = new System.Drawing.Point(3, 3);
            this.checkBoxDCPSplit.Name = "checkBoxDCPSplit";
            this.checkBoxDCPSplit.Size = new System.Drawing.Size(77, 16);
            this.checkBoxDCPSplit.TabIndex = 0;
            this.checkBoxDCPSplit.Text = "DCP Split";
            this.checkBoxDCPSplit.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnableMsgBox
            // 
            this.checkBoxEnableMsgBox.AutoSize = true;
            this.checkBoxEnableMsgBox.Location = new System.Drawing.Point(86, 3);
            this.checkBoxEnableMsgBox.Name = "checkBoxEnableMsgBox";
            this.checkBoxEnableMsgBox.Size = new System.Drawing.Size(219, 16);
            this.checkBoxEnableMsgBox.TabIndex = 1;
            this.checkBoxEnableMsgBox.Text = "Enable Msg Box When Comparing";
            this.checkBoxEnableMsgBox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.buttonSkewLink, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.buttonSkewCompare, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(888, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(85, 505);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // buttonSkewLink
            // 
            this.buttonSkewLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSkewLink.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSkewLink.Location = new System.Drawing.Point(3, 3);
            this.buttonSkewLink.Name = "buttonSkewLink";
            this.buttonSkewLink.Size = new System.Drawing.Size(79, 246);
            this.buttonSkewLink.TabIndex = 0;
            this.buttonSkewLink.Text = "Link";
            this.buttonSkewLink.UseVisualStyleBackColor = true;
            this.buttonSkewLink.Click += new System.EventHandler(this.buttonSkewLink_Click);
            // 
            // buttonSkewCompare
            // 
            this.buttonSkewCompare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSkewCompare.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSkewCompare.Location = new System.Drawing.Point(3, 255);
            this.buttonSkewCompare.Name = "buttonSkewCompare";
            this.buttonSkewCompare.Size = new System.Drawing.Size(79, 247);
            this.buttonSkewCompare.TabIndex = 1;
            this.buttonSkewCompare.Text = "Compare";
            this.buttonSkewCompare.UseVisualStyleBackColor = true;
            this.buttonSkewCompare.Click += new System.EventHandler(this.buttonSkewCompare_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trace";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer1.Size = new System.Drawing.Size(970, 505);
            this.splitContainer1.SplitterDistance = 565;
            this.splitContainer1.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxDataType_1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxEQPIDList_1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxDCPList_1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxETC_1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxTimeAfter_1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxTimeBefore_1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxDataType_2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxEQPIDList_2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxDCPList_2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxETC_2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox10, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBox11, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(565, 505);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxDataType_1
            // 
            this.groupBoxDataType_1.Controls.Add(this.flowLayoutPanel1);
            this.groupBoxDataType_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDataType_1.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDataType_1.Name = "groupBoxDataType_1";
            this.groupBoxDataType_1.Size = new System.Drawing.Size(276, 94);
            this.groupBoxDataType_1.TabIndex = 0;
            this.groupBoxDataType_1.TabStop = false;
            this.groupBoxDataType_1.Text = "DataType";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radioButtonTOOLDATA);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonTOOLALARM);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonTOOLEVENTS);
            this.flowLayoutPanel1.Controls.Add(this.radioButton4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(270, 74);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // radioButtonTOOLDATA
            // 
            this.radioButtonTOOLDATA.AutoSize = true;
            this.radioButtonTOOLDATA.Location = new System.Drawing.Point(3, 3);
            this.radioButtonTOOLDATA.Name = "radioButtonTOOLDATA";
            this.radioButtonTOOLDATA.Size = new System.Drawing.Size(88, 16);
            this.radioButtonTOOLDATA.TabIndex = 0;
            this.radioButtonTOOLDATA.Text = "TOOLDATA";
            this.radioButtonTOOLDATA.UseVisualStyleBackColor = true;
            // 
            // radioButtonTOOLALARM
            // 
            this.radioButtonTOOLALARM.AutoSize = true;
            this.radioButtonTOOLALARM.Location = new System.Drawing.Point(97, 3);
            this.radioButtonTOOLALARM.Name = "radioButtonTOOLALARM";
            this.radioButtonTOOLALARM.Size = new System.Drawing.Size(98, 16);
            this.radioButtonTOOLALARM.TabIndex = 1;
            this.radioButtonTOOLALARM.Text = "TOOLALARM";
            this.radioButtonTOOLALARM.UseVisualStyleBackColor = true;
            // 
            // radioButtonTOOLEVENTS
            // 
            this.radioButtonTOOLEVENTS.AutoSize = true;
            this.radioButtonTOOLEVENTS.Location = new System.Drawing.Point(3, 25);
            this.radioButtonTOOLEVENTS.Name = "radioButtonTOOLEVENTS";
            this.radioButtonTOOLEVENTS.Size = new System.Drawing.Size(105, 16);
            this.radioButtonTOOLEVENTS.TabIndex = 2;
            this.radioButtonTOOLEVENTS.Text = "TOOLEVENTS";
            this.radioButtonTOOLEVENTS.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(114, 25);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(45, 16);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "ALL";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBoxEQPIDList_1
            // 
            this.groupBoxEQPIDList_1.Controls.Add(this.richTextBoxLink1_1);
            this.groupBoxEQPIDList_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEQPIDList_1.Location = new System.Drawing.Point(3, 103);
            this.groupBoxEQPIDList_1.Name = "groupBoxEQPIDList_1";
            this.groupBoxEQPIDList_1.Size = new System.Drawing.Size(276, 75);
            this.groupBoxEQPIDList_1.TabIndex = 1;
            this.groupBoxEQPIDList_1.TabStop = false;
            this.groupBoxEQPIDList_1.Text = "EQPID List";
            // 
            // groupBoxDCPList_1
            // 
            this.groupBoxDCPList_1.Controls.Add(this.richTextBoxLink1_2);
            this.groupBoxDCPList_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDCPList_1.Location = new System.Drawing.Point(3, 184);
            this.groupBoxDCPList_1.Name = "groupBoxDCPList_1";
            this.groupBoxDCPList_1.Size = new System.Drawing.Size(276, 75);
            this.groupBoxDCPList_1.TabIndex = 2;
            this.groupBoxDCPList_1.TabStop = false;
            this.groupBoxDCPList_1.Text = "DCP List";
            // 
            // groupBoxETC_1
            // 
            this.groupBoxETC_1.Controls.Add(this.richTextBoxLink1_3);
            this.groupBoxETC_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxETC_1.Location = new System.Drawing.Point(3, 265);
            this.groupBoxETC_1.Name = "groupBoxETC_1";
            this.groupBoxETC_1.Size = new System.Drawing.Size(276, 75);
            this.groupBoxETC_1.TabIndex = 3;
            this.groupBoxETC_1.TabStop = false;
            this.groupBoxETC_1.Text = "ETC";
            // 
            // groupBoxTimeAfter_1
            // 
            this.groupBoxTimeAfter_1.Controls.Add(this.textBoxTimeAfter_1);
            this.groupBoxTimeAfter_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTimeAfter_1.Location = new System.Drawing.Point(3, 346);
            this.groupBoxTimeAfter_1.Name = "groupBoxTimeAfter_1";
            this.groupBoxTimeAfter_1.Size = new System.Drawing.Size(276, 44);
            this.groupBoxTimeAfter_1.TabIndex = 4;
            this.groupBoxTimeAfter_1.TabStop = false;
            this.groupBoxTimeAfter_1.Text = "Time(After)";
            // 
            // textBoxTimeAfter_1
            // 
            this.textBoxTimeAfter_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTimeAfter_1.Location = new System.Drawing.Point(3, 17);
            this.textBoxTimeAfter_1.MaxLength = 16;
            this.textBoxTimeAfter_1.Name = "textBoxTimeAfter_1";
            this.textBoxTimeAfter_1.Size = new System.Drawing.Size(270, 21);
            this.textBoxTimeAfter_1.TabIndex = 0;
            this.textBoxTimeAfter_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTimeAfter_1_KeyPress);
            // 
            // groupBoxTimeBefore_1
            // 
            this.groupBoxTimeBefore_1.Controls.Add(this.textBoxTimeBefore_1);
            this.groupBoxTimeBefore_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTimeBefore_1.Location = new System.Drawing.Point(3, 396);
            this.groupBoxTimeBefore_1.Name = "groupBoxTimeBefore_1";
            this.groupBoxTimeBefore_1.Size = new System.Drawing.Size(276, 44);
            this.groupBoxTimeBefore_1.TabIndex = 5;
            this.groupBoxTimeBefore_1.TabStop = false;
            this.groupBoxTimeBefore_1.Text = "Time(Before)";
            // 
            // textBoxTimeBefore_1
            // 
            this.textBoxTimeBefore_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTimeBefore_1.Location = new System.Drawing.Point(3, 17);
            this.textBoxTimeBefore_1.MaxLength = 16;
            this.textBoxTimeBefore_1.Name = "textBoxTimeBefore_1";
            this.textBoxTimeBefore_1.Size = new System.Drawing.Size(270, 21);
            this.textBoxTimeBefore_1.TabIndex = 0;
            this.textBoxTimeBefore_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTimeBefore_1_KeyPress);
            // 
            // groupBoxDataType_2
            // 
            this.groupBoxDataType_2.Controls.Add(this.flowLayoutPanel2);
            this.groupBoxDataType_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDataType_2.Location = new System.Drawing.Point(285, 3);
            this.groupBoxDataType_2.Name = "groupBoxDataType_2";
            this.groupBoxDataType_2.Size = new System.Drawing.Size(277, 94);
            this.groupBoxDataType_2.TabIndex = 7;
            this.groupBoxDataType_2.TabStop = false;
            this.groupBoxDataType_2.Text = "DataType";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.radioButton1);
            this.flowLayoutPanel2.Controls.Add(this.radioButton2);
            this.flowLayoutPanel2.Controls.Add(this.radioButton3);
            this.flowLayoutPanel2.Controls.Add(this.radioButton5);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(271, 74);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(101, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 25);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(92, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Location = new System.Drawing.Point(101, 25);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(45, 16);
            this.radioButton5.TabIndex = 3;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "ALL";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // groupBoxEQPIDList_2
            // 
            this.groupBoxEQPIDList_2.Controls.Add(this.richTextBoxLink2_1);
            this.groupBoxEQPIDList_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEQPIDList_2.Location = new System.Drawing.Point(285, 103);
            this.groupBoxEQPIDList_2.Name = "groupBoxEQPIDList_2";
            this.groupBoxEQPIDList_2.Size = new System.Drawing.Size(277, 75);
            this.groupBoxEQPIDList_2.TabIndex = 8;
            this.groupBoxEQPIDList_2.TabStop = false;
            this.groupBoxEQPIDList_2.Text = "EQPID List";
            // 
            // richTextBoxLink2_1
            // 
            this.richTextBoxLink2_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLink2_1.Location = new System.Drawing.Point(3, 17);
            this.richTextBoxLink2_1.Name = "richTextBoxLink2_1";
            this.richTextBoxLink2_1.Size = new System.Drawing.Size(271, 55);
            this.richTextBoxLink2_1.TabIndex = 0;
            this.richTextBoxLink2_1.Text = "";
            this.richTextBoxLink2_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBoxLink2_1_KeyPress);
            // 
            // groupBoxDCPList_2
            // 
            this.groupBoxDCPList_2.Controls.Add(this.richTextBoxLink2_2);
            this.groupBoxDCPList_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDCPList_2.Location = new System.Drawing.Point(285, 184);
            this.groupBoxDCPList_2.Name = "groupBoxDCPList_2";
            this.groupBoxDCPList_2.Size = new System.Drawing.Size(277, 75);
            this.groupBoxDCPList_2.TabIndex = 9;
            this.groupBoxDCPList_2.TabStop = false;
            this.groupBoxDCPList_2.Text = "DCP List";
            // 
            // richTextBoxLink2_2
            // 
            this.richTextBoxLink2_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLink2_2.Location = new System.Drawing.Point(3, 17);
            this.richTextBoxLink2_2.Name = "richTextBoxLink2_2";
            this.richTextBoxLink2_2.Size = new System.Drawing.Size(271, 55);
            this.richTextBoxLink2_2.TabIndex = 0;
            this.richTextBoxLink2_2.Text = "";
            this.richTextBoxLink2_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBoxLink2_2_KeyPress);
            // 
            // groupBoxETC_2
            // 
            this.groupBoxETC_2.Controls.Add(this.richTextBoxLink2_3);
            this.groupBoxETC_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxETC_2.Location = new System.Drawing.Point(285, 265);
            this.groupBoxETC_2.Name = "groupBoxETC_2";
            this.groupBoxETC_2.Size = new System.Drawing.Size(277, 75);
            this.groupBoxETC_2.TabIndex = 10;
            this.groupBoxETC_2.TabStop = false;
            this.groupBoxETC_2.Text = "ETC";
            // 
            // richTextBoxLink2_3
            // 
            this.richTextBoxLink2_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLink2_3.Location = new System.Drawing.Point(3, 17);
            this.richTextBoxLink2_3.Name = "richTextBoxLink2_3";
            this.richTextBoxLink2_3.Size = new System.Drawing.Size(271, 55);
            this.richTextBoxLink2_3.TabIndex = 0;
            this.richTextBoxLink2_3.Text = "";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.textBoxTimeAfter_2);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.Location = new System.Drawing.Point(285, 346);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(277, 44);
            this.groupBox10.TabIndex = 11;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Time(After)";
            // 
            // textBoxTimeAfter_2
            // 
            this.textBoxTimeAfter_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTimeAfter_2.Location = new System.Drawing.Point(3, 17);
            this.textBoxTimeAfter_2.Name = "textBoxTimeAfter_2";
            this.textBoxTimeAfter_2.Size = new System.Drawing.Size(271, 21);
            this.textBoxTimeAfter_2.TabIndex = 0;
            this.textBoxTimeAfter_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTimeAfter_2_KeyPress);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.textBoxTimeBefore_2);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox11.Location = new System.Drawing.Point(285, 396);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(277, 44);
            this.groupBox11.TabIndex = 12;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Time(Before)";
            // 
            // textBoxTimeBefore_2
            // 
            this.textBoxTimeBefore_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTimeBefore_2.Location = new System.Drawing.Point(3, 17);
            this.textBoxTimeBefore_2.Name = "textBoxTimeBefore_2";
            this.textBoxTimeBefore_2.Size = new System.Drawing.Size(271, 21);
            this.textBoxTimeBefore_2.TabIndex = 0;
            this.textBoxTimeBefore_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTimeBefore_2_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 446);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 56);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Run";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttonFind1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonLink1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(270, 36);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(285, 446);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 56);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Run";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.buttonLink2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonFind2, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(271, 36);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // buttonLink2
            // 
            this.buttonLink2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLink2.Location = new System.Drawing.Point(3, 3);
            this.buttonLink2.Name = "buttonLink2";
            this.buttonLink2.Size = new System.Drawing.Size(129, 30);
            this.buttonLink2.TabIndex = 0;
            this.buttonLink2.Text = "Link Soap";
            this.buttonLink2.UseVisualStyleBackColor = true;
            this.buttonLink2.Click += new System.EventHandler(this.buttonLink2_Click);
            // 
            // buttonFind2
            // 
            this.buttonFind2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFind2.Location = new System.Drawing.Point(138, 3);
            this.buttonFind2.Name = "buttonFind2";
            this.buttonFind2.Size = new System.Drawing.Size(130, 30);
            this.buttonFind2.TabIndex = 1;
            this.buttonFind2.Text = "Find";
            this.buttonFind2.UseVisualStyleBackColor = true;
            this.buttonFind2.Click += new System.EventHandler(this.buttonFind2_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.buttonConvert, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox4, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(401, 505);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonConvert.Location = new System.Drawing.Point(3, 240);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(395, 24);
            this.buttonConvert.TabIndex = 1;
            this.buttonConvert.Text = "↑↓";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBoxConsumerLog);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 231);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consumer Log";
            // 
            // richTextBoxConsumerLog
            // 
            this.richTextBoxConsumerLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxConsumerLog.Location = new System.Drawing.Point(3, 17);
            this.richTextBoxConsumerLog.Name = "richTextBoxConsumerLog";
            this.richTextBoxConsumerLog.Size = new System.Drawing.Size(389, 211);
            this.richTextBoxConsumerLog.TabIndex = 0;
            this.richTextBoxConsumerLog.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.richTextBoxSoapMessage);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 270);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(395, 232);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Soap Message";
            // 
            // richTextBoxSoapMessage
            // 
            this.richTextBoxSoapMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxSoapMessage.Location = new System.Drawing.Point(3, 17);
            this.richTextBoxSoapMessage.Name = "richTextBoxSoapMessage";
            this.richTextBoxSoapMessage.Size = new System.Drawing.Size(389, 212);
            this.richTextBoxSoapMessage.TabIndex = 0;
            this.richTextBoxSoapMessage.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "XML Formatter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.groupBox6, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonConvertXML, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(970, 505);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.richTextBoxXML);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(464, 499);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "XML";
            // 
            // richTextBoxXML
            // 
            this.richTextBoxXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxXML.Location = new System.Drawing.Point(3, 17);
            this.richTextBoxXML.Name = "richTextBoxXML";
            this.richTextBoxXML.Size = new System.Drawing.Size(458, 479);
            this.richTextBoxXML.TabIndex = 0;
            this.richTextBoxXML.Text = "";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.treeViewXML);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(503, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(464, 499);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tree View";
            // 
            // treeViewXML
            // 
            this.treeViewXML.ContextMenuStrip = this.contextMenuStripTreeView;
            this.treeViewXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewXML.Location = new System.Drawing.Point(3, 17);
            this.treeViewXML.Name = "treeViewXML";
            this.treeViewXML.Size = new System.Drawing.Size(458, 479);
            this.treeViewXML.TabIndex = 0;
            // 
            // contextMenuStripTreeView
            // 
            this.contextMenuStripTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.searchClearToolStripMenuItem});
            this.contextMenuStripTreeView.Name = "contextMenuStripTreeView";
            this.contextMenuStripTreeView.Size = new System.Drawing.Size(142, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.toolStripMenuItem1.Text = "Search";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // searchClearToolStripMenuItem
            // 
            this.searchClearToolStripMenuItem.Name = "searchClearToolStripMenuItem";
            this.searchClearToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.searchClearToolStripMenuItem.Text = "Clear Search";
            this.searchClearToolStripMenuItem.Click += new System.EventHandler(this.searchClearToolStripMenuItem_Click);
            // 
            // buttonConvertXML
            // 
            this.buttonConvertXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonConvertXML.Location = new System.Drawing.Point(473, 3);
            this.buttonConvertXML.Name = "buttonConvertXML";
            this.buttonConvertXML.Size = new System.Drawing.Size(24, 499);
            this.buttonConvertXML.TabIndex = 2;
            this.buttonConvertXML.Text = "→→";
            this.buttonConvertXML.UseVisualStyleBackColor = true;
            this.buttonConvertXML.Click += new System.EventHandler(this.buttonConvertXML_Click);
            // 
            // EDALogTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tabControlTrace);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "EDALogTool";
            this.Text = "EDA Log Tool";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlTrace.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxDataType_1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBoxEQPIDList_1.ResumeLayout(false);
            this.groupBoxDCPList_1.ResumeLayout(false);
            this.groupBoxETC_1.ResumeLayout(false);
            this.groupBoxTimeAfter_1.ResumeLayout(false);
            this.groupBoxTimeAfter_1.PerformLayout();
            this.groupBoxTimeBefore_1.ResumeLayout(false);
            this.groupBoxTimeBefore_1.PerformLayout();
            this.groupBoxDataType_2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBoxEQPIDList_2.ResumeLayout(false);
            this.groupBoxDCPList_2.ResumeLayout(false);
            this.groupBoxETC_2.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.contextMenuStripTreeView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLink1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonFind1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 옵션ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAfterCompareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeEditorToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogEditor;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBoxLink1_1;
        private System.Windows.Forms.RichTextBox richTextBoxLink1_2;
        private System.Windows.Forms.RichTextBox richTextBoxLink1_3;
        private System.Windows.Forms.TabControl tabControlTrace;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxDataType_1;
        private System.Windows.Forms.GroupBox groupBoxEQPIDList_1;
        private System.Windows.Forms.GroupBox groupBoxDCPList_1;
        private System.Windows.Forms.GroupBox groupBoxETC_1;
        private System.Windows.Forms.GroupBox groupBoxTimeAfter_1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButtonTOOLDATA;
        private System.Windows.Forms.RadioButton radioButtonTOOLALARM;
        private System.Windows.Forms.RadioButton radioButtonTOOLEVENTS;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox textBoxTimeAfter_1;
        private System.Windows.Forms.GroupBox groupBoxTimeBefore_1;
        private System.Windows.Forms.TextBox textBoxTimeBefore_1;
        private System.Windows.Forms.GroupBox groupBoxDataType_2;
        private System.Windows.Forms.GroupBox groupBoxEQPIDList_2;
        private System.Windows.Forms.GroupBox groupBoxDCPList_2;
        private System.Windows.Forms.GroupBox groupBoxETC_2;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox textBoxTimeAfter_2;
        private System.Windows.Forms.TextBox textBoxTimeBefore_2;
        private System.Windows.Forms.RichTextBox richTextBoxLink2_1;
        private System.Windows.Forms.RichTextBox richTextBoxLink2_2;
        private System.Windows.Forms.RichTextBox richTextBoxLink2_3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RichTextBox richTextBoxConsumerLog;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ToolStripMenuItem autoToolStripMenuItem;
        private System.Windows.Forms.Button buttonLink2;
        private System.Windows.Forms.Button buttonFind2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.ToolStripMenuItem linkResetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowCurrentLink;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox richTextBoxSoapMessage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox richTextBoxXML;
        private System.Windows.Forms.TreeView treeViewXML;
        private System.Windows.Forms.Button buttonConvertXML;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTreeView;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchClearToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.CheckBox checkBoxHDR;
        private System.Windows.Forms.CheckBox checkBoxTIME_STAMP;
        private System.Windows.Forms.CheckBox checkBoxEQPID;
        private System.Windows.Forms.CheckBox checkBoxLOTID;
        private System.Windows.Forms.CheckBox checkBoxRECPID;
        private System.Windows.Forms.CheckBox checkBoxCARIDMAP;
        private System.Windows.Forms.CheckBox checkBoxFROM_EDA_CONSUMER;
        private System.Windows.Forms.CheckBox checkBoxDCPLANID;
        private System.Windows.Forms.CheckBox checkBoxDCPINTERVAL;
        private System.Windows.Forms.CheckBox checkBoxSAMPLENUMBER;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RichTextBox richTextBoxSkewEQPList;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button buttonSkewLink;
        private System.Windows.Forms.Button buttonSkewCompare;
        private System.Windows.Forms.CheckBox checkBoxSAMPLETIME;
        private System.Windows.Forms.CheckBox checkBoxINNERSAMPLETIME;
        private System.Windows.Forms.CheckBox checkBoxSENSOR_VALUES;
        private System.Windows.Forms.CheckBox checkBoxEES_SERVER_TIME;
        private System.Windows.Forms.CheckBox checkBoxUTC_SERVER_TIME;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.CheckBox checkBoxDCPSplit;
        private System.Windows.Forms.CheckBox checkBoxEnableMsgBox;
    }
}


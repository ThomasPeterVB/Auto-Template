namespace AT3._0.Forms
{
    partial class FormCaseNotes
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
            this.pnlContentHolder = new System.Windows.Forms.Panel();
            this.pnlNotesMain = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowNoteBasicOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMode = new System.Windows.Forms.Label();
            this.cbbMode = new System.Windows.Forms.ComboBox();
            this.lblCid = new System.Windows.Forms.Label();
            this.textCid = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.lblIssue = new System.Windows.Forms.Label();
            this.textIssue = new System.Windows.Forms.TextBox();
            this.lblVerified = new System.Windows.Forms.Label();
            this.cbbVerified = new System.Windows.Forms.ComboBox();
            this.lblStyling = new System.Windows.Forms.Label();
            this.cbbStyling = new System.Windows.Forms.ComboBox();
            this.flowNoteOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.checkCleanReinstall = new System.Windows.Forms.CheckBox();
            this.checkIncognito = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.pnlNotesMainTop = new System.Windows.Forms.Panel();
            this.lblOptions = new System.Windows.Forms.Label();
            this.panelNotesRight = new System.Windows.Forms.Panel();
            this.notesBox = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTemplateBottom = new System.Windows.Forms.Panel();
            this.btnCopyNotes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNotes = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlContentHolder.SuspendLayout();
            this.pnlNotesMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowNoteBasicOptions.SuspendLayout();
            this.flowNoteOptions.SuspendLayout();
            this.pnlNotesMainTop.SuspendLayout();
            this.panelNotesRight.SuspendLayout();
            this.panelTemplateBottom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContentHolder
            // 
            this.pnlContentHolder.Controls.Add(this.pnlNotesMain);
            this.pnlContentHolder.Controls.Add(this.panelNotesRight);
            this.pnlContentHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentHolder.Location = new System.Drawing.Point(0, 0);
            this.pnlContentHolder.Name = "pnlContentHolder";
            this.pnlContentHolder.Padding = new System.Windows.Forms.Padding(10);
            this.pnlContentHolder.Size = new System.Drawing.Size(937, 491);
            this.pnlContentHolder.TabIndex = 0;
            // 
            // pnlNotesMain
            // 
            this.pnlNotesMain.Controls.Add(this.splitContainer1);
            this.pnlNotesMain.Controls.Add(this.pnlNotesMainTop);
            this.pnlNotesMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNotesMain.Location = new System.Drawing.Point(10, 10);
            this.pnlNotesMain.Name = "pnlNotesMain";
            this.pnlNotesMain.Size = new System.Drawing.Size(617, 471);
            this.pnlNotesMain.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowNoteBasicOptions);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowNoteOptions);
            this.splitContainer1.Size = new System.Drawing.Size(617, 441);
            this.splitContainer1.SplitterDistance = 240;
            this.splitContainer1.TabIndex = 1;
            // 
            // flowNoteBasicOptions
            // 
            this.flowNoteBasicOptions.AutoScroll = true;
            this.flowNoteBasicOptions.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.flowNoteBasicOptions.AutoSize = true;
            this.flowNoteBasicOptions.Controls.Add(this.lblMode);
            this.flowNoteBasicOptions.Controls.Add(this.cbbMode);
            this.flowNoteBasicOptions.Controls.Add(this.lblCid);
            this.flowNoteBasicOptions.Controls.Add(this.textCid);
            this.flowNoteBasicOptions.Controls.Add(this.lblUsername);
            this.flowNoteBasicOptions.Controls.Add(this.textUsername);
            this.flowNoteBasicOptions.Controls.Add(this.lblIssue);
            this.flowNoteBasicOptions.Controls.Add(this.textIssue);
            this.flowNoteBasicOptions.Controls.Add(this.lblVerified);
            this.flowNoteBasicOptions.Controls.Add(this.cbbVerified);
            this.flowNoteBasicOptions.Controls.Add(this.lblStyling);
            this.flowNoteBasicOptions.Controls.Add(this.cbbStyling);
            this.flowNoteBasicOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowNoteBasicOptions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowNoteBasicOptions.Location = new System.Drawing.Point(0, 0);
            this.flowNoteBasicOptions.Name = "flowNoteBasicOptions";
            this.flowNoteBasicOptions.Padding = new System.Windows.Forms.Padding(25, 15, 25, 0);
            this.flowNoteBasicOptions.Size = new System.Drawing.Size(240, 441);
            this.flowNoteBasicOptions.TabIndex = 1;
            this.flowNoteBasicOptions.WrapContents = false;
            // 
            // lblMode
            // 
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.lblMode.Location = new System.Drawing.Point(28, 15);
            this.lblMode.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(180, 23);
            this.lblMode.TabIndex = 0;
            this.lblMode.Text = "Mode";
            this.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbMode
            // 
            this.cbbMode.BackColor = System.Drawing.SystemColors.Window;
            this.cbbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbbMode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbbMode.FormattingEnabled = true;
            this.cbbMode.Items.AddRange(new object[] {
            "Default"});
            this.cbbMode.Location = new System.Drawing.Point(28, 46);
            this.cbbMode.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.cbbMode.Name = "cbbMode";
            this.cbbMode.Size = new System.Drawing.Size(180, 21);
            this.cbbMode.TabIndex = 1;
            // 
            // lblCid
            // 
            this.lblCid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.lblCid.Location = new System.Drawing.Point(28, 72);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(180, 23);
            this.lblCid.TabIndex = 2;
            this.lblCid.Text = "CID";
            this.lblCid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textCid
            // 
            this.textCid.Location = new System.Drawing.Point(28, 98);
            this.textCid.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textCid.Name = "textCid";
            this.textCid.Size = new System.Drawing.Size(180, 20);
            this.textCid.TabIndex = 3;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.lblUsername.Location = new System.Drawing.Point(28, 123);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(180, 23);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(28, 154);
            this.textUsername.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(180, 20);
            this.textUsername.TabIndex = 5;
            // 
            // lblIssue
            // 
            this.lblIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.lblIssue.Location = new System.Drawing.Point(28, 179);
            this.lblIssue.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(180, 23);
            this.lblIssue.TabIndex = 6;
            this.lblIssue.Text = "Issue";
            this.lblIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textIssue
            // 
            this.textIssue.Location = new System.Drawing.Point(28, 210);
            this.textIssue.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textIssue.Name = "textIssue";
            this.textIssue.Size = new System.Drawing.Size(180, 20);
            this.textIssue.TabIndex = 7;
            // 
            // lblVerified
            // 
            this.lblVerified.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerified.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.lblVerified.Location = new System.Drawing.Point(28, 235);
            this.lblVerified.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblVerified.Name = "lblVerified";
            this.lblVerified.Size = new System.Drawing.Size(180, 23);
            this.lblVerified.TabIndex = 8;
            this.lblVerified.Text = "Verified";
            this.lblVerified.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbVerified
            // 
            this.cbbVerified.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbVerified.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbbVerified.FormattingEnabled = true;
            this.cbbVerified.Items.AddRange(new object[] {
            "Not Verified",
            "Logged in Verified",
            "Manually Verified",
            "ATO Verified",
            "Chargeback Verified"});
            this.cbbVerified.Location = new System.Drawing.Point(28, 266);
            this.cbbVerified.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.cbbVerified.Name = "cbbVerified";
            this.cbbVerified.Size = new System.Drawing.Size(180, 21);
            this.cbbVerified.TabIndex = 9;
            // 
            // lblStyling
            // 
            this.lblStyling.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStyling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.lblStyling.Location = new System.Drawing.Point(28, 292);
            this.lblStyling.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblStyling.Name = "lblStyling";
            this.lblStyling.Size = new System.Drawing.Size(180, 23);
            this.lblStyling.TabIndex = 10;
            this.lblStyling.Text = "Styling";
            this.lblStyling.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbStyling
            // 
            this.cbbStyling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStyling.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbbStyling.FormattingEnabled = true;
            this.cbbStyling.Items.AddRange(new object[] {
            "Basic"});
            this.cbbStyling.Location = new System.Drawing.Point(28, 323);
            this.cbbStyling.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.cbbStyling.Name = "cbbStyling";
            this.cbbStyling.Size = new System.Drawing.Size(180, 21);
            this.cbbStyling.TabIndex = 11;
            // 
            // flowNoteOptions
            // 
            this.flowNoteOptions.Controls.Add(this.checkCleanReinstall);
            this.flowNoteOptions.Controls.Add(this.checkIncognito);
            this.flowNoteOptions.Controls.Add(this.checkBox3);
            this.flowNoteOptions.Controls.Add(this.checkBox1);
            this.flowNoteOptions.Controls.Add(this.checkBox2);
            this.flowNoteOptions.Controls.Add(this.checkBox4);
            this.flowNoteOptions.Controls.Add(this.checkBox5);
            this.flowNoteOptions.Controls.Add(this.checkBox6);
            this.flowNoteOptions.Controls.Add(this.checkBox7);
            this.flowNoteOptions.Controls.Add(this.checkBox8);
            this.flowNoteOptions.Controls.Add(this.checkBox9);
            this.flowNoteOptions.Controls.Add(this.checkBox10);
            this.flowNoteOptions.Controls.Add(this.checkBox11);
            this.flowNoteOptions.Controls.Add(this.checkBox12);
            this.flowNoteOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowNoteOptions.Location = new System.Drawing.Point(0, 0);
            this.flowNoteOptions.Name = "flowNoteOptions";
            this.flowNoteOptions.Padding = new System.Windows.Forms.Padding(25, 38, 25, 0);
            this.flowNoteOptions.Size = new System.Drawing.Size(373, 441);
            this.flowNoteOptions.TabIndex = 6;
            // 
            // checkCleanReinstall
            // 
            this.checkCleanReinstall.AutoSize = true;
            this.checkCleanReinstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCleanReinstall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.checkCleanReinstall.Location = new System.Drawing.Point(30, 43);
            this.checkCleanReinstall.Margin = new System.Windows.Forms.Padding(5);
            this.checkCleanReinstall.MaximumSize = new System.Drawing.Size(150, 30);
            this.checkCleanReinstall.MinimumSize = new System.Drawing.Size(150, 30);
            this.checkCleanReinstall.Name = "checkCleanReinstall";
            this.checkCleanReinstall.Size = new System.Drawing.Size(150, 30);
            this.checkCleanReinstall.TabIndex = 0;
            this.checkCleanReinstall.Text = "Clean Reinstall";
            this.checkCleanReinstall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkCleanReinstall.UseVisualStyleBackColor = true;
            // 
            // checkIncognito
            // 
            this.checkIncognito.AutoSize = true;
            this.checkIncognito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIncognito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.checkIncognito.Location = new System.Drawing.Point(190, 43);
            this.checkIncognito.Margin = new System.Windows.Forms.Padding(5);
            this.checkIncognito.MaximumSize = new System.Drawing.Size(150, 30);
            this.checkIncognito.MinimumSize = new System.Drawing.Size(150, 30);
            this.checkIncognito.Name = "checkIncognito";
            this.checkIncognito.Size = new System.Drawing.Size(150, 30);
            this.checkIncognito.TabIndex = 1;
            this.checkIncognito.Text = "Incognito";
            this.checkIncognito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkIncognito.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.checkBox3.Location = new System.Drawing.Point(30, 83);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox3.MaximumSize = new System.Drawing.Size(150, 30);
            this.checkBox3.MinimumSize = new System.Drawing.Size(150, 30);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(150, 30);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Changed Email";
            this.checkBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.checkBox1.Location = new System.Drawing.Point(190, 83);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox1.MaximumSize = new System.Drawing.Size(150, 30);
            this.checkBox1.MinimumSize = new System.Drawing.Size(150, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 30);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Other Device";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.checkBox2.Location = new System.Drawing.Point(30, 123);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox2.MaximumSize = new System.Drawing.Size(150, 30);
            this.checkBox2.MinimumSize = new System.Drawing.Size(150, 30);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(150, 30);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Sent Email";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.checkBox4.Location = new System.Drawing.Point(190, 123);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox4.MaximumSize = new System.Drawing.Size(150, 30);
            this.checkBox4.MinimumSize = new System.Drawing.Size(150, 30);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(150, 30);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Closed Account";
            this.checkBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.checkBox5.Location = new System.Drawing.Point(30, 163);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox5.MaximumSize = new System.Drawing.Size(150, 30);
            this.checkBox5.MinimumSize = new System.Drawing.Size(150, 30);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(150, 30);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.Text = "Logout and Reset";
            this.checkBox5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.checkBox6.Location = new System.Drawing.Point(190, 163);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox6.MaximumSize = new System.Drawing.Size(150, 30);
            this.checkBox6.MinimumSize = new System.Drawing.Size(150, 30);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(150, 30);
            this.checkBox6.TabIndex = 7;
            this.checkBox6.Text = "Sent to Bank";
            this.checkBox6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.checkBox7.Location = new System.Drawing.Point(30, 203);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox7.MaximumSize = new System.Drawing.Size(150, 30);
            this.checkBox7.MinimumSize = new System.Drawing.Size(150, 30);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(150, 30);
            this.checkBox7.TabIndex = 8;
            this.checkBox7.Text = "Compensated";
            this.checkBox7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.checkBox8.Location = new System.Drawing.Point(190, 203);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox8.MaximumSize = new System.Drawing.Size(150, 30);
            this.checkBox8.MinimumSize = new System.Drawing.Size(150, 30);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(150, 30);
            this.checkBox8.TabIndex = 9;
            this.checkBox8.Text = "Do Not Engage";
            this.checkBox8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.checkBox9.Location = new System.Drawing.Point(30, 243);
            this.checkBox9.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox9.MaximumSize = new System.Drawing.Size(150, 30);
            this.checkBox9.MinimumSize = new System.Drawing.Size(150, 30);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(150, 30);
            this.checkBox9.TabIndex = 10;
            this.checkBox9.Text = "Terminated";
            this.checkBox9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.checkBox10.Location = new System.Drawing.Point(190, 243);
            this.checkBox10.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox10.MaximumSize = new System.Drawing.Size(150, 30);
            this.checkBox10.MinimumSize = new System.Drawing.Size(150, 30);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(150, 30);
            this.checkBox10.TabIndex = 11;
            this.checkBox10.Text = "Escalated Case";
            this.checkBox10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.checkBox11.Location = new System.Drawing.Point(30, 283);
            this.checkBox11.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox11.MaximumSize = new System.Drawing.Size(150, 30);
            this.checkBox11.MinimumSize = new System.Drawing.Size(150, 30);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(150, 30);
            this.checkBox11.TabIndex = 12;
            this.checkBox11.Text = "Removed Devices";
            this.checkBox11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.checkBox12.Location = new System.Drawing.Point(190, 283);
            this.checkBox12.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox12.MaximumSize = new System.Drawing.Size(150, 30);
            this.checkBox12.MinimumSize = new System.Drawing.Size(150, 30);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(150, 30);
            this.checkBox12.TabIndex = 13;
            this.checkBox12.Text = "Provided Referral";
            this.checkBox12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // pnlNotesMainTop
            // 
            this.pnlNotesMainTop.Controls.Add(this.lblOptions);
            this.pnlNotesMainTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNotesMainTop.Location = new System.Drawing.Point(0, 0);
            this.pnlNotesMainTop.Name = "pnlNotesMainTop";
            this.pnlNotesMainTop.Size = new System.Drawing.Size(617, 30);
            this.pnlNotesMainTop.TabIndex = 0;
            // 
            // lblOptions
            // 
            this.lblOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.lblOptions.Location = new System.Drawing.Point(0, 0);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(617, 30);
            this.lblOptions.TabIndex = 3;
            this.lblOptions.Text = "Options";
            this.lblOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelNotesRight
            // 
            this.panelNotesRight.Controls.Add(this.notesBox);
            this.panelNotesRight.Controls.Add(this.panel2);
            this.panelNotesRight.Controls.Add(this.panelTemplateBottom);
            this.panelNotesRight.Controls.Add(this.panel1);
            this.panelNotesRight.Controls.Add(this.panel6);
            this.panelNotesRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNotesRight.Location = new System.Drawing.Point(627, 10);
            this.panelNotesRight.MaximumSize = new System.Drawing.Size(300, 0);
            this.panelNotesRight.MinimumSize = new System.Drawing.Size(250, 0);
            this.panelNotesRight.Name = "panelNotesRight";
            this.panelNotesRight.Size = new System.Drawing.Size(300, 471);
            this.panelNotesRight.TabIndex = 1;
            // 
            // notesBox
            // 
            this.notesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notesBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesBox.Location = new System.Drawing.Point(0, 48);
            this.notesBox.Name = "notesBox";
            this.notesBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.notesBox.Size = new System.Drawing.Size(275, 393);
            this.notesBox.TabIndex = 0;
            this.notesBox.Text = "Currently in the process of making this a generic notes feature - about 20% done";
            this.notesBox.TextChanged += new System.EventHandler(this.notesBox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 18);
            this.panel2.TabIndex = 5;
            // 
            // panelTemplateBottom
            // 
            this.panelTemplateBottom.BackColor = System.Drawing.SystemColors.Control;
            this.panelTemplateBottom.Controls.Add(this.btnCopyNotes);
            this.panelTemplateBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTemplateBottom.Location = new System.Drawing.Point(0, 441);
            this.panelTemplateBottom.Name = "panelTemplateBottom";
            this.panelTemplateBottom.Size = new System.Drawing.Size(275, 30);
            this.panelTemplateBottom.TabIndex = 3;
            // 
            // btnCopyNotes
            // 
            this.btnCopyNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.btnCopyNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopyNotes.FlatAppearance.BorderSize = 0;
            this.btnCopyNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyNotes.ForeColor = System.Drawing.Color.White;
            this.btnCopyNotes.Location = new System.Drawing.Point(0, 0);
            this.btnCopyNotes.Name = "btnCopyNotes";
            this.btnCopyNotes.Size = new System.Drawing.Size(275, 30);
            this.btnCopyNotes.TabIndex = 6;
            this.btnCopyNotes.Text = "Copy Case Notes";
            this.btnCopyNotes.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblNotes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 30);
            this.panel1.TabIndex = 2;
            // 
            // lblNotes
            // 
            this.lblNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.lblNotes.Location = new System.Drawing.Point(0, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(275, 30);
            this.lblNotes.TabIndex = 2;
            this.lblNotes.Text = "Notes";
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(275, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(25, 471);
            this.panel6.TabIndex = 4;
            // 
            // FormCaseNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 491);
            this.Controls.Add(this.pnlContentHolder);
            this.Name = "FormCaseNotes";
            this.Text = "Case Notes";
            this.Load += new System.EventHandler(this.FormCaseNotes_Load);
            this.pnlContentHolder.ResumeLayout(false);
            this.pnlNotesMain.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowNoteBasicOptions.ResumeLayout(false);
            this.flowNoteBasicOptions.PerformLayout();
            this.flowNoteOptions.ResumeLayout(false);
            this.flowNoteOptions.PerformLayout();
            this.pnlNotesMainTop.ResumeLayout(false);
            this.panelNotesRight.ResumeLayout(false);
            this.panelTemplateBottom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContentHolder;
        private System.Windows.Forms.Panel panelNotesRight;
        private System.Windows.Forms.RichTextBox notesBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTemplateBottom;
        private System.Windows.Forms.Button btnCopyNotes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pnlNotesMain;
        private System.Windows.Forms.Panel pnlNotesMainTop;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowNoteBasicOptions;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.ComboBox cbbMode;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.TextBox textCid;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.TextBox textIssue;
        private System.Windows.Forms.Label lblVerified;
        private System.Windows.Forms.ComboBox cbbVerified;
        private System.Windows.Forms.Label lblStyling;
        private System.Windows.Forms.ComboBox cbbStyling;
        private System.Windows.Forms.FlowLayoutPanel flowNoteOptions;
        private System.Windows.Forms.CheckBox checkCleanReinstall;
        private System.Windows.Forms.CheckBox checkIncognito;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
    }
}
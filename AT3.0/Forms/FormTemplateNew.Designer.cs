namespace AT3._0.Forms
{
    partial class FormTemplateNew
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
            this.panelCtrlHolder = new System.Windows.Forms.Panel();
            this.txtTemplate = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbCategories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlCorner = new System.Windows.Forms.Panel();
            this.pnlContentHolder.SuspendLayout();
            this.panelCtrlHolder.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContentHolder
            // 
            this.pnlContentHolder.Controls.Add(this.panelCtrlHolder);
            this.pnlContentHolder.Controls.Add(this.pnlTop);
            this.pnlContentHolder.Controls.Add(this.pnlLeft);
            this.pnlContentHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentHolder.Location = new System.Drawing.Point(0, 0);
            this.pnlContentHolder.Name = "pnlContentHolder";
            this.pnlContentHolder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlContentHolder.Size = new System.Drawing.Size(284, 461);
            this.pnlContentHolder.TabIndex = 0;
            this.pnlContentHolder.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContentHolder_Paint);
            // 
            // panelCtrlHolder
            // 
            this.panelCtrlHolder.Controls.Add(this.txtTemplate);
            this.panelCtrlHolder.Controls.Add(this.label3);
            this.panelCtrlHolder.Controls.Add(this.buttonSave);
            this.panelCtrlHolder.Controls.Add(this.txtName);
            this.panelCtrlHolder.Controls.Add(this.label2);
            this.panelCtrlHolder.Controls.Add(this.cbbCategories);
            this.panelCtrlHolder.Controls.Add(this.label1);
            this.panelCtrlHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCtrlHolder.Location = new System.Drawing.Point(31, 31);
            this.panelCtrlHolder.Name = "panelCtrlHolder";
            this.panelCtrlHolder.Padding = new System.Windows.Forms.Padding(15);
            this.panelCtrlHolder.Size = new System.Drawing.Size(252, 429);
            this.panelCtrlHolder.TabIndex = 3;
            // 
            // txtTemplate
            // 
            this.txtTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemplate.Location = new System.Drawing.Point(15, 182);
            this.txtTemplate.Name = "txtTemplate";
            this.txtTemplate.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtTemplate.Size = new System.Drawing.Size(222, 192);
            this.txtTemplate.TabIndex = 6;
            this.txtTemplate.Text = "";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.label3.Location = new System.Drawing.Point(15, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "Text";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(113)))), ((int)(((byte)(186)))));
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(15, 374);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(222, 40);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(15, 119);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 23);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbCategories
            // 
            this.cbbCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCategories.FormattingEnabled = true;
            this.cbbCategories.Location = new System.Drawing.Point(15, 55);
            this.cbbCategories.Name = "cbbCategories";
            this.cbbCategories.Size = new System.Drawing.Size(222, 24);
            this.cbbCategories.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(113)))), ((int)(((byte)(186)))));
            this.pnlTop.Controls.Add(this.label4);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(31, 1);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(252, 30);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseDown);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(222, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "New Template";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Xirod", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(222, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.pnlLeft.Controls.Add(this.pnlCorner);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(1, 1);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(30, 459);
            this.pnlLeft.TabIndex = 2;
            // 
            // pnlCorner
            // 
            this.pnlCorner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(56)))), ((int)(((byte)(93)))));
            this.pnlCorner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCorner.Location = new System.Drawing.Point(0, 0);
            this.pnlCorner.Name = "pnlCorner";
            this.pnlCorner.Size = new System.Drawing.Size(30, 30);
            this.pnlCorner.TabIndex = 3;
            this.pnlCorner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseDown);
            // 
            // FormTemplateNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.pnlContentHolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTemplateNew";
            this.Text = "FormTemplateNew";
            this.Load += new System.EventHandler(this.FormTemplateNew_Load);
            this.pnlContentHolder.ResumeLayout(false);
            this.panelCtrlHolder.ResumeLayout(false);
            this.panelCtrlHolder.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContentHolder;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlCorner;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelCtrlHolder;
        private System.Windows.Forms.ComboBox cbbCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtTemplate;
        private System.Windows.Forms.Label label4;
    }
}
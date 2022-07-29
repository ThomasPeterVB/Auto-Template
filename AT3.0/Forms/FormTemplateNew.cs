using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AT3._0.Forms
{
    public partial class FormTemplateNew : Form
    {
        public FormTemplateNew()
        {
            InitializeComponent();
        }
        private FormTemplates mainform;
        private String templateText;
        private Control buttonClicked;
        private List<string> categories;
        private String name;
        private String category;
        int index;
        public FormTemplateNew(Form callingForm, String text, Control buttonClicked, List<string> categories, string name, string category, int index)
        {
            mainform = callingForm as FormTemplates;
            this.templateText = text;
            this.buttonClicked = buttonClicked;
            this.categories = categories;
            this.name = name;
            this.category = category;
            this.index = index;
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FormTemplateNew_Load(object sender, EventArgs e)
        {
            pnlTop.BackColor = ThemeColor.PrimaryColor;
            pnlCorner.BackColor = ThemeColor.SecondaryColor;
            categories.ForEach(category => cbbCategories.Items.Add(category));
            cbbCategories.Text = category;
            txtName.Text = name;
            txtTemplate.Text = templateText;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Drag_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlContentHolder_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.pnlContentHolder.ClientRectangle, Color.FromArgb(25, 25, 48), ButtonBorderStyle.Solid);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (buttonClicked.Text == "Add New Template")
            {
                mainform.SaveNewTemplate(cbbCategories.Text, txtName.Text, txtTemplate.Text);
            }
            else
            {
                mainform.SaveEditedTemplate(cbbCategories.Text, txtName.Text, txtTemplate.Text, index);
            }
            Close();
        }
    }
}

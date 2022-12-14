using System;
using System.Drawing;
using System.Windows.Forms;

namespace AT3._0.Forms
{
    public partial class FormMasking : Form
    {
        public FormMasking()
        {
            InitializeComponent();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        private void FormMasking_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}

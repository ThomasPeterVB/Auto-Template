using System;
using System.Drawing;
using System.Windows.Forms;

namespace AT3._0.Forms
{
    public partial class FormSettings : Form
    {
        public FormSettings()
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
                if (AT.discoMode == true)
                    checkBox1.Checked = true;
            }
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                AT.discoMode = true;
            else
                AT.discoMode = false;
        }
    }
}

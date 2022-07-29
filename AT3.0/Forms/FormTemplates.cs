using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AT3._0.Forms
{
    public partial class FormTemplates : Form
    {
        private Button currentCategory;
        private Button currentOption;
        public DataTable templates { get; set; }
        private List<string> categories;
        ContextMenu categoryMenu = new ContextMenu();
        ContextMenu optionMenu = new ContextMenu();
        public FormTemplates()
        {
            InitializeComponent();
        }
        private void LoadTheme()
        {
            for (int i = 0; i < categories.Count; i++)
            {
                var cat = flowTemplateCategories.Controls;
                cat.Add(new Button());
                cat[i].Text = categories[i].ToString();
                cat[i].Tag = i;
                cat[i].Click += new EventHandler(DynamicCategoryClick);
                cat[i].ContextMenu = categoryMenu;
            }
            StyleButtons(flowTemplateCategories);
            btnAddTemplate.BackColor = ThemeColor.SecondaryColor;
        }
        private void DynamicCategoryClick(object sender, EventArgs e)
        {
            if (sender != null)
            {
                if (currentCategory != (Button)sender)
                {
                    ActivateCategory(sender);
                    Button btn = (Button)sender;
                    int j = 0;
                    flowTemplateOptions.Controls.Clear();
                    for (int i = 0; i < templates.Rows.Count; i++)
                    {
                        if (btn.Text == templates.Rows[i][0].ToString())
                        {
                            var cat = flowTemplateOptions.Controls;
                            cat.Add(new Button());
                            cat[j].Visible = false;
                            cat[j].Text = templates.Rows[i][1].ToString();
                            cat[j].Tag = i;
                            cat[j].Click += new EventHandler(DynamicOptionClick);
                            cat[j].ContextMenu = optionMenu;
                            j++;
                        }
                    }
                    StyleButtons(flowTemplateOptions);
                }
            }
        }
        internal void SaveNewTemplate(String category, String name, String text)
        {
            templates.Rows.Add(category, name, text);
            Properties.Settings.Default.Templates = JsonConvert.SerializeObject(templates);
            saveAndRefresh();
        }
        internal void SaveEditedTemplate(String category, String name, String text, int Index)
        {
            templates.Rows[Index][0] = category;
            templates.Rows[Index][1] = name;
            templates.Rows[Index][2] = text;
            Properties.Settings.Default.Templates = JsonConvert.SerializeObject(templates);
            saveAndRefresh();
        }
        private void StyleButtons(FlowLayoutPanel panel)
        {
            foreach (Control btns in panel.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = Color.FromArgb(25, 25, 48);
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn.Width = 150;
                    btn.Height = 40;
                    btn.Visible = true;
                }
            }
        }
        private void DynamicOptionClick(object sender, EventArgs e)
        {
            if (sender != null)
            {
                if (currentOption != (Button)sender)
                {
                    ActivateOption(sender);
                    Button btn = (Button)sender;
                    int index = (int)btn.Tag;
                    templateBox.Text = templates.Rows[index][2].ToString();
                    Clipboard.SetText(templateBox.Text);
                }
            } 
        }

        private void ActivateOption(object sender)
        {
            if (sender != null)
            {
                if (currentOption != (Button)sender)
                {
                    DisableOption(flowTemplateOptions);
                    Color colour;
                    if (AT.discoMode)
                    {
                        colour = ThemeColor.PrimaryColor;
                    }
                    else
                    {
                        colour = Color.FromArgb(17, 113, 186);
                    }

                    currentOption = (Button)sender;
                    currentOption.BackColor = colour;
                    currentOption.ForeColor = Color.White;
                    currentOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void saveAndRefresh()
        {
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
            flowTemplateOptions.Controls.Clear();
            flowTemplateCategories.Controls.Clear();
            templates = JsonConvert.DeserializeObject<DataTable>(Properties.Settings.Default.Templates);
            FixCategories();
            LoadTheme();
        }

        private void ActivateCategory(Object sender)
        {
            if (sender != null)
            {
                if (currentCategory != (Button)sender)
                {
                    DisableOption(flowTemplateCategories);
                    Color colour;
                    if (AT.discoMode)
                    {
                        colour = ThemeColor.PrimaryColor;
                    }
                    else
                    {
                        colour = Color.FromArgb(17, 113, 186);
                    }

                    currentCategory = (Button)sender;
                    currentCategory.BackColor = colour;
                    currentCategory.ForeColor = Color.White;
                    currentCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableOption(FlowLayoutPanel panel)
        {
            foreach (Control previousBtn in panel.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(25, 25, 48);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }



        private void FormTemplates_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Templates == "start")
            {
                GenerateNewTable();
            } else
            {
                templates = JsonConvert.DeserializeObject<DataTable>(Properties.Settings.Default.Templates);
            }
            FixCategories();
            LoadTheme();
            categoryMenu.MenuItems.Add("Delete", new EventHandler(DeleteCategory_Click));
            optionMenu.MenuItems.Add("Edit", new EventHandler(EditOption_Click));
            optionMenu.MenuItems.Add("Delete", new EventHandler(DeleteOption_Click));
        }

        private void EditOption_Click(object sender, EventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            ContextMenu owner = item.Parent as ContextMenu;
            Button btn = owner.SourceControl as Button;
            string category = "none";
            string text = "";
            int index = 1;
            for (int i = 0; i < templates.Rows.Count; i++)
                if (templates.Rows[i][1].ToString() == btn.Text)
                {
                    category = templates.Rows[i][0].ToString();
                    text = templates.Rows[i][2].ToString();
                    index = i;
                }
            FormTemplateNew frm = new FormTemplateNew(this, text, btn, categories, btn.Text, category, index);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }
        private void DeleteOption_Click(object sender, EventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            ContextMenu owner = item.Parent as ContextMenu;
            string optionName = owner.SourceControl.Text;
            var confirmResult = MessageBox.Show($"This will permanently delete the template.{Environment.NewLine}{Environment.NewLine}Do you want to continue?", "Farewell, template!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int index = new int();
                for (int i = 0; i < templates.Rows.Count; i++)
                {
                    if (templates.Rows[i][1].ToString() == optionName)
                    {
                        index = i;
                    }
                }
                templates.Rows.RemoveAt(index);
                Properties.Settings.Default.Templates = JsonConvert.SerializeObject(templates);
                saveAndRefresh();
            }
        }

        private void DeleteCategory_Click(object sender, EventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            ContextMenu owner = item.Parent as ContextMenu;
            string categoryName = owner.SourceControl.Text;
            var confirmResult = MessageBox.Show($"This will permanently delete the category and all its templates.{Environment.NewLine}{Environment.NewLine}Do you want to continue?","Byebye, category!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                List<int> TBR = new List<int>();
                for (int i = 0; i < templates.Rows.Count; i++)
                {
                    if (templates.Rows[i][0].ToString() == categoryName)
                    {
                        TBR.Add(i);
                    }
                }
                var FixedOrder = TBR.OrderByDescending(x => x).ToList();
                FixedOrder.ForEach(index => templates.Rows.RemoveAt(index));
                Properties.Settings.Default.Templates = JsonConvert.SerializeObject(templates);
                saveAndRefresh();
            }
        }

        private void FixCategories()
        {
            List<string> unsorted = new List<string>();
            for (int i = 0; i < templates.Rows.Count; i++)
            {
                unsorted.Add(templates.Rows[i][0].ToString());
            }
            List<String> sorted = unsorted.Distinct().ToList();
            categories = sorted;
        }

        private void GenerateNewTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Text", typeof(string));
            dt.Rows.Add("How-To", "Add Templates", $"Click the button below this box called \"Add New Template\", which will open a pop-up window{Environment.NewLine}{Environment.NewLine}From here you can either select an existing category from the list, or write a new one!{Environment.NewLine}{Environment.NewLine}Give the template a unique name, and finally write whatever text you want for your template. Once you hit save you're good to go!{Environment.NewLine}{Environment.NewLine}This program can hold a near-infinite amount of templates, so go wild~ ");
            dt.Rows.Add("How-To", "Edit Templates", $"Right click any template in the Options section and click on Edit - this will open up a window for you to edit it to your liking. Don't forget to hit save!");
            dt.Rows.Add("How-To", "Delete Templates", $"Simply right click any template, click delete, and confirm :)");
            dt.Rows.Add("How-To", "Delete Categories", $"Simply right click any category, click delete, and confirm!{Environment.NewLine}{Environment.NewLine}Do note that this will also delete all associated templates, so do be careful (and no, there is no way to restore them)");
            dt.Rows.Add("How-To", "Quickly Copy", $"Gotcha covered, the moment you click an option, its text is automatically copied under your cursor{Environment.NewLine}{Environment.NewLine}It really only shows in the box to show you what you've copied, and if you want to make edits safely before pasting it elsewhere :)");
            templates = dt;
            Properties.Settings.Default.Templates = JsonConvert.SerializeObject(dt);
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
        }

        private void btnAddTemplate_Click(object sender, EventArgs e)
        {
            FormTemplateNew frm = new FormTemplateNew(this, "", (Control)sender, categories, "Name your Template", "Select From List or Write New", 0);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }
    }

}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AT3._0.Forms
{
    public partial class FormCaseNotes : Form
    {
        private List<string> options = new List<string>();
        public FormCaseNotes()
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
            foreach (Control cbx in this.Controls)
            {
                int count = 0;
                if (cbx.GetType() == typeof(CheckBox))
                {
                    CheckBox chk = (CheckBox)cbx;
                    chk.CheckedChanged += new EventHandler(NoteStepTaken_CheckedChanged);
                    chk.Text = options[count];
                    count++;
                }
            }
            //Will re-add the dynamic functionality later, only have time to remove the confidential info right now
            //flowNoteOptions.Controls.Clear();
            //for (int i = 0; i < options.Count; i++)
            //{
            //    var fno = flowNoteOptions.Controls;
            //    var cBox = new CheckBox();
            //    cBox.Text = options[i];
            //    cBox.CheckedChanged += new EventHandler(NoteStepTaken_CheckedChanged);
            //    cBox.Tag = i;
            //    fno.Add(cBox);
            //}
            btnCopyNotes.BackColor = ThemeColor.SecondaryColor;
            
        }

        private void NoteStepTaken_CheckedChanged(object sender, EventArgs e)
        {
            //will re-add when I have time to remove the confidential info
        }

        private void FormCaseNotes_Load(object sender, EventArgs e)
        {
            cbbMode.SelectedIndex = 0;
            cbbStyling.SelectedIndex = 0;
            if (Properties.Settings.Default.CNOptions == "start")
            {
                GenerateNewList();
                LoadTheme();
                return;
            }

            var optionlist = JsonConvert.DeserializeObject<List<string>>(Properties.Settings.Default.CNOptions);
            foreach (string o in optionlist)
                options.Add(o);

            LoadTheme();
        }

        private void GenerateNewList()
        {
            List<string> newOptions = new List<string> { "Clean Reinstall", "Changed Email", "Sent [Redacted]", "Log out and Reset", "Compensated", "Terminated", "Removed Devices", "Incognito", "Other Device", "Closed Account", "Sent to Bank", "Do Not Engage", "Escalated Case", "Provided Referral"};
            options = newOptions;
            Properties.Settings.Default.CNOptions = JsonConvert.SerializeObject(options);
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
        }

        private void notesBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

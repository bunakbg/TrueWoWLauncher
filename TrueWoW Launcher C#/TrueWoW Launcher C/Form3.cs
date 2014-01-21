using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrueWoW_Launcher
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void wowPathBrowseButton_Click(object sender, EventArgs e)
        {
            DialogResult answer = folderBrowserDialog.ShowDialog();
            if (answer == DialogResult.OK)
            {
                wowPathInput.Text = folderBrowserDialog.SelectedPath + "\\";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (wowPathInput.Text != "")
            {
                if (System.IO.File.Exists(wowPathInput.Text + "\\wow.exe") == true)
                {
                    WriteSettingsFile xmlWrite = new WriteSettingsFile();
                    xmlWrite.Load();

                    xmlWrite.SetWoWPath(wowPathInput.Text);
                    if (startUpSoundCheckBox.Checked == true)
                    {
                        xmlWrite.SetStartUpSound(true);
                    }
                    else
                    {
                        xmlWrite.SetStartUpSound(false);
                    }

                    if (minimizeToTrayCheckBox.Checked == true)
                    {
                        xmlWrite.MinimizeToTray(true);
                    }
                    else
                    {
                        xmlWrite.MinimizeToTray(false);
                    }

                    Form3.ActiveForm.Hide();
                }
                else
                {
                    MessageBox.Show("ERROR: can't find wow.exe in: \n\n '" + wowPathInput.Text + "\' \n\n Please choose another directory.", "Error!");
                }
            }
            else
            {
                ToolTip errorTip = new ToolTip();
                errorTip.IsBalloon = true;
                errorTip.Show("Field cannot be empty!", wowPathInput, 5, -35, 1500);
                //wowPathInput.
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner.Name == "mainForm")
            {
                this.Close();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void Form3_Shown(object sender, EventArgs e)
        {
            if (this.Owner.Name == "mainForm")
            {
                ReadSettingsFile settingsFile = new ReadSettingsFile();
                settingsFile.Read();
                wowPathInput.Text = settingsFile.wowPath();
                startUpSoundCheckBox.Checked = settingsFile.startUpSound();
                minimizeToTrayCheckBox.Checked = settingsFile.minimizeToTray();
            }
        }
    }
}

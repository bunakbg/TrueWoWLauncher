using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.Net.NetworkInformation;

using System.Runtime.InteropServices;
using System.IO;
namespace TrueWoW_Launcher
{
    public partial class updateForm : Form
    {
        ReadSettingsFile settingsFile = new ReadSettingsFile();
        double currentVersion = 0.1;
        double serverVersion = 0;

        public updateForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            Environment.Exit(0);
        }

        public static bool PingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = new Ping();

            try
            {
                PingReply reply = pinger.Send(nameOrAddress);

                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
            }

            return pingable;
        }

        private void updateForm_Shown(object sender, EventArgs e)
        {
            //read local settings
            settingsFile.Read();

            if (settingsFile.wowPath() == "null")
            {
                Form3 wowPathForm = new Form3();
                wowPathForm.ShowDialog(this);
            }

            //check server status
            bool serverReply = PingHost(settingsFile.serverAddress());
            if (serverReply == false)
            {
                MessageBox.Show("ERROR: {0} or Your internet connectionis down. Exiting ...", settingsFile.serverAddress());
                Environment.Exit(0);
            }
            this.Refresh();

            //check for update
            backgroundWorker1.RunWorkerAsync();
        }

        private void ShowMain()
        {
            var activeForm = Form.ActiveForm;
            using (var dlg = new mainForm())
            {
                dlg.FormClosing += delegate { activeForm.Show(); };
                activeForm.Hide();
            }
            mainForm mainForm = new mainForm();
            mainForm.Show();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorker1.ReportProgress(0);
            settingsFile.Read();
            WebClient _dlClient = new WebClient();
            try
            {
                _dlClient.DownloadFile("http://" + settingsFile.serverAddress() + "/launcher/update.xml", @Directory.GetCurrentDirectory() + "\\update.txt");
                backgroundWorker1.ReportProgress(50);
            }
            catch (WebException)
            {
                MessageBox.Show("ERROR: can't download update.xml from \n\n " + settingsFile.serverAddress() + " \n\n Concidering it's up to date.");
                serverVersion = currentVersion;
            }
            backgroundWorker1.ReportProgress(100);
       }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            statusLabel.Text = "checking for update ...";
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (serverVersion == 0)
            {
                Double.TryParse(File.ReadAllText(@Directory.GetCurrentDirectory() + "\\update.txt"), out serverVersion);
                //MessageBox.Show(serverVersion);
            }
            if (serverVersion > currentVersion)
            {
                MessageBox.Show("new ver ava");
            }
            else
            {
                MessageBox.Show("up tu date");
            }
            ShowMain();
        }
    }
}


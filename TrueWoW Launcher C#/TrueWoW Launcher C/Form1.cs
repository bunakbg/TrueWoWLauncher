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
using System.Threading;
using System.Reflection;
namespace TrueWoW_Launcher
{
    public partial class updateForm : Form
    {

        private delegate void SetControlPropertyThreadSafeDelegate(Control control, string propertyName, object propertyValue);

        ReadSettingsFile settingsFile = new ReadSettingsFile();

        double currentVersion = 0.1;
        double serverVersion = 0;
        bool labelUpdateLoopRun = true;
        int updateLabelStep = 1;
        
        public updateForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (updateLabelStep == 1)
            {
                Environment.Exit(0);
            }
            else
            {
                ShowMain();
            }
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
            statusLabel.Text = "checking for update";
            this.Refresh();

            //check for update
            updateLabelLoopWorker.RunWorkerAsync();
            updateBackgroundDownloader.RunWorkerAsync();  
        }

        private void ShowMain()
        {
            var activeForm = this;
            using (var dlg = new mainForm())
            {
                dlg.FormClosing += delegate { activeForm.Show(); };
                activeForm.Hide();
            }
            mainForm mainForm = new mainForm();
            mainForm.Show();
        }    

        private void updateLabelLoopWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int loopCount = 0;
            while (labelUpdateLoopRun == true)
            {
                loopCount++;
                if (loopCount > 3) { loopCount = 1; }
                updateLabelLoopWorker.ReportProgress(loopCount);
                System.Threading.Thread.Sleep(150);
            }
        }

        private void updateLabelLoopWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (updateLabelStep == 1)
            {
                if (e.ProgressPercentage == 1) { statusLabel.Text = "checking for update ."; }
                if (e.ProgressPercentage == 2) { statusLabel.Text = "checking for update .."; }
                if (e.ProgressPercentage == 3) { statusLabel.Text = "checking for update ..."; }
            }
            else if (updateLabelStep == 2)
            {
                if (e.ProgressPercentage == 1) { statusLabel.Text = "downloading news ."; }
                if (e.ProgressPercentage == 2) { statusLabel.Text = "downloading news .."; }
                if (e.ProgressPercentage == 3) { statusLabel.Text = "downloading news ..."; }
            }     
        } 

        private void _dlClientUpdate_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Thread.Sleep(10);
            //progressBar1.Value = e.ProgressPercentage;
            SetControlPropertyThreadSafe(progressBar1, "Value", e.ProgressPercentage);
            //if (e.ProgressPercentage == 100) { MessageBox.Show("100"); }
        }

        private void _dlClientNews_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Thread.Sleep(10);
            //progressBar1.Value = e.ProgressPercentage;
            SetControlPropertyThreadSafe(progressBar1, "Value", e.ProgressPercentage);
        }

        public static void SetControlPropertyThreadSafe(Control control, string propertyName, object propertyValue)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new SetControlPropertyThreadSafeDelegate(SetControlPropertyThreadSafe), new object[] { control, propertyName, propertyValue });
            }
            else
            {
                control.GetType().InvokeMember(propertyName, BindingFlags.SetProperty, null, control, new object[] { propertyValue });
            }
        }

        private void updateBackgroundDownloader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            updateLabelLoopWorker.CancelAsync();
            labelUpdateLoopRun = false;
            statusLabel.Text = "reading update ...";

            if (serverVersion == 0)
            {
                FileStream fs = File.OpenRead(@Directory.GetCurrentDirectory() + "\\update.txt");
                BinaryReader reader = new BinaryReader(fs);
                //MessageBox.Show(serverVersion.ToString());
            }
            if (serverVersion > currentVersion)
            {
                statusLabel.Text = "new update found!";
                //MessageBox.Show("new ver ava");
            }
            else
            {
                statusLabel.Text = "up to date!";
                progressBar1.Value = 100;
                //MessageBox.Show("up tu date");
            }

            this.Refresh();
            updateLabelStep = 2;
            labelUpdateLoopRun = true;

            newsBackgroundDownloader.RunWorkerAsync();

            while (updateLabelLoopWorker.IsBusy == true)
            {
                Application.DoEvents();
            }
            updateLabelLoopWorker.RunWorkerAsync();
        }

        private void updateBackgroundDownloader_DoWork(object sender, DoWorkEventArgs e)
        {
            settingsFile.Read();

            WebClient _dlClient = new WebClient();
            _dlClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(_dlClientUpdate_DownloadProgressChanged);

            try
            {
                _dlClient.DownloadFileAsync(new Uri("http://" + settingsFile.serverAddress() + "/launcher/update.xml"), @Directory.GetCurrentDirectory() + "\\update.txt");
            }
            catch (WebException)
            {
                MessageBox.Show("ERROR: can't download update.xml from \n\n " + settingsFile.serverAddress() + " \n\n Concidering it's up to date.");
                serverVersion = currentVersion;
            }
            //sleep thread untill _dlClient finishes, cause worker finishes before _dbClient and file is still not d/l-ed ot locked.
            while (_dlClient.IsBusy)
            {
                Thread.Sleep(10);
            }
        }

        private void newsBackgroundDownloader_DoWork(object sender, DoWorkEventArgs e)
        {
            settingsFile.Read();
            if (File.Exists(@Directory.GetCurrentDirectory() + "\\news\\") == false)
            {
                Directory.CreateDirectory(@Directory.GetCurrentDirectory() + "\\news\\");
            }
            WebClient _dlClient = new WebClient();
            _dlClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(_dlClientNews_DownloadProgressChanged);
            try
            {
                _dlClient.DownloadFileAsync(new Uri("http://" + settingsFile.serverAddress() + "/launcher/news.zip"), @Directory.GetCurrentDirectory() + "\\news\\news.zip");
            }
            catch (WebException)
            {
                MessageBox.Show("ERROR: can't download update.xml from \n\n " + settingsFile.serverAddress() + " \n\n Concidering it's up to date.");
                serverVersion = currentVersion;
            }
            //sleep thread untill _dlClient finishes, cause worker finishes before _dbClient and file is still not d/l-ed ot locked.
            while (_dlClient.IsBusy)
            {
                Thread.Sleep(10);
            }
        }

        private void newsBackgroundDownloader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            updateLabelLoopWorker.CancelAsync();
            labelUpdateLoopRun = false;
            ShowMain();         
        }
    }
}


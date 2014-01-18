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
namespace TrueWoW_Launcher
{
    public partial class updateForm : Form
    {

        public updateForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
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
            ReadSettingsFile settingsFile = new ReadSettingsFile();
            settingsFile.Read("localsettings.xml");

            //check server status
            bool serverReply = PingHost(settingsFile.serverAddress());
            if (serverReply == false)
            {
                MessageBox.Show("ERROR: " + settingsFile.serverAddress() + " or Your internet connectionis down. Exiting ...");
            }
            else
            {
                //MessageBox.Show("ok");
            }
            //check for update, read settings, find wow.exe etc.
        }
    }
}

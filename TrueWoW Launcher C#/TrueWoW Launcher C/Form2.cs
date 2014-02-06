using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;
using System.IO;
using System.IO.Compression;

//for DLL's
using System.Runtime.InteropServices;
using System.Media;

namespace TrueWoW_Launcher
{
    public partial class mainForm : Form
    {
        

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            
        }

        News readedNews = new News();
        ReadSettingsFile settingsFile = new ReadSettingsFile();
        int newsSelectorHistory = 0;
        public List<Label> newsSelector = new List<Label>();

        //SereniaBLPLib.BlpFile blpLoader;
        //Bitmap loadedBLP;
        //Bitmap playButtonBitmap;


        //const and dll functions for moving form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //call functions to move the form in your form's MouseDown event
        private void MoveForm(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void tueWowLogo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.truewow.org");
        }

        private void mainForm_Shown(object sender, EventArgs e)
        {
            //morhpeus font for prettier labels. not mandatory
            //MorpheusFont morpheusFont = new MorpheusFont();
            //morpheusFont.Load();
            //playButtonLabel.Font = new Font(morpheusFont.fontFamily(), 12, FontStyle.Regular);

            settingsFile.Read();
            if (settingsFile.startUpSound() == true)
            {
                WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
                player.URL = @Directory.GetCurrentDirectory() + "\\sound\\startup.mp3";
                player.controls.play();
            }

            //change control properties on runtime
            //upArrowPicture.Parent = newsTextLabel;
            //upArrowPicture.Location = new Point(436, -2);
            //downArrowPicture.Parent = newsTextLabel;
            //downArrowPicture.Location = new Point(436, 73);

            trayIcon.BalloonTipTitle = "TrueWoW Launcher";
            trayIcon.BalloonTipText = "Launcher minimized to tray. Right click icon for menu.";
            if (settingsFile.minimizeToTray() == true)
            {
                trayIcon.Visible = true;
            }
            else
            {
                trayIcon.Visible = false;
            }
            #region BLP-TEST
            //try
            //{
            //    if (this.blpLoader != null)
            //    {
            //        this.blpLoader.close();
            //        this.blpLoader = null;
            //    }

            //    FileStream file = new FileStream("example.blp", FileMode.Open);
            //    this.blpLoader = new SereniaBLPLib.BlpFile(file);
                



                
            //    // loading bitmap level 0
            //    loadedBLP = this.blpLoader.getBitmap(0);
            //    Rectangle imgDimensions = new Rectangle();
            //    imgDimensions.Location = new Point(50, 15);
            //    imgDimensions.Width = 155;
            //    imgDimensions.Height = 32;

            //    playButtonBitmap = loadedBLP.Clone(imgDimensions, loadedBLP.PixelFormat);
            //    playButton.Image = playButtonBitmap;

            //    if (this.blpLoader != null)
            //    {
            //        this.blpLoader.close();
            //        this.blpLoader = null;
            //    }

            //    file.Close();
            //    file = new FileStream("Glues-BigButton-Glow.blp", FileMode.Open);
            //    this.blpLoader = new SereniaBLPLib.BlpFile(file);

            //    loadedBLP = this.blpLoader.getBitmap(0);
            //    imgDimensions = new Rectangle();
            //    imgDimensions.Location = new Point(43, 7);
            //    imgDimensions.Width = 170;
            //    imgDimensions.Height = 50;

            //    playButtonBitmap = loadedBLP.Clone(imgDimensions, loadedBLP.PixelFormat);
            //    playButtonHoover.Image = playButtonBitmap;

            //}
            //catch (FileNotFoundException fe)
            //{
            //    MessageBox.Show("The 'example.blp' was not found!");
            //}
            #endregion

            //read data inside zip
            ZipStorer newsZIP = ZipStorer.Open(@Directory.GetCurrentDirectory() + "\\news\\news.zip", FileAccess.Read);

            // Read all directory contents
            List<ZipStorer.ZipFileEntry> dir = newsZIP.ReadCentralDir();

            // Extract all files in target directory
            string path;
            bool result;
            foreach (ZipStorer.ZipFileEntry entry in dir)
            {
                path = Path.Combine(@Directory.GetCurrentDirectory() + "\\news\\", Path.GetFileName(entry.FilenameInZip));
                result = newsZIP.ExtractFile(entry, path);
            }
            newsZIP.Close();

            this.Refresh();

            readedNews.Read();

            
            
            for (int i = 0; i < readedNews.newsCount(); i++)
            {
                Label tmpControl = new Label();
                if (i == 0)
                {
                    tmpControl.BackColor = System.Drawing.Color.Aqua;
                }
                else
                {
                    tmpControl.BackColor = System.Drawing.Color.Gray;
                }
                tmpControl.Cursor = System.Windows.Forms.Cursors.Hand;
                tmpControl.Name = "newsSelector" + i.ToString();
                //tmpControl. = "newsSelector" + i.ToString();
                tmpControl.Size = new System.Drawing.Size(10, 10);
                tmpControl.Click += new System.EventHandler(this.newsSelectorSelected_Click);
                this.Controls.Add(tmpControl);
                tmpControl.Parent = this.newsPicture;
                tmpControl.Location = new System.Drawing.Point((3 + (i * 16)), 3);
                newsSelector.Add(tmpControl);
            }

            newsPicture.ImageLocation = @Directory.GetCurrentDirectory() + "\\news\\" + readedNews.newsImg(0);
            newsTittleLabel.Text = readedNews.newsTittle(0);
            newsTextLabel.Text = readedNews.newsText(0);
            newsSelectorHistory = 0;

            newsLoopWorker.RunWorkerAsync();
        }

        private void playButtonLabel_MouseHover(object sender, EventArgs e)
        {
            MouseOverSound();
        }

        private void playButton_MouseDown(object sender, MouseEventArgs e)
        {
            playButton.Location = new Point(playButton.Location.X + 1, playButton.Location.Y + 1);
            SoundPlayer sPlayer = new SoundPlayer();
            sPlayer.SoundLocation = @Directory.GetCurrentDirectory() + "\\sound\\playButtonClick.wav";
            sPlayer.Play();
            //playButton.Location = new Point(playButton.Location.X + 1, playButton.Location.Y + 1);
        }

        private void playButton_MouseUp(object sender, MouseEventArgs e)
        {
            playButton.Location = new Point(playButton.Location.X - 1, playButton.Location.Y - 1);
            //playButton.Location = new Point(playButton.Location.X - 1, playButton.Location.Y - 1);
        }

        private void upArrowPicture_MouseDown(object sender, MouseEventArgs e)
        {
            upArrowPicture.Image = Image.FromFile(@Directory.GetCurrentDirectory() + "\\img\\upArrowDown.png");
            SoundPlayer sPlayer = new SoundPlayer();
            sPlayer.SoundLocation = @Directory.GetCurrentDirectory() + "\\sound\\mouseClick.wav";
            sPlayer.Play();
        }

        private void upArrowPicture_MouseUp(object sender, MouseEventArgs e)
        {
            upArrowPicture.Image = Image.FromFile(@Directory.GetCurrentDirectory() + "\\img\\upArrowUp.png");
        }

        private void downArrowPicture_MouseDown(object sender, MouseEventArgs e)
        {
            downArrowPicture.Image = Image.FromFile(@Directory.GetCurrentDirectory() + "\\img\\downArrowDown.png");
            SoundPlayer sPlayer = new SoundPlayer();
            sPlayer.SoundLocation = @Directory.GetCurrentDirectory() + "\\sound\\mouseClick.wav";
            sPlayer.Play();
        }

        private void downArrowPicture_MouseUp(object sender, MouseEventArgs e)
        {
            downArrowPicture.Image = Image.FromFile(@Directory.GetCurrentDirectory() + "\\img\\downArrowUp.png");
        }

        private void newsSelectorSelected_Click(object sender, EventArgs e)
        {
            SoundPlayer sPlayer = new SoundPlayer();
            sPlayer.SoundLocation = @Directory.GetCurrentDirectory() + "\\sound\\newsSelectorClick.wav";
            sPlayer.Play();

            readedNews.Read();

            newsSelector[newsSelectorHistory].BackColor = Color.Gray;

            Label senderLabel = (Label)sender;
            int controlNo = int.Parse(senderLabel.Name.Replace("newsSelector", ""));
            senderLabel.BackColor = Color.Aqua;

            newsPicture.ImageLocation = @Directory.GetCurrentDirectory() + "\\news\\" + readedNews.newsImg(controlNo);
            newsTittleLabel.Text = readedNews.newsTittle(controlNo);
            newsTextLabel.Text = readedNews.newsText(controlNo);

            newsSelectorHistory = controlNo;
        }

        private void menuButton1_MouseDown(object sender, MouseEventArgs e)
        {
            menuButton1.Location = new Point(menuButton1.Location.X + 1, menuButton1.Location.Y + 1);
            MouseClickSound();
        }

        private void menuButton1_MouseUp(object sender, MouseEventArgs e)
        {
            menuButton1.Location = new Point(menuButton1.Location.X - 1, menuButton1.Location.Y - 1);
        }

        private void menuButton1_MouseHover(object sender, EventArgs e)
        {
            MouseOverSound();
        }

        private void menuButton1_Click(object sender, EventArgs e)
        {
            var activeForm = this;
            using (var dlg = new mainForm())
            {
                dlg.FormClosing += delegate { activeForm.Show(); };
                //activeForm.Hide();
            }
            Form3 settingsForm = new Form3();
            settingsForm.ShowDialog(this);
        }

        private void menuButton2_MouseDown(object sender, MouseEventArgs e)
        {
            menuButton2.Location = new Point(menuButton2.Location.X + 1, menuButton2.Location.Y + 1);
            MouseClickSound();
        }

        private void menuButton2_MouseUp(object sender, MouseEventArgs e)
        {
            menuButton2.Location = new Point(menuButton2.Location.X - 1, menuButton2.Location.Y - 1);
        }

        private void menuButton2_MouseHover(object sender, EventArgs e)
        {
            MouseOverSound();
        }

        private void menuButton3_MouseDown(object sender, MouseEventArgs e)
        {
            menuButton3.Location = new Point(menuButton3.Location.X + 1, menuButton3.Location.Y + 1);
            MouseClickSound();
        }

        private void menuButton3_MouseUp(object sender, MouseEventArgs e)
        {
            menuButton3.Location = new Point(menuButton3.Location.X - 1, menuButton3.Location.Y - 1);
        }

        private void menuButton3_MouseHover(object sender, EventArgs e)
        {
            MouseOverSound();
        }

        private void menuButton4_MouseDown(object sender, MouseEventArgs e)
        {
            menuButton4.Location = new Point(menuButton4.Location.X + 1, menuButton4.Location.Y + 1);
            MouseClickSound();
        }

        private void menuButton4_MouseUp(object sender, MouseEventArgs e)
        {
            menuButton4.Location = new Point(menuButton4.Location.X - 1, menuButton4.Location.Y - 1);
        }

        private void menuButton4_MouseHover(object sender, EventArgs e)
        {
            MouseOverSound();
        }

        private void menuButton5_MouseDown(object sender, MouseEventArgs e)
        {
            menuButton5.Location = new Point(menuButton5.Location.X + 1, menuButton5.Location.Y + 1);
            MouseClickSound();
        }

        private void menuButton5_MouseUp(object sender, MouseEventArgs e)
        {
            menuButton5.Location = new Point(menuButton5.Location.X - 1, menuButton5.Location.Y - 1);
        }

        private void menuButton5_MouseHover(object sender, EventArgs e)
        {
            MouseOverSound();
        }

        private void menuButton6_MouseDown(object sender, MouseEventArgs e)
        {
            menuButton6.Location = new Point(menuButton6.Location.X + 1, menuButton6.Location.Y + 1);
            MouseClickSound();
        }

        private void menuButton6_MouseUp(object sender, MouseEventArgs e)
        {
            menuButton6.Location = new Point(menuButton6.Location.X - 1, menuButton6.Location.Y - 1);
        }

        private void menuButton6_MouseHover(object sender, EventArgs e)
        {
            MouseOverSound();
        }

        private void playButton_Click_1(object sender, EventArgs e)
        {
            ReadSettingsFile readedSettings = new ReadSettingsFile();
            readedSettings.Read();
            if (readedSettings.wowPath() == "" || readedSettings.wowPath() == null)
            {
                MessageBox.Show("WoW dir not set! Configure it in settings menu.");
            }
            else
            {
                try
                {
                    System.Diagnostics.Process.Start(readedSettings.wowPath() + "wow.exe");
                    this.Hide();
                    trayIcon.Visible = true;
                    trayIcon.ShowBalloonTip(1000);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("ERROR: can't find wow.exe in: \n\n '" + readedSettings.wowPath() + "' \n\n Use settings button to set World of Warcraft directory!", "Error!");
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show("ERROR: can't find wow.exe in: \n\n '" + readedSettings.wowPath() + "' \n\n Use settings button to set World of Warcraft directory!", "Error!");
                }
            }
        }

        private void closeButton_MouseHover(object sender, EventArgs e)
        {
            closeButton.Location = new Point(closeButton.Location.X - 2, closeButton.Location.Y - 2);
            closeButton.Size = new Size(closeButton.Size.Width + 4, closeButton.Size.Height + 4);
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.Size = new Size(32, 32);
            closeButton.Location = new Point(729, 12);
        }

        private void closeButton_MouseDown(object sender, MouseEventArgs e)
        {
            closeButton.Location = new Point(closeButton.Location.X + 1, closeButton.Location.Y + 1);
        }

        private void closeButton_MouseUp(object sender, MouseEventArgs e)
        {
            closeButton.Location = new Point(closeButton.Location.X - 1, closeButton.Location.Y - 1);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            settingsFile.Read();
            if (settingsFile.minimizeToTray() == true)
            {
                this.Hide();
                trayIcon.Visible = true;
                trayIcon.ShowBalloonTip(1000);
            }
            else
            {
                trayIcon.Visible = false;
                Environment.Exit(0);
            }
        }

        private void MouseOverSound()
        {
            SoundPlayer sPlayer = new SoundPlayer();
            sPlayer.SoundLocation = @Directory.GetCurrentDirectory() + "\\sound\\mouseOver.wav";
            sPlayer.Play();
        }
        private void MouseClickSound()
        {
            SoundPlayer sPlayer = new SoundPlayer();
            sPlayer.SoundLocation = @Directory.GetCurrentDirectory() + "\\sound\\mouseClick.wav";
            sPlayer.Play();
        }

        private void trayMenuExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void trayMenuShowLauncher_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void trayMenuCheckForUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In development ...");
        }

        private void trayIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        private void newsLoopWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                System.Threading.Thread.Sleep(5000);
                newsLoopWorker.ReportProgress(1);
            }
        }

        private void newsLoopWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            readedNews.Read();

            newsSelector[newsSelectorHistory].BackColor = Color.Gray;

            newsSelectorHistory++;
            if (newsSelectorHistory >= readedNews.newsCount()) { newsSelectorHistory = 0; }

            newsSelector[newsSelectorHistory].BackColor = Color.Aqua;

            newsPicture.ImageLocation = @Directory.GetCurrentDirectory() + "\\news\\" + readedNews.newsImg(newsSelectorHistory);
            newsTittleLabel.Text = readedNews.newsTittle(newsSelectorHistory);
            newsTextLabel.Text = readedNews.newsText(newsSelectorHistory);
        }

        private void newsLoopWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void newsTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void newsTittleLabel_Click(object sender, EventArgs e)
        {
            readedNews.Read();
            System.Diagnostics.Process.Start(readedNews.newsLink(newsSelectorHistory));
        }

        private void menuButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon!");
        }

        private void menuButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No function yet!");
        }

        private void menuButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No function yet!");
        }

        private void menuButton6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No function yet!");
        }
    }
}

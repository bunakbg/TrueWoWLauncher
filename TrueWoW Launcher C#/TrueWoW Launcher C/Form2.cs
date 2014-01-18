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
            //MorpheusFont morpheusFont = new MorpheusFont();
            //morpheusFont.Load();
            //playButtonLabel.Font = new Font(morpheusFont.fontFamily(), 12, FontStyle.Regular);

            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            player.URL = @Directory.GetCurrentDirectory() + "\\sound\\startup.mp3";
            player.controls.play();
            playButtonHoover.Hide();
            upArrowPicture.Parent = newsTextLabel;
            upArrowPicture.Location = new Point(439, -2);
            downArrowPicture.Parent = newsTextLabel;
            downArrowPicture.Location = new Point(439, 72);

        }

        private void playButtonLabel_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer sPlayer = new SoundPlayer();
            sPlayer.SoundLocation = @Directory.GetCurrentDirectory() + "\\sound\\mouseOver.wav";
            sPlayer.Play();

            playButtonHoover.Hide();
            playButton.Parent = playButtonHoover;
            playButton.Location = new Point(7, 11);
            //playButton.Image.
        }

        private void playButton_MouseDown(object sender, MouseEventArgs e)
        {
            playButtonHoover.Location = new Point(playButtonHoover.Location.X + 1, playButtonHoover.Location.Y + 1);
            SoundPlayer sPlayer = new SoundPlayer();
            sPlayer.SoundLocation = @Directory.GetCurrentDirectory() + "\\sound\\playButtonClick.wav";
            sPlayer.Play();
            //playButton.Location = new Point(playButton.Location.X + 1, playButton.Location.Y + 1);
        }

        private void playButton_MouseUp(object sender, MouseEventArgs e)
        {
            playButtonHoover.Location = new Point(playButtonHoover.Location.X - 1, playButtonHoover.Location.Y - 1);
            //playButton.Location = new Point(playButton.Location.X - 1, playButton.Location.Y - 1);
        }

        private void playButton_MouseHover(object sender, EventArgs e)
        {
            playButtonHoover.Show();
            playButton.Parent = playButtonHoover;
            playButton.Location = new Point(7, 11);
        }

        private void playButton_MouseLeave(object sender, EventArgs e)
        {
            playButtonHoover.Hide();
            playButton.Parent = mainForm.ActiveForm;
            playButton.Location = new Point(694, 476);
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

        private void newsSelectorUnselected_Click(object sender, EventArgs e)
        {
            SoundPlayer sPlayer = new SoundPlayer();
            sPlayer.SoundLocation = @Directory.GetCurrentDirectory() + "\\sound\\newsSelectorClick.wav";
            sPlayer.Play();
        }

        private void menuButton1_MouseDown(object sender, MouseEventArgs e)
        {
            menuButton1.Location = new Point(menuButton1.Location.X + 1, menuButton1.Location.Y + 1);
            SoundPlayer sPlayer = new SoundPlayer();
            sPlayer.SoundLocation = @Directory.GetCurrentDirectory() + "\\sound\\mouseClick.wav";
            sPlayer.Play();
        }

        private void menuButton1_MouseUp(object sender, MouseEventArgs e)
        {
            menuButton1.Location = new Point(menuButton1.Location.X - 1, menuButton1.Location.Y - 1);
        }

        private void playButton_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

namespace TrueWoW_Launcher
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.tueWowLogo = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.PictureBox();
            this.playButtonHoover = new System.Windows.Forms.PictureBox();
            this.newsPicture = new System.Windows.Forms.PictureBox();
            this.newsTittleLabel = new System.Windows.Forms.Label();
            this.newsTextLabel = new System.Windows.Forms.Label();
            this.upArrowPicture = new System.Windows.Forms.PictureBox();
            this.downArrowPicture = new System.Windows.Forms.PictureBox();
            this.menuButton1 = new System.Windows.Forms.PictureBox();
            this.menuButton2 = new System.Windows.Forms.PictureBox();
            this.menuButton3 = new System.Windows.Forms.PictureBox();
            this.menuButton4 = new System.Windows.Forms.PictureBox();
            this.menuButton5 = new System.Windows.Forms.PictureBox();
            this.menuButton6 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trayMenuShowLauncher = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuCheckForUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.trayMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.newsLoopWorker = new System.ComponentModel.BackgroundWorker();
            this.newsImgBorder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tueWowLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButtonHoover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upArrowPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downArrowPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.trayMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newsImgBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // tueWowLogo
            // 
            this.tueWowLogo.BackColor = System.Drawing.Color.Transparent;
            this.tueWowLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tueWowLogo.Image = ((System.Drawing.Image)(resources.GetObject("tueWowLogo.Image")));
            this.tueWowLogo.InitialImage = null;
            this.tueWowLogo.Location = new System.Drawing.Point(702, 338);
            this.tueWowLogo.Name = "tueWowLogo";
            this.tueWowLogo.Size = new System.Drawing.Size(124, 126);
            this.tueWowLogo.TabIndex = 7;
            this.tueWowLogo.TabStop = false;
            this.tueWowLogo.Click += new System.EventHandler(this.tueWowLogo_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playButton.BackgroundImage")));
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton.InitialImage = null;
            this.playButton.Location = new System.Drawing.Point(694, 476);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(140, 46);
            this.playButton.TabIndex = 8;
            this.playButton.TabStop = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click_1);
            this.playButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playButton_MouseDown);
            this.playButton.MouseLeave += new System.EventHandler(this.playButton_MouseLeave);
            this.playButton.MouseHover += new System.EventHandler(this.playButton_MouseHover);
            this.playButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.playButton_MouseUp);
            // 
            // playButtonHoover
            // 
            this.playButtonHoover.BackColor = System.Drawing.Color.Transparent;
            this.playButtonHoover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playButtonHoover.BackgroundImage")));
            this.playButtonHoover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playButtonHoover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButtonHoover.InitialImage = null;
            this.playButtonHoover.Location = new System.Drawing.Point(687, 465);
            this.playButtonHoover.Name = "playButtonHoover";
            this.playButtonHoover.Size = new System.Drawing.Size(154, 64);
            this.playButtonHoover.TabIndex = 10;
            this.playButtonHoover.TabStop = false;
            // 
            // newsPicture
            // 
            this.newsPicture.BackColor = System.Drawing.Color.Transparent;
            this.newsPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newsPicture.BackgroundImage")));
            this.newsPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newsPicture.Location = new System.Drawing.Point(205, 181);
            this.newsPicture.Name = "newsPicture";
            this.newsPicture.Size = new System.Drawing.Size(468, 175);
            this.newsPicture.TabIndex = 12;
            this.newsPicture.TabStop = false;
            // 
            // newsTittleLabel
            // 
            this.newsTittleLabel.BackColor = System.Drawing.Color.Transparent;
            this.newsTittleLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newsTittleLabel.Font = new System.Drawing.Font("Calligraph421 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsTittleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newsTittleLabel.Location = new System.Drawing.Point(205, 363);
            this.newsTittleLabel.Name = "newsTittleLabel";
            this.newsTittleLabel.Size = new System.Drawing.Size(468, 47);
            this.newsTittleLabel.TabIndex = 13;
            this.newsTittleLabel.Text = "No news found!\r\nRe-launch for update!";
            this.newsTittleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.newsTittleLabel.Click += new System.EventHandler(this.newsTittleLabel_Click);
            // 
            // newsTextLabel
            // 
            this.newsTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.newsTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.newsTextLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.newsTextLabel.Font = new System.Drawing.Font("Calligraph421 BT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsTextLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newsTextLabel.Location = new System.Drawing.Point(205, 410);
            this.newsTextLabel.Name = "newsTextLabel";
            this.newsTextLabel.Size = new System.Drawing.Size(442, 104);
            this.newsTextLabel.TabIndex = 14;
            this.newsTextLabel.Text = "No news found!\r\nRe-launch for update!";
            this.newsTextLabel.Click += new System.EventHandler(this.newsTextLabel_Click);
            // 
            // upArrowPicture
            // 
            this.upArrowPicture.BackColor = System.Drawing.Color.Transparent;
            this.upArrowPicture.Image = ((System.Drawing.Image)(resources.GetObject("upArrowPicture.Image")));
            this.upArrowPicture.Location = new System.Drawing.Point(645, 407);
            this.upArrowPicture.Name = "upArrowPicture";
            this.upArrowPicture.Size = new System.Drawing.Size(32, 32);
            this.upArrowPicture.TabIndex = 16;
            this.upArrowPicture.TabStop = false;
            this.upArrowPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.upArrowPicture_MouseDown);
            this.upArrowPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.upArrowPicture_MouseUp);
            // 
            // downArrowPicture
            // 
            this.downArrowPicture.BackColor = System.Drawing.Color.Transparent;
            this.downArrowPicture.Image = ((System.Drawing.Image)(resources.GetObject("downArrowPicture.Image")));
            this.downArrowPicture.Location = new System.Drawing.Point(645, 486);
            this.downArrowPicture.Name = "downArrowPicture";
            this.downArrowPicture.Size = new System.Drawing.Size(32, 32);
            this.downArrowPicture.TabIndex = 17;
            this.downArrowPicture.TabStop = false;
            this.downArrowPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.downArrowPicture_MouseDown);
            this.downArrowPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.downArrowPicture_MouseUp);
            // 
            // menuButton1
            // 
            this.menuButton1.BackColor = System.Drawing.Color.Transparent;
            this.menuButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton1.Image = ((System.Drawing.Image)(resources.GetObject("menuButton1.Image")));
            this.menuButton1.Location = new System.Drawing.Point(111, 169);
            this.menuButton1.Name = "menuButton1";
            this.menuButton1.Size = new System.Drawing.Size(51, 50);
            this.menuButton1.TabIndex = 23;
            this.menuButton1.TabStop = false;
            this.menuButton1.Click += new System.EventHandler(this.menuButton1_Click);
            this.menuButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuButton1_MouseDown);
            this.menuButton1.MouseHover += new System.EventHandler(this.menuButton1_MouseHover);
            this.menuButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuButton1_MouseUp);
            // 
            // menuButton2
            // 
            this.menuButton2.BackColor = System.Drawing.Color.Transparent;
            this.menuButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton2.Image = ((System.Drawing.Image)(resources.GetObject("menuButton2.Image")));
            this.menuButton2.Location = new System.Drawing.Point(111, 225);
            this.menuButton2.Name = "menuButton2";
            this.menuButton2.Size = new System.Drawing.Size(51, 50);
            this.menuButton2.TabIndex = 24;
            this.menuButton2.TabStop = false;
            this.menuButton2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuButton2_MouseDown);
            this.menuButton2.MouseHover += new System.EventHandler(this.menuButton2_MouseHover);
            this.menuButton2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuButton2_MouseUp);
            // 
            // menuButton3
            // 
            this.menuButton3.BackColor = System.Drawing.Color.Transparent;
            this.menuButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton3.Image = ((System.Drawing.Image)(resources.GetObject("menuButton3.Image")));
            this.menuButton3.Location = new System.Drawing.Point(111, 281);
            this.menuButton3.Name = "menuButton3";
            this.menuButton3.Size = new System.Drawing.Size(51, 50);
            this.menuButton3.TabIndex = 25;
            this.menuButton3.TabStop = false;
            this.menuButton3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuButton3_MouseDown);
            this.menuButton3.MouseHover += new System.EventHandler(this.menuButton3_MouseHover);
            this.menuButton3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuButton3_MouseUp);
            // 
            // menuButton4
            // 
            this.menuButton4.BackColor = System.Drawing.Color.Transparent;
            this.menuButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton4.Image = ((System.Drawing.Image)(resources.GetObject("menuButton4.Image")));
            this.menuButton4.Location = new System.Drawing.Point(111, 337);
            this.menuButton4.Name = "menuButton4";
            this.menuButton4.Size = new System.Drawing.Size(51, 50);
            this.menuButton4.TabIndex = 26;
            this.menuButton4.TabStop = false;
            this.menuButton4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuButton4_MouseDown);
            this.menuButton4.MouseHover += new System.EventHandler(this.menuButton4_MouseHover);
            this.menuButton4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuButton4_MouseUp);
            // 
            // menuButton5
            // 
            this.menuButton5.BackColor = System.Drawing.Color.Transparent;
            this.menuButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton5.Image = ((System.Drawing.Image)(resources.GetObject("menuButton5.Image")));
            this.menuButton5.Location = new System.Drawing.Point(111, 393);
            this.menuButton5.Name = "menuButton5";
            this.menuButton5.Size = new System.Drawing.Size(51, 50);
            this.menuButton5.TabIndex = 27;
            this.menuButton5.TabStop = false;
            this.menuButton5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuButton5_MouseDown);
            this.menuButton5.MouseHover += new System.EventHandler(this.menuButton5_MouseHover);
            this.menuButton5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuButton5_MouseUp);
            // 
            // menuButton6
            // 
            this.menuButton6.BackColor = System.Drawing.Color.Transparent;
            this.menuButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton6.Image = ((System.Drawing.Image)(resources.GetObject("menuButton6.Image")));
            this.menuButton6.Location = new System.Drawing.Point(111, 449);
            this.menuButton6.Name = "menuButton6";
            this.menuButton6.Size = new System.Drawing.Size(51, 50);
            this.menuButton6.TabIndex = 28;
            this.menuButton6.TabStop = false;
            this.menuButton6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuButton6_MouseDown);
            this.menuButton6.MouseHover += new System.EventHandler(this.menuButton6_MouseHover);
            this.menuButton6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuButton6_MouseUp);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.ErrorImage = null;
            this.closeButton.Location = new System.Drawing.Point(1086, 28);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 32);
            this.closeButton.TabIndex = 29;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.closeButton_MouseDown);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            this.closeButton.MouseHover += new System.EventHandler(this.closeButton_MouseHover);
            this.closeButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.closeButton_MouseUp);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Visible = true;
            this.trayIcon.DoubleClick += new System.EventHandler(this.trayIcon_DoubleClick);
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayMenuShowLauncher,
            this.trayMenuCheckForUpdate,
            this.toolStripSeparator1,
            this.trayMenuExit});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.Size = new System.Drawing.Size(164, 76);
            // 
            // trayMenuShowLauncher
            // 
            this.trayMenuShowLauncher.Name = "trayMenuShowLauncher";
            this.trayMenuShowLauncher.Size = new System.Drawing.Size(163, 22);
            this.trayMenuShowLauncher.Text = "Show Launcher";
            this.trayMenuShowLauncher.Click += new System.EventHandler(this.trayMenuShowLauncher_Click);
            // 
            // trayMenuCheckForUpdate
            // 
            this.trayMenuCheckForUpdate.Name = "trayMenuCheckForUpdate";
            this.trayMenuCheckForUpdate.Size = new System.Drawing.Size(163, 22);
            this.trayMenuCheckForUpdate.Text = "Check for Updates";
            this.trayMenuCheckForUpdate.Click += new System.EventHandler(this.trayMenuCheckForUpdate_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // trayMenuExit
            // 
            this.trayMenuExit.Name = "trayMenuExit";
            this.trayMenuExit.Size = new System.Drawing.Size(163, 22);
            this.trayMenuExit.Text = "Exit";
            this.trayMenuExit.Click += new System.EventHandler(this.trayMenuExit_Click);
            // 
            // newsLoopWorker
            // 
            this.newsLoopWorker.WorkerReportsProgress = true;
            this.newsLoopWorker.WorkerSupportsCancellation = true;
            this.newsLoopWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.newsLoopWorker_DoWork);
            this.newsLoopWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.newsLoopWorker_ProgressChanged);
            this.newsLoopWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.newsLoopWorker_RunWorkerCompleted);
            // 
            // newsImgBorder
            // 
            this.newsImgBorder.BackColor = System.Drawing.Color.Transparent;
            this.newsImgBorder.Location = new System.Drawing.Point(199, 175);
            this.newsImgBorder.Name = "newsImgBorder";
            this.newsImgBorder.Size = new System.Drawing.Size(481, 187);
            this.newsImgBorder.TabIndex = 30;
            this.newsImgBorder.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1210, 610);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.menuButton6);
            this.Controls.Add(this.menuButton5);
            this.Controls.Add(this.menuButton4);
            this.Controls.Add(this.menuButton3);
            this.Controls.Add(this.menuButton2);
            this.Controls.Add(this.menuButton1);
            this.Controls.Add(this.newsTextLabel);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.playButtonHoover);
            this.Controls.Add(this.tueWowLogo);
            this.Controls.Add(this.newsTittleLabel);
            this.Controls.Add(this.newsPicture);
            this.Controls.Add(this.newsImgBorder);
            this.Controls.Add(this.upArrowPicture);
            this.Controls.Add(this.downArrowPicture);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrueWoW Launcher";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.Shown += new System.EventHandler(this.mainForm_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            ((System.ComponentModel.ISupportInitialize)(this.tueWowLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButtonHoover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upArrowPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downArrowPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.trayMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newsImgBorder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox tueWowLogo;
        private System.Windows.Forms.PictureBox playButton;
        private System.Windows.Forms.PictureBox playButtonHoover;
        private System.Windows.Forms.PictureBox newsPicture;
        private System.Windows.Forms.Label newsTittleLabel;
        private System.Windows.Forms.Label newsTextLabel;
        private System.Windows.Forms.PictureBox upArrowPicture;
        private System.Windows.Forms.PictureBox downArrowPicture;
        private System.Windows.Forms.PictureBox menuButton1;
        private System.Windows.Forms.PictureBox menuButton2;
        private System.Windows.Forms.PictureBox menuButton3;
        private System.Windows.Forms.PictureBox menuButton4;
        private System.Windows.Forms.PictureBox menuButton5;
        private System.Windows.Forms.PictureBox menuButton6;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem trayMenuShowLauncher;
        private System.Windows.Forms.ToolStripMenuItem trayMenuCheckForUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem trayMenuExit;
        private System.ComponentModel.BackgroundWorker newsLoopWorker;
        private System.Windows.Forms.PictureBox newsImgBorder;
    }
}
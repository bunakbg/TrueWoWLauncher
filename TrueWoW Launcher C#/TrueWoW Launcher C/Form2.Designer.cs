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
            this.menuTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tueWowLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // tueWowLogo
            // 
            this.tueWowLogo.BackColor = System.Drawing.Color.Transparent;
            this.tueWowLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tueWowLogo.Image = ((System.Drawing.Image)(resources.GetObject("tueWowLogo.Image")));
            this.tueWowLogo.InitialImage = null;
            this.tueWowLogo.Location = new System.Drawing.Point(618, 53);
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
            this.playButton.Location = new System.Drawing.Point(609, 320);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(140, 46);
            this.playButton.TabIndex = 8;
            this.playButton.TabStop = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click_1);
            this.playButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playButton_MouseDown);
            this.playButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.playButton_MouseUp);
            // 
            // newsPicture
            // 
            this.newsPicture.BackColor = System.Drawing.Color.Transparent;
            this.newsPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newsPicture.BackgroundImage")));
            this.newsPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newsPicture.Location = new System.Drawing.Point(117, 27);
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
            this.newsTittleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.newsTittleLabel.Location = new System.Drawing.Point(117, 204);
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
            this.newsTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.newsTextLabel.Location = new System.Drawing.Point(117, 252);
            this.newsTextLabel.Name = "newsTextLabel";
            this.newsTextLabel.Size = new System.Drawing.Size(442, 104);
            this.newsTextLabel.TabIndex = 14;
            this.newsTextLabel.Text = "No news found!\r\nRe-launch for update!";
            this.newsTextLabel.Click += new System.EventHandler(this.newsTextLabel_Click);
            // 
            // upArrowPicture
            // 
            this.upArrowPicture.BackColor = System.Drawing.Color.Transparent;
            this.upArrowPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upArrowPicture.Image = ((System.Drawing.Image)(resources.GetObject("upArrowPicture.Image")));
            this.upArrowPicture.Location = new System.Drawing.Point(556, 249);
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
            this.downArrowPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downArrowPicture.Image = ((System.Drawing.Image)(resources.GetObject("downArrowPicture.Image")));
            this.downArrowPicture.Location = new System.Drawing.Point(556, 328);
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
            this.menuButton1.Location = new System.Drawing.Point(23, 26);
            this.menuButton1.Name = "menuButton1";
            this.menuButton1.Size = new System.Drawing.Size(51, 50);
            this.menuButton1.TabIndex = 23;
            this.menuButton1.TabStop = false;
            this.menuTip.SetToolTip(this.menuButton1, "Settings");
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
            this.menuButton2.Location = new System.Drawing.Point(23, 82);
            this.menuButton2.Name = "menuButton2";
            this.menuButton2.Size = new System.Drawing.Size(51, 50);
            this.menuButton2.TabIndex = 24;
            this.menuButton2.TabStop = false;
            this.menuTip.SetToolTip(this.menuButton2, "Clear your cache");
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
            this.menuButton3.Location = new System.Drawing.Point(23, 138);
            this.menuButton3.Name = "menuButton3";
            this.menuButton3.Size = new System.Drawing.Size(51, 50);
            this.menuButton3.TabIndex = 25;
            this.menuButton3.TabStop = false;
            this.menuTip.SetToolTip(this.menuButton3, "Character transfer");
            this.menuButton3.Click += new System.EventHandler(this.menuButton3_Click);
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
            this.menuButton4.Location = new System.Drawing.Point(23, 194);
            this.menuButton4.Name = "menuButton4";
            this.menuButton4.Size = new System.Drawing.Size(51, 50);
            this.menuButton4.TabIndex = 26;
            this.menuButton4.TabStop = false;
            this.menuButton4.Click += new System.EventHandler(this.menuButton4_Click);
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
            this.menuButton5.Location = new System.Drawing.Point(23, 250);
            this.menuButton5.Name = "menuButton5";
            this.menuButton5.Size = new System.Drawing.Size(51, 50);
            this.menuButton5.TabIndex = 27;
            this.menuButton5.TabStop = false;
            this.menuButton5.Click += new System.EventHandler(this.menuButton5_Click);
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
            this.menuButton6.Location = new System.Drawing.Point(23, 306);
            this.menuButton6.Name = "menuButton6";
            this.menuButton6.Size = new System.Drawing.Size(51, 50);
            this.menuButton6.TabIndex = 28;
            this.menuButton6.TabStop = false;
            this.menuButton6.Click += new System.EventHandler(this.menuButton6_Click);
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
            this.closeButton.Location = new System.Drawing.Point(729, 12);
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
            this.newsImgBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(172)))), ((int)(((byte)(215)))));
            this.newsImgBorder.Location = new System.Drawing.Point(111, 21);
            this.newsImgBorder.Name = "newsImgBorder";
            this.newsImgBorder.Size = new System.Drawing.Size(481, 340);
            this.newsImgBorder.TabIndex = 30;
            this.newsImgBorder.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(172)))), ((int)(((byte)(215)))));
            this.pictureBox1.Location = new System.Drawing.Point(559, 309);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 20);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(172)))), ((int)(((byte)(215)))));
            this.pictureBox2.Location = new System.Drawing.Point(559, 277);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 20);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(172)))), ((int)(((byte)(215)))));
            this.pictureBox3.Location = new System.Drawing.Point(585, 248);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(7, 36);
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(172)))), ((int)(((byte)(215)))));
            this.pictureBox4.Location = new System.Drawing.Point(585, 322);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(7, 34);
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(172)))), ((int)(((byte)(215)))));
            this.pictureBox5.Location = new System.Drawing.Point(559, 356);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 4);
            this.pictureBox5.TabIndex = 35;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(172)))), ((int)(((byte)(215)))));
            this.pictureBox6.Location = new System.Drawing.Point(556, 251);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(33, 1);
            this.pictureBox6.TabIndex = 36;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(172)))), ((int)(((byte)(215)))));
            this.pictureBox7.Location = new System.Drawing.Point(546, 356);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(33, 4);
            this.pictureBox7.TabIndex = 37;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Location = new System.Drawing.Point(559, 277);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(26, 52);
            this.pictureBox8.TabIndex = 38;
            this.pictureBox8.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(773, 389);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.newsTextLabel);
            this.Controls.Add(this.upArrowPicture);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.menuButton6);
            this.Controls.Add(this.menuButton5);
            this.Controls.Add(this.menuButton4);
            this.Controls.Add(this.menuButton3);
            this.Controls.Add(this.menuButton2);
            this.Controls.Add(this.menuButton1);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.tueWowLogo);
            this.Controls.Add(this.newsTittleLabel);
            this.Controls.Add(this.newsPicture);
            this.Controls.Add(this.downArrowPicture);
            this.Controls.Add(this.newsImgBorder);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox tueWowLogo;
        private System.Windows.Forms.PictureBox playButton;
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
        private System.Windows.Forms.ToolTip menuTip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.tueWowLogo = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.PictureBox();
            this.playButtonHoover = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tueWowLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButtonHoover)).BeginInit();
            this.SuspendLayout();
            // 
            // tueWowLogo
            // 
            this.tueWowLogo.BackColor = System.Drawing.Color.Transparent;
            this.tueWowLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tueWowLogo.Image = ((System.Drawing.Image)(resources.GetObject("tueWowLogo.Image")));
            this.tueWowLogo.InitialImage = null;
            this.tueWowLogo.Location = new System.Drawing.Point(195, 405);
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
            this.playButton.Location = new System.Drawing.Point(537, 476);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(140, 46);
            this.playButton.TabIndex = 8;
            this.playButton.TabStop = false;
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
            this.playButtonHoover.Location = new System.Drawing.Point(532, 467);
            this.playButtonHoover.Name = "playButtonHoover";
            this.playButtonHoover.Size = new System.Drawing.Size(151, 61);
            this.playButtonHoover.TabIndex = 10;
            this.playButtonHoover.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1210, 610);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.playButtonHoover);
            this.Controls.Add(this.tueWowLogo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox tueWowLogo;
        private System.Windows.Forms.PictureBox playButton;
        private System.Windows.Forms.PictureBox playButtonHoover;
    }
}
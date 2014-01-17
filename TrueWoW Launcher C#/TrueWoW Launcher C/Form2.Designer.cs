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
            this.newsTextLabel = new System.Windows.Forms.Label();
            this.closeLabel = new System.Windows.Forms.Label();
            this.newsPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tueWowLogo = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.newsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tueWowLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).BeginInit();
            this.SuspendLayout();
            // 
            // newsTextLabel
            // 
            this.newsTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.newsTextLabel.Font = new System.Drawing.Font("Calligraph421 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsTextLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newsTextLabel.Location = new System.Drawing.Point(24, 272);
            this.newsTextLabel.Name = "newsTextLabel";
            this.newsTextLabel.Size = new System.Drawing.Size(457, 225);
            this.newsTextLabel.TabIndex = 1;
            this.newsTextLabel.Text = resources.GetString("newsTextLabel.Text");
            this.newsTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeLabel
            // 
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.Font = new System.Drawing.Font("Calligraph421 BT", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLabel.ForeColor = System.Drawing.Color.Gray;
            this.closeLabel.Location = new System.Drawing.Point(955, 48);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(43, 49);
            this.closeLabel.TabIndex = 4;
            this.closeLabel.Text = "x";
            this.closeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            this.closeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.closeLabel_MouseDown);
            this.closeLabel.MouseLeave += new System.EventHandler(this.closeLabel_MouseLeave);
            this.closeLabel.MouseHover += new System.EventHandler(this.closeLabel_MouseHover);
            this.closeLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.closeLabel_MouseUp);
            // 
            // newsPicture
            // 
            this.newsPicture.BackColor = System.Drawing.Color.Transparent;
            this.newsPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newsPicture.Image = ((System.Drawing.Image)(resources.GetObject("newsPicture.Image")));
            this.newsPicture.Location = new System.Drawing.Point(14, 218);
            this.newsPicture.Name = "newsPicture";
            this.newsPicture.Size = new System.Drawing.Size(500, 48);
            this.newsPicture.TabIndex = 0;
            this.newsPicture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(487, 470);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(487, 272);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 27);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // tueWowLogo
            // 
            this.tueWowLogo.BackColor = System.Drawing.Color.Transparent;
            this.tueWowLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tueWowLogo.Image = ((System.Drawing.Image)(resources.GetObject("tueWowLogo.Image")));
            this.tueWowLogo.InitialImage = null;
            this.tueWowLogo.Location = new System.Drawing.Point(520, 140);
            this.tueWowLogo.Name = "tueWowLogo";
            this.tueWowLogo.Size = new System.Drawing.Size(124, 126);
            this.tueWowLogo.TabIndex = 7;
            this.tueWowLogo.TabStop = false;
            this.tueWowLogo.Click += new System.EventHandler(this.tueWowLogo_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.Image = ((System.Drawing.Image)(resources.GetObject("playButton.Image")));
            this.playButton.InitialImage = null;
            this.playButton.Location = new System.Drawing.Point(547, 524);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(81, 61);
            this.playButton.TabIndex = 8;
            this.playButton.TabStop = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playButton_MouseDown);
            this.playButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.playButton_MouseUp);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(14, 574);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(500, 11);
            this.progressBar1.TabIndex = 9;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1022, 700);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.tueWowLogo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closeLabel);
            this.Controls.Add(this.newsTextLabel);
            this.Controls.Add(this.newsPicture);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrueWoW Launcher";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            ((System.ComponentModel.ISupportInitialize)(this.newsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tueWowLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label newsTextLabel;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.PictureBox newsPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox tueWowLogo;
        private System.Windows.Forms.PictureBox playButton;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
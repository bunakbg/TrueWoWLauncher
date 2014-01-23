namespace TrueWoW_Launcher
{
    partial class updateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateForm));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.updateLabelLoopWorker = new System.ComponentModel.BackgroundWorker();
            this.updateBackgroundDownloader = new System.ComponentModel.BackgroundWorker();
            this.newsBackgroundDownloader = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(501, 14);
            this.progressBar1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Location = new System.Drawing.Point(9, 37);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(447, 14);
            this.statusLabel.TabIndex = 2;
            // 
            // updateLabelLoopWorker
            // 
            this.updateLabelLoopWorker.WorkerReportsProgress = true;
            this.updateLabelLoopWorker.WorkerSupportsCancellation = true;
            this.updateLabelLoopWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.updateLabelLoopWorker_DoWork);
            this.updateLabelLoopWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.updateLabelLoopWorker_ProgressChanged);
            // 
            // updateBackgroundDownloader
            // 
            this.updateBackgroundDownloader.WorkerReportsProgress = true;
            this.updateBackgroundDownloader.WorkerSupportsCancellation = true;
            this.updateBackgroundDownloader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.updateBackgroundDownloader_DoWork);
            this.updateBackgroundDownloader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.updateBackgroundDownloader_RunWorkerCompleted);
            // 
            // newsBackgroundDownloader
            // 
            this.newsBackgroundDownloader.WorkerReportsProgress = true;
            this.newsBackgroundDownloader.WorkerSupportsCancellation = true;
            this.newsBackgroundDownloader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.newsBackgroundDownloader_DoWork);
            this.newsBackgroundDownloader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.newsBackgroundDownloader_RunWorkerCompleted);
            // 
            // updateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 58);
            this.ControlBox = false;
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "updateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrueWoW Launcher";
            this.Shown += new System.EventHandler(this.updateForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label statusLabel;
        private System.ComponentModel.BackgroundWorker updateLabelLoopWorker;
        private System.ComponentModel.BackgroundWorker updateBackgroundDownloader;
        private System.ComponentModel.BackgroundWorker newsBackgroundDownloader;
    }
}


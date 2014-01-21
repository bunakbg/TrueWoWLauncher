namespace TrueWoW_Launcher
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.wowPathInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wowPathBrowseButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.startUpSoundCheckBox = new System.Windows.Forms.CheckBox();
            this.minimizeToTrayCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // wowPathInput
            // 
            this.wowPathInput.Location = new System.Drawing.Point(12, 25);
            this.wowPathInput.Name = "wowPathInput";
            this.wowPathInput.ReadOnly = true;
            this.wowPathInput.Size = new System.Drawing.Size(329, 20);
            this.wowPathInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "World of Wacraft 3.3.5a folder:";
            // 
            // wowPathBrowseButton
            // 
            this.wowPathBrowseButton.Location = new System.Drawing.Point(347, 25);
            this.wowPathBrowseButton.Name = "wowPathBrowseButton";
            this.wowPathBrowseButton.Size = new System.Drawing.Size(35, 20);
            this.wowPathBrowseButton.TabIndex = 2;
            this.wowPathBrowseButton.Text = "...";
            this.wowPathBrowseButton.UseVisualStyleBackColor = true;
            this.wowPathBrowseButton.Click += new System.EventHandler(this.wowPathBrowseButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // startUpSoundCheckBox
            // 
            this.startUpSoundCheckBox.AutoSize = true;
            this.startUpSoundCheckBox.Location = new System.Drawing.Point(12, 72);
            this.startUpSoundCheckBox.Name = "startUpSoundCheckBox";
            this.startUpSoundCheckBox.Size = new System.Drawing.Size(92, 17);
            this.startUpSoundCheckBox.TabIndex = 4;
            this.startUpSoundCheckBox.Text = "Startup sound";
            this.startUpSoundCheckBox.UseVisualStyleBackColor = true;
            // 
            // minimizeToTrayCheckBox
            // 
            this.minimizeToTrayCheckBox.AutoSize = true;
            this.minimizeToTrayCheckBox.Location = new System.Drawing.Point(12, 95);
            this.minimizeToTrayCheckBox.Name = "minimizeToTrayCheckBox";
            this.minimizeToTrayCheckBox.Size = new System.Drawing.Size(179, 17);
            this.minimizeToTrayCheckBox.TabIndex = 5;
            this.minimizeToTrayCheckBox.Text = "Minimize in tray on close window";
            this.minimizeToTrayCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 152);
            this.Controls.Add(this.minimizeToTrayCheckBox);
            this.Controls.Add(this.startUpSoundCheckBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.wowPathBrowseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wowPathInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrueWoW Launcher - Settings";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Shown += new System.EventHandler(this.Form3_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wowPathInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button wowPathBrowseButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.CheckBox startUpSoundCheckBox;
        private System.Windows.Forms.CheckBox minimizeToTrayCheckBox;
    }
}
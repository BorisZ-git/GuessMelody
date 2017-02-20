namespace GuessMelody
{
    partial class fmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmSettings));
            this.lbMusic = new System.Windows.Forms.ListBox();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.btnClearListMusic = new System.Windows.Forms.Button();
            this.cbAllDirectory = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRandomStart = new System.Windows.Forms.CheckBox();
            this.cmbGameDuration = new System.Windows.Forms.ComboBox();
            this.cmbMusicDuration = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMusic
            // 
            this.lbMusic.FormattingEnabled = true;
            this.lbMusic.Location = new System.Drawing.Point(0, 0);
            this.lbMusic.Name = "lbMusic";
            this.lbMusic.Size = new System.Drawing.Size(501, 199);
            this.lbMusic.TabIndex = 0;
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(13, 216);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(121, 23);
            this.btnChooseFolder.TabIndex = 1;
            this.btnChooseFolder.Text = "Choose Directory";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // btnClearListMusic
            // 
            this.btnClearListMusic.Location = new System.Drawing.Point(158, 216);
            this.btnClearListMusic.Name = "btnClearListMusic";
            this.btnClearListMusic.Size = new System.Drawing.Size(118, 23);
            this.btnClearListMusic.TabIndex = 2;
            this.btnClearListMusic.Text = "Clear List";
            this.btnClearListMusic.UseVisualStyleBackColor = true;
            // 
            // cbAllDirectory
            // 
            this.cbAllDirectory.AutoSize = true;
            this.cbAllDirectory.Location = new System.Drawing.Point(366, 216);
            this.cbAllDirectory.Name = "cbAllDirectory";
            this.cbAllDirectory.Size = new System.Drawing.Size(82, 17);
            this.cbAllDirectory.TabIndex = 3;
            this.cbAllDirectory.Text = "All Directory";
            this.cbAllDirectory.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(346, 360);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(427, 360);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMusicDuration);
            this.groupBox1.Controls.Add(this.cmbGameDuration);
            this.groupBox1.Controls.Add(this.cbRandomStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 138);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Music Duration";
            // 
            // cbRandomStart
            // 
            this.cbRandomStart.AutoSize = true;
            this.cbRandomStart.Location = new System.Drawing.Point(10, 103);
            this.cbRandomStart.Name = "cbRandomStart";
            this.cbRandomStart.Size = new System.Drawing.Size(72, 17);
            this.cbRandomStart.TabIndex = 2;
            this.cbRandomStart.Text = "Random?";
            this.cbRandomStart.UseVisualStyleBackColor = true;
            // 
            // cmbGameDuration
            // 
            this.cmbGameDuration.FormattingEnabled = true;
            this.cmbGameDuration.Items.AddRange(new object[] {
            "30",
            "60",
            "90",
            "120"});
            this.cmbGameDuration.Location = new System.Drawing.Point(92, 29);
            this.cmbGameDuration.Name = "cmbGameDuration";
            this.cmbGameDuration.Size = new System.Drawing.Size(43, 21);
            this.cmbGameDuration.TabIndex = 3;
            this.cmbGameDuration.Text = "60";
            // 
            // cmbMusicDuration
            // 
            this.cmbMusicDuration.FormattingEnabled = true;
            this.cmbMusicDuration.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30",
            "35"});
            this.cmbMusicDuration.Location = new System.Drawing.Point(92, 51);
            this.cmbMusicDuration.Name = "cmbMusicDuration";
            this.cmbMusicDuration.Size = new System.Drawing.Size(43, 21);
            this.cmbMusicDuration.TabIndex = 4;
            this.cmbMusicDuration.Text = "10";
            // 
            // fmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 396);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbAllDirectory);
            this.Controls.Add(this.btnClearListMusic);
            this.Controls.Add(this.btnChooseFolder);
            this.Controls.Add(this.lbMusic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmSettings";
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMusic;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.Button btnClearListMusic;
        private System.Windows.Forms.CheckBox cbAllDirectory;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbMusicDuration;
        private System.Windows.Forms.ComboBox cmbGameDuration;
        private System.Windows.Forms.CheckBox cbRandomStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
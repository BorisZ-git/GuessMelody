﻿namespace GuessMelody
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
            this.cmbPlayer2 = new System.Windows.Forms.ComboBox();
            this.cmbPlayer1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMusicDuration = new System.Windows.Forms.ComboBox();
            this.cmbGameDuration = new System.Windows.Forms.ComboBox();
            this.cbRandomStart = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimeAnswer = new System.Windows.Forms.Label();
            this.cmbTimeAnswer = new System.Windows.Forms.ComboBox();
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
            this.groupBox1.Controls.Add(this.cmbTimeAnswer);
            this.groupBox1.Controls.Add(this.lblTimeAnswer);
            this.groupBox1.Controls.Add(this.cmbPlayer2);
            this.groupBox1.Controls.Add(this.cmbPlayer1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
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
            // cmbPlayer2
            // 
            this.cmbPlayer2.FormattingEnabled = true;
            this.cmbPlayer2.Location = new System.Drawing.Point(220, 55);
            this.cmbPlayer2.Name = "cmbPlayer2";
            this.cmbPlayer2.Size = new System.Drawing.Size(42, 21);
            this.cmbPlayer2.TabIndex = 8;
            this.cmbPlayer2.Text = "P";
            // 
            // cmbPlayer1
            // 
            this.cmbPlayer1.FormattingEnabled = true;
            this.cmbPlayer1.Location = new System.Drawing.Point(220, 28);
            this.cmbPlayer1.Name = "cmbPlayer1";
            this.cmbPlayer1.Size = new System.Drawing.Size(42, 21);
            this.cmbPlayer1.TabIndex = 7;
            this.cmbPlayer1.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Player 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Player 1";
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
            this.cmbMusicDuration.Location = new System.Drawing.Point(92, 54);
            this.cmbMusicDuration.Name = "cmbMusicDuration";
            this.cmbMusicDuration.Size = new System.Drawing.Size(43, 21);
            this.cmbMusicDuration.TabIndex = 4;
            this.cmbMusicDuration.Text = "10";
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
            // cbRandomStart
            // 
            this.cbRandomStart.AutoSize = true;
            this.cbRandomStart.Location = new System.Drawing.Point(172, 87);
            this.cbRandomStart.Name = "cbRandomStart";
            this.cbRandomStart.Size = new System.Drawing.Size(106, 17);
            this.cbRandomStart.TabIndex = 2;
            this.cbRandomStart.Text = "Random Position";
            this.cbRandomStart.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Music Duration";
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
            // lblTimeAnswer
            // 
            this.lblTimeAnswer.AutoSize = true;
            this.lblTimeAnswer.Location = new System.Drawing.Point(5, 81);
            this.lblTimeAnswer.Name = "lblTimeAnswer";
            this.lblTimeAnswer.Size = new System.Drawing.Size(80, 13);
            this.lblTimeAnswer.TabIndex = 9;
            this.lblTimeAnswer.Text = "Time to Answer";
            // 
            // cmbTimeAnswer
            // 
            this.cmbTimeAnswer.FormattingEnabled = true;
            this.cmbTimeAnswer.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "10"});
            this.cmbTimeAnswer.Location = new System.Drawing.Point(92, 78);
            this.cmbTimeAnswer.Name = "cmbTimeAnswer";
            this.cmbTimeAnswer.Size = new System.Drawing.Size(43, 21);
            this.cmbTimeAnswer.TabIndex = 10;
            this.cmbTimeAnswer.Text = "10";
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
            this.Load += new System.EventHandler(this.fmSettings_Load);
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
        private System.Windows.Forms.ComboBox cmbPlayer2;
        private System.Windows.Forms.ComboBox cmbPlayer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTimeAnswer;
        private System.Windows.Forms.Label lblTimeAnswer;
    }
}
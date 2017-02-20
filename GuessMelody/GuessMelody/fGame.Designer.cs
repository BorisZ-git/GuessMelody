namespace GuessMelody
{
    partial class fGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGame));
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCounter1 = new System.Windows.Forms.Label();
            this.lblCounter2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(0, 351);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(143, 45);
            this.WMP.TabIndex = 0;
            this.WMP.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.Location = new System.Drawing.Point(12, 273);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(126, 49);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(165, 273);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(112, 49);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnContinue.Location = new System.Drawing.Point(291, 273);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(124, 49);
            this.btnContinue.TabIndex = 3;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(50, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(249, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player 2";
            // 
            // lblCounter1
            // 
            this.lblCounter1.AutoSize = true;
            this.lblCounter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCounter1.Location = new System.Drawing.Point(89, 82);
            this.lblCounter1.Name = "lblCounter1";
            this.lblCounter1.Size = new System.Drawing.Size(31, 33);
            this.lblCounter1.TabIndex = 6;
            this.lblCounter1.Text = "0";
            this.lblCounter1.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCounter2
            // 
            this.lblCounter2.AutoSize = true;
            this.lblCounter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCounter2.Location = new System.Drawing.Point(285, 82);
            this.lblCounter2.Name = "lblCounter2";
            this.lblCounter2.Size = new System.Drawing.Size(31, 33);
            this.lblCounter2.TabIndex = 7;
            this.lblCounter2.Text = "0";
            // 
            // fGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(422, 371);
            this.Controls.Add(this.lblCounter2);
            this.Controls.Add(this.lblCounter1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.WMP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fGame";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCounter1;
        private System.Windows.Forms.Label lblCounter2;
    }
}
namespace AdventureGameDeclanFeoreJamesKoch
{
    partial class Form1
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.sceneImage = new System.Windows.Forms.PictureBox();
            this.bLabel = new System.Windows.Forms.Label();
            this.nLabel = new System.Windows.Forms.Label();
            this.mLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sceneImage)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(13, 13);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(872, 101);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "label1";
            // 
            // redLabel
            // 
            this.redLabel.Location = new System.Drawing.Point(139, 537);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(587, 46);
            this.redLabel.TabIndex = 1;
            this.redLabel.Text = "label1";
            // 
            // blueLabel
            // 
            this.blueLabel.Location = new System.Drawing.Point(139, 611);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(587, 46);
            this.blueLabel.TabIndex = 3;
            this.blueLabel.Text = "label2";
            // 
            // yellowLabel
            // 
            this.yellowLabel.Location = new System.Drawing.Point(139, 680);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(587, 46);
            this.yellowLabel.TabIndex = 5;
            this.yellowLabel.Text = "label3";
            // 
            // sceneImage
            // 
            this.sceneImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sceneImage.Location = new System.Drawing.Point(7, 137);
            this.sceneImage.Name = "sceneImage";
            this.sceneImage.Size = new System.Drawing.Size(878, 358);
            this.sceneImage.TabIndex = 7;
            this.sceneImage.TabStop = false;
            // 
            // bLabel
            // 
            this.bLabel.BackColor = System.Drawing.Color.Red;
            this.bLabel.Location = new System.Drawing.Point(83, 537);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(50, 46);
            this.bLabel.TabIndex = 8;
            this.bLabel.Text = "B";
            this.bLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nLabel
            // 
            this.nLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.nLabel.Location = new System.Drawing.Point(83, 611);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(50, 46);
            this.nLabel.TabIndex = 9;
            this.nLabel.Text = "N";
            this.nLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mLabel
            // 
            this.mLabel.BackColor = System.Drawing.Color.Yellow;
            this.mLabel.Location = new System.Drawing.Point(83, 680);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(50, 46);
            this.mLabel.TabIndex = 10;
            this.mLabel.Text = "M";
            this.mLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 771);
            this.Controls.Add(this.mLabel);
            this.Controls.Add(this.nLabel);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.sceneImage);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.outputLabel);
            this.Name = "Form1";
            this.Text = "Going to a Friends";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.sceneImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label yellowLabel;
        private System.Windows.Forms.PictureBox sceneImage;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.Label mLabel;
    }
}


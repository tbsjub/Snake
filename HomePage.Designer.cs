namespace Practice
{
    partial class HomePage
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
            this.background1 = new System.Windows.Forms.PictureBox();
            this.play = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.background1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            this.SuspendLayout();
            // 
            // background1
            // 
            this.background1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.background1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.background1.Location = new System.Drawing.Point(-5, 2);
            this.background1.Name = "background1";
            this.background1.Size = new System.Drawing.Size(1088, 502);
            this.background1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background1.TabIndex = 0;
            this.background1.TabStop = false;
            this.background1.Paint += new System.Windows.Forms.PaintEventHandler(this.WelcomeText);
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(235, 80);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(630, 368);
            this.play.TabIndex = 1;
            this.play.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 503);
            this.Controls.Add(this.play);
            this.Controls.Add(this.background1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.background1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox background1;
        private System.Windows.Forms.PictureBox play;
    }
}
﻿namespace Practice
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.background = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.highScore = new System.Windows.Forms.Label();
            this.startbtn = new System.Windows.Forms.Button();
            this.quitbtn = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.background.ErrorImage = ((System.Drawing.Image)(resources.GetObject("background.ErrorImage")));
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.ImageLocation = "\"C:\\Users\\yadur\\Desktop\\Sarita\'s college work\\background.jpg\"";
            this.background.Location = new System.Drawing.Point(32, 44);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1019, 447);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            this.background.Paint += new System.Windows.Forms.PaintEventHandler(this.Graphics_);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Score.Location = new System.Drawing.Point(37, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(67, 24);
            this.Score.TabIndex = 1;
            this.Score.Text = "Score: ";
            // 
            // highScore
            // 
            this.highScore.AutoSize = true;
            this.highScore.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.highScore.Location = new System.Drawing.Point(362, 9);
            this.highScore.Name = "highScore";
            this.highScore.Size = new System.Drawing.Size(113, 24);
            this.highScore.TabIndex = 2;
            this.highScore.Text = "High Score: ";
            // 
            // startbtn
            // 
            this.startbtn.BackColor = System.Drawing.Color.IndianRed;
            this.startbtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startbtn.Location = new System.Drawing.Point(748, 9);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(114, 29);
            this.startbtn.TabIndex = 3;
            this.startbtn.Text = "Start";
            this.startbtn.UseVisualStyleBackColor = false;
            this.startbtn.Click += new System.EventHandler(this.startGame);
            // 
            // quitbtn
            // 
            this.quitbtn.BackColor = System.Drawing.Color.Red;
            this.quitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.quitbtn.Location = new System.Drawing.Point(907, 10);
            this.quitbtn.Name = "quitbtn";
            this.quitbtn.Size = new System.Drawing.Size(114, 28);
            this.quitbtn.TabIndex = 4;
            this.quitbtn.Text = "Quit";
            this.quitbtn.UseVisualStyleBackColor = false;
            this.quitbtn.Click += new System.EventHandler(this.quitGame);
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameEventTimer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 503);
            this.Controls.Add(this.quitbtn);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.highScore);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.background);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Background);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Graphics_);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label highScore;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Button quitbtn;
        private System.Windows.Forms.Timer gameTimer;
    }
}

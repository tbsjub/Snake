namespace Practice
{
    partial class SinglePlayer
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
            this.background = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.highScore = new System.Windows.Forms.Label();
            this.startbtn = new System.Windows.Forms.Button();
            this.quitbtn = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.wall = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.background.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.background.ErrorImage = null;
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
            this.startbtn.Location = new System.Drawing.Point(805, 9);
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
            this.quitbtn.Location = new System.Drawing.Point(937, 10);
            this.quitbtn.Name = "quitbtn";
            this.quitbtn.Size = new System.Drawing.Size(114, 28);
            this.quitbtn.TabIndex = 4;
            this.quitbtn.Text = "Go Back";
            this.quitbtn.UseVisualStyleBackColor = false;
            this.quitbtn.Click += new System.EventHandler(this.quitGame);
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameEventTimer);
            // 
            // wall
            // 
            this.wall.AutoSize = true;
            this.wall.BackColor = System.Drawing.Color.IndianRed;
            this.wall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wall.Location = new System.Drawing.Point(691, 9);
            this.wall.Name = "wall";
            this.wall.Size = new System.Drawing.Size(68, 24);
            this.wall.TabIndex = 5;
            this.wall.Text = "Wall";
            this.wall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wall.UseVisualStyleBackColor = false;
            // 
            // SinglePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 503);
            this.Controls.Add(this.wall);
            this.Controls.Add(this.quitbtn);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.highScore);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.background);
            this.KeyPreview = true;
            this.Name = "SinglePlayer";
            this.Text = "Single Player";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Graphics_);
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
        private System.Windows.Forms.CheckBox wall;
    }
}


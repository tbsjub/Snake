namespace Practice
{
    partial class TwoPlayers
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
            this.scoree = new System.Windows.Forms.Label();
            this.highScoree = new System.Windows.Forms.Label();
            this.startbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.twoGameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreee = new System.Windows.Forms.Label();
            this.wall = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.background.BackColor = System.Drawing.Color.Coral;
            this.background.Location = new System.Drawing.Point(12, 49);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1054, 442);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            this.background.Paint += new System.Windows.Forms.PaintEventHandler(this.Painting);
            // 
            // scoree
            // 
            this.scoree.AutoSize = true;
            this.scoree.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoree.Location = new System.Drawing.Point(12, 13);
            this.scoree.Name = "scoree";
            this.scoree.Size = new System.Drawing.Size(145, 24);
            this.scoree.TabIndex = 1;
            this.scoree.Text = "Player1 Score: 0";
            // 
            // highScoree
            // 
            this.highScoree.AutoSize = true;
            this.highScoree.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.highScoree.Location = new System.Drawing.Point(443, 13);
            this.highScoree.Name = "highScoree";
            this.highScoree.Size = new System.Drawing.Size(108, 24);
            this.highScoree.TabIndex = 1;
            this.highScoree.Text = "High Score:";
            // 
            // startbtn
            // 
            this.startbtn.AutoSize = true;
            this.startbtn.BackColor = System.Drawing.Color.Red;
            this.startbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startbtn.Location = new System.Drawing.Point(805, 13);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(106, 30);
            this.startbtn.TabIndex = 2;
            this.startbtn.Text = "Start";
            this.startbtn.UseVisualStyleBackColor = false;
            this.startbtn.Click += new System.EventHandler(this.StartBtnClick);
            // 
            // backbtn
            // 
            this.backbtn.AutoSize = true;
            this.backbtn.BackColor = System.Drawing.Color.Chartreuse;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backbtn.Location = new System.Drawing.Point(928, 13);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(106, 30);
            this.backbtn.TabIndex = 2;
            this.backbtn.Text = "Go back ";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.goBackBtnClick);
            // 
            // twoGameTimer
            // 
            this.twoGameTimer.Tick += new System.EventHandler(this.gameEventTimer);
            // 
            // scoreee
            // 
            this.scoreee.AutoSize = true;
            this.scoreee.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreee.Location = new System.Drawing.Point(222, 13);
            this.scoreee.Name = "scoreee";
            this.scoreee.Size = new System.Drawing.Size(145, 24);
            this.scoreee.TabIndex = 1;
            this.scoreee.Text = "Player2 Score: 0";
            // 
            // wall
            // 
            this.wall.AutoSize = true;
            this.wall.BackColor = System.Drawing.Color.IndianRed;
            this.wall.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wall.Location = new System.Drawing.Point(660, 13);
            this.wall.Name = "wall";
            this.wall.Size = new System.Drawing.Size(70, 28);
            this.wall.TabIndex = 3;
            this.wall.Text = "Wall";
            this.wall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wall.UseVisualStyleBackColor = false;
            // 
            // TwoPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1078, 503);
            this.Controls.Add(this.wall);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.highScoree);
            this.Controls.Add(this.scoreee);
            this.Controls.Add(this.scoree);
            this.Controls.Add(this.background);
            this.Name = "TwoPlayers";
            this.Text = "TwoPlayers";
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Label scoree;
        private System.Windows.Forms.Label highScoree;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Timer twoGameTimer;
        private System.Windows.Forms.Label scoreee;
        private System.Windows.Forms.CheckBox wall;
    }
}
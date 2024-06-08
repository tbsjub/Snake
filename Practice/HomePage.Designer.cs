using System.Drawing;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.background1 = new System.Windows.Forms.PictureBox();
            this.welcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.alone = new System.Windows.Forms.CheckBox();
            this.friend = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.background1)).BeginInit();
            this.SuspendLayout();
            // 
            // background1
            // 
            this.background1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.background1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.background1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("background1.BackgroundImage")));
            this.background1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.background1.Location = new System.Drawing.Point(-1, 1);
            this.background1.Name = "background1";
            this.background1.Size = new System.Drawing.Size(1088, 502);
            this.background1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background1.TabIndex = 0;
            this.background1.TabStop = false;
            // 
            // welcome
            // 
            this.welcome.BackColor = System.Drawing.Color.DarkCyan;
            this.welcome.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(300, 24);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(368, 38);
            this.welcome.TabIndex = 1;
            this.welcome.Text = "WELCOME!";
            this.welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Do you want to:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alone
            // 
            this.alone.BackColor = System.Drawing.Color.Teal;
            this.alone.Font = new System.Drawing.Font("Lucida Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alone.Location = new System.Drawing.Point(48, 234);
            this.alone.Name = "alone";
            this.alone.Size = new System.Drawing.Size(330, 44);
            this.alone.TabIndex = 3;
            this.alone.Text = "Play Alone";
            this.alone.UseVisualStyleBackColor = false;
            this.alone.Click += new System.EventHandler(this.aloneClick);
            // 
            // friend
            // 
            this.friend.BackColor = System.Drawing.Color.Teal;
            this.friend.Font = new System.Drawing.Font("Lucida Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friend.Location = new System.Drawing.Point(48, 310);
            this.friend.Name = "friend";
            this.friend.Size = new System.Drawing.Size(330, 44);
            this.friend.TabIndex = 4;
            this.friend.Text = "Play with a friend";
            this.friend.UseVisualStyleBackColor = false;
            this.friend.Click += new System.EventHandler(this.friendPlay);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(604, 115);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(471, 369);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 503);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.friend);
            this.Controls.Add(this.alone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.background1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.background1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background1;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox alone;
        private System.Windows.Forms.CheckBox friend;
        private System.Windows.Forms.TextBox textBox1;
    }
}
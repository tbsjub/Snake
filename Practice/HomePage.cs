using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Practice
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        /*
        private void WelcomeText(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            string text = "\tWelcome! \nDo you want to:";
            Font font = new Font("Aerial", 20, FontStyle.Bold);
            Brush brush = Brushes.Black;
            PointF point = new PointF(270, 20);

            g.DrawString(text, font, brush, point);
        }
        */

        private void theOptions(object sender, PaintEventArgs e)
        {
            Graphics g1 = e.Graphics;
        }

        private void aloneClick(object sender, EventArgs e)
        {
            SinglePlayer singlePlayer = new SinglePlayer();
            singlePlayer.Show();
            this.Hide();

        }

        private void friendPlay(object sender, EventArgs e)
        {
            TwoPlayers twoPlayers = new TwoPlayers();
            twoPlayers.Show();
            this.Hide();
        }
    }


}

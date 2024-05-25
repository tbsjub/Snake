using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void WelcomeText(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            string text = "Welcome \n Do you want to:";
            Font font = new Font("Aerial", 24, FontStyle.Bold);
            Brush brush = Brushes.Black;
            PointF point = new PointF(100, 20);

            g.DrawString(text, font, brush, point);
        }
    }


}

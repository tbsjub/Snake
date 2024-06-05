using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class TwoPlayers : Form
    {

        private SinglePlayer singlePlayer = new SinglePlayer();
        
        public TwoPlayers()
        {
            InitializeComponent();
        }

        private void StartBtnClick(object sender, EventArgs e)
        {

        }

        private void goBackBtnClick(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void Painting(object sender, PaintEventArgs e)
        {

        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {

        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {

        }

        private void restartGame(object sender, EventArgs e)
        {

        }

        private void eatFood(object sender, EventArgs e)
        {

        }

        private void gameOver(object sender, EventArgs e)
        {

        }

        private void twoGameTimer(object sender, EventArgs e)
        {

        }
    }
}

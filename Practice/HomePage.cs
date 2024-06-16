using System;
using System.Windows.Forms;


/*
 * This form is for the Home page of the game.
 * Most of the contents are in the design form. It doesn't contain much code.
 * It opens the single player form if play alone button is clicked and hide the
 * home page.
 * Similarly, it opens the two player form if play with a friend is clicked. 
 */
namespace Practice
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
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

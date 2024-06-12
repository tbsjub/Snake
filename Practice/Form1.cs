using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class SinglePlayer : Form
    {

        //this is the main part of the game

        private Snake snake;
        private Circle food = new Circle();

        private Settings settings = new Settings();

        int maxWidth;     //maximum width the snake can travel
        int maxHeight;   // maximum height the snake can travel


        int score;
        int HighScore;

        Random rand = new Random();

        bool isGameRunning = false;

        Queue<string> directionQueue = new Queue<string>();

        public SinglePlayer()
        {
            InitializeComponent();
        }

        private void quitGame(object sender, EventArgs e)
        {
            string message = "Do you really want to go back?";
            string caption = "Going back";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                HomePage homePage = new HomePage();
                homePage.Show();
                this.Hide();
            }

            isGameRunning = false;

        }



        private void startGame(object sender, EventArgs e)
        {
            restartGame();
        }

        private void restartGame()
        {
            maxWidth = background.Width / settings.Width - 1;
            maxHeight = background.Height / settings.Height - 1;

            snake = new Snake(10, 10, settings.Width, settings.Height);

            startbtn.Enabled = false;
            wall.Enabled = false;
            score = 0;
            Score.Text = "Score: " + score;



            //generating food at the random coordinates in the canvas
            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

            isGameRunning = true;
            gameTimer.Start();


        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (!isGameRunning)
            { return base.ProcessCmdKey(ref msg, keyData); }

            string newDirection = null;
            switch (keyData)
            {
                case Keys.Left:
                    if (snake.Direction != "right")
                    {
                        newDirection = "left";
                    }
                    break;
                case Keys.Right:
                    if (snake.Direction != "left")
                    {
                        newDirection = "right";
                    }
                    break;
                case Keys.Up:
                    if (snake.Direction != "down")
                    {
                        newDirection = "up";
                    }
                    break;
                case Keys.Down:
                    if (snake.Direction != "up")
                    {
                        newDirection = "down";
                    }
                    break;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }

            if (newDirection != null)
                directionQueue.Enqueue(newDirection);

            return true; // Indicate that the key has been handled
        }


        private void gameEventTimer(object sender, EventArgs e)
        {
            while (directionQueue.Count > 0)
            {
                string nextDirection = directionQueue.Dequeue();
                snake.Direction = nextDirection;
            }

            (bool over, bool eat)= snake.Move(wall.Checked, maxWidth, maxHeight, food.X, food.Y);

            if (over) gameOver();
            if (eat) eatFood();

            

            //this clears everything in the canvas and redraw it
            background.Invalidate();
        }

        // This fuction handles the drawing part of the game

        private void Graphics_(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (snake == null || snake.Body == null)
                return; 

            Brush snakeColor;


            for (int i = 0; i < snake.Body.Count; i++)
            {
                if (i == 0)
                {
                    snakeColor = Brushes.Black;
                }
                else
                {
                    snakeColor = Brushes.RosyBrown;
                }

                canvas.FillEllipse(snakeColor, new Rectangle
                    (
                    snake.Body[i].X * settings.Width,
                    snake.Body[i].Y * settings.Height,
                    settings.Width, settings.Height
                    ));
            }



            //drawing the food
            canvas.FillEllipse(Brushes.Red, new Rectangle
                    (
                    food.X * settings.Width,
                    food.Y * settings.Height,
                    settings.Width, settings.Height
                    ));
        }



        private void eatFood()
        {
            score += 1;
            Score.Text = "Score: " + score;

            //making the new segment for the snake whose X and Y cordinates are the end of the existing snake
            snake.Grow();

            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

        }

        private void gameOver()
        {
            gameTimer.Stop();
            startbtn.Enabled = true;
            wall.Enabled= true;
            if (score > HighScore)
            {
                HighScore = score;
                highScore.Text = "High Score: " + HighScore;
            }

        }
    }
}

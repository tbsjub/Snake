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

        private List<Circle> snake = new List<Circle>();
        private Circle food = new Circle();

        int maxWidth;     //maximum width the snake can travel
        int maxHeight;   // maximum height the snake can travel


        int score;
        int HighScore;

        Random rand = new Random();

        bool goLeft, goRight, goUp, goDown;

        public SinglePlayer()
        {
            InitializeComponent();
            new Settings();
        }


        /* This function handles when certain keys are pressed down
         * if the down key is pressed and the direction of the snake is 
         * not up only then the snake's direction can be down so goDown is set
         * to be true 
         * Same reasoning for every directions */
        /*
        private void keyIsDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("key is down: " + e.KeyCode.ToString());
            if (e.KeyCode == Keys.Left && Settings.directions != "right")
            {
                goLeft = true;
            }

            if (e.KeyCode == Keys.Right && Settings.directions != "left")
            {
                goRight = true;
            }

            if (e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goUp = true;
            }

            if (e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goDown = true;
            }
        }

        //this function handles the case when keys are released 
        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

        }
        */

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    if (Settings.directions != "right")
                    {
                        goLeft = true;
                        goRight = goUp = goDown = false;
                        Settings.directions = "left";
                    }
                    break;
                case Keys.Right:
                    if (Settings.directions != "left")
                    {
                        goRight = true;
                        goLeft = goUp = goDown = false;
                        Settings.directions = "right";
                    }
                    break;
                case Keys.Up:
                    if (Settings.directions != "down")
                    {
                        goUp = true;
                        goLeft = goRight = goDown = false;
                        Settings.directions = "up";
                    }
                    break;
                case Keys.Down:
                    if (Settings.directions != "up")
                    {
                        goDown = true;
                        goLeft = goRight = goUp = false;
                        Settings.directions = "down";
                    }
                    break;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
            return true; // Indicate that the key has been handled
        }


        private void startGame(object sender, EventArgs e)
        {
            restartGame();
        }

        private void quitGame(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();

        }

        private void gameEventTimer(object sender, EventArgs e)
        {

            for (int i = snake.Count - 1; i >= 0; --i)
            {
                if (i == 0)
                {
                    switch (Settings.directions)
                    {
                        case "left":
                            snake[i].X--;
                            break;

                        case "right":
                            snake[i].X++;
                            break;

                        case "up":
                            snake[i].Y--;
                            break;
                        case "down":
                            snake[i].Y++;
                            break;
                    }

                    if (wall.Checked){ 
                    if (snake[i].X < 0) snake[i].X = maxWidth;
                    if (snake[i].X > maxWidth) snake[i].X = 0;
                    if (snake[i].Y < 0) snake[i].Y = maxHeight;
                    if (snake[i].Y > maxHeight) snake[i].Y = 0;
                    }

                    else
                    {
                        if (snake[i].X < 0 || snake[i].Y < 0 || snake[i].X > maxWidth || snake[i].Y > maxHeight)
                        {
                            gameOver();
                        }
                    }

                    if (food.X == snake[i].X && food.Y == snake[i].Y)
                        eatFood();

                    for (int j = 1; j < snake.Count; ++j)
                    {
                        if (snake[i].X == snake[j].X && snake[i].Y == snake[j].Y)
                            gameOver();
                    }


                }
                //Every other body part is following the head
                else
                {
                    snake[i].X = snake[i - 1].X;
                    snake[i].Y = snake[i - 1].Y;
                }
        
                
            }

            //this clears everything in the canvas and redraw it
            background.Invalidate();
        }

        // This fuction handles the drawing part of the game

        private void Graphics_(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            Brush snakeColor;

            for (int i = 0; i < snake.Count; i++)
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
                    snake[i].X * Settings.Width,
                    snake[i].Y * Settings.Height,
                    Settings.Width, Settings.Height
                    ));
            }



            //drawing the food
            canvas.FillEllipse(Brushes.Red, new Rectangle
                    (
                    food.X * Settings.Width,
                    food.Y * Settings.Height,
                    Settings.Width, Settings.Height
                    ));
        }


        private void restartGame()
        {
            maxWidth = background.Width / Settings.Width - 1;
            maxHeight = background.Height / Settings.Height - 1;

            snake.Clear();     //emptying the snake 

            startbtn.Enabled = false;
            wall.Enabled = false;
            score = 0;
            Score.Text = "Score: " + score;

            Circle head = new Circle { X = 10, Y = 10 };
            snake.Add(head);   //adding the head to the list

            

            //Adding body to the list
            for (int i= 0; i < 5; i++)
            {
                Circle body = new Circle();
                snake.Add(body);
            }


            //generating food at the random coordinates in the canvas
            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

            gameTimer.Start();


        }

        private void eatFood()
        {
            score += 1;
            Score.Text = "Score: " + score;

            //making the new segment for the snake whose X and Y cordinates are the end of the existing snake
            Circle body = new Circle { X = snake[snake.Count - 1].X, Y = snake[snake.Count - 1].Y };
            snake.Add(body);

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

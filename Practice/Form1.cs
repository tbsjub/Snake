﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Practice
{
    public partial class SinglePlayer : Form
    {
        private Snake snake;
        private Circle food = new Circle();

        private Settings settings = new Settings();

        int maxWidth;     //maximum width the snake can travel
        int maxHeight;   // maximum height the snake can travel

        Random rand = new Random();
        int score;
        int HighScore;

        bool isGameRunning = false;

        //queue to store the direction for precision.
        Queue<string> directionQueue = new Queue<string>();

        public SinglePlayer()
        {
            InitializeComponent();
        }

        //the function to handle the go back button click.
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


        //when start button is clicked the restart game function is callled.
        private void startGame(object sender, EventArgs e)
        {
            restartGame();
        }

        /*
         * First the maximum width and height the snake can travel is calculated
         * The snake is made
         * The food is generated.
         * And game timer is started.
         */
        private void restartGame()
        {
            maxWidth = background.Width / settings.Width - 1;
            maxHeight = background.Height / settings.Height - 1;

            snake = new Snake(10, 10, settings.Width, settings.Height);

            startbtn.Enabled = false;
            wall.Enabled = false;
            score = 0;
            Score.Text = "Score: " + score;



            GenerateFood();

            isGameRunning = true;
            gameTimer.Start();


        }

        /*
         * Handles the key press action. 
         * Checks for the snake direction and the corresponding direction according
         * to the key pressed is enqued in the queue.
         */
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


        /*
         * Once the game is started, the move method of snake is called. If either game
         * was over or the snake ate food then respective functions are called.
         */
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

        //generates the food on a random free(where there is no snake) coordinates of the screen.
        private void GenerateFood()
        {
            List<Point> foodPoints = new List<Point>();

            for (int x = 2; x < maxWidth; x++)
            {
                for (int y = 2; y < maxHeight; y++)
                {
                    foodPoints.Add(new Point(x, y));
                }
            }


            foreach (var bodyparts in snake.Body)
            {
                foodPoints.Remove(new Point(bodyparts.X, bodyparts.Y));
            }

            if (foodPoints.Count > 0)
            {
                Point foodcordinate = foodPoints[rand.Next(foodPoints.Count)];
                food = new Circle { X = foodcordinate.X, Y = foodcordinate.Y };
            }

            if(foodPoints.Count == 0)
            {
                string message = "Wow, you survived all the way through";
                string caption = "Do you want to Play Again?";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    restartGame();
                }

                else 
                { 
                    HomePage homePage = new HomePage();
                    homePage.Show();
                    this.Hide();
                }

            }
        }


        //if the coordinate of snake's head food was matched then eatfood is called
        //which increases the score and calls the grow method from snake class and create another food
        private void eatFood()
        {
            score += 1;
            Score.Text = "Score: " + score;

            //making the new segment for the snake whose X and Y cordinates are the end of the existing snake
            snake.Grow();

            GenerateFood();

        }

        //once the game is over, game timer is stopped
        //the buttons are enabled again and highscore is updated
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

            isGameRunning = false;
        }
    }
}

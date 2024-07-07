using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Practice
{
    //A lot of things in this form is similar to that for the single player 
    //everything from form1 has been adjusted to work for the two snakes
    public partial class TwoPlayers : Form
    {

        Snake snake1;
        Snake snake2;

        private Circle food= new Circle();

        int maxWidth; int maxHeight;

        int score1; int score2; int highScore;

        Random rand = new Random();

        Settings settings = new Settings();

        bool isGameRunning = false;

        Queue<string> snake1Directions = new Queue<string>();
        Queue<string> snake2Directions = new Queue<string>();

        public TwoPlayers()
        {
            InitializeComponent();
        }


        //handles the go back button click.
        private void goBackBtnClick(object sender, EventArgs e)
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

        }

        private void StartBtnClick(object sender, EventArgs e)
        {
            restartGame();
        }

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


            foreach (var bodyparts in snake1.Body)
            {
                foodPoints.Remove(new Point(bodyparts.X, bodyparts.Y));
            }

            foreach (var bodyparts in snake2.Body)
            {
                foodPoints.Remove(new Point(bodyparts.X, bodyparts.Y));
            }

            if (foodPoints.Count > 0)
            {
                Point foodcordinate = foodPoints[rand.Next(foodPoints.Count)];
                food = new Circle { X = foodcordinate.X, Y = foodcordinate.Y };
            }

            if (foodPoints.Count == 0)
            {
                string message = "Wow, you guys survived all the way through";
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


        private void restartGame()
        {
            maxHeight = background.Height / settings.Height - 1;
            maxWidth = background.Width / settings.Width - 1;

            snake1 = new Snake(8, 10, settings.Width, settings.Height);
            snake2 = new Snake(40, 15, settings.Width, settings.Height);
            snake2.Direction = "left";
            startbtn.Enabled = false;
            wall.Enabled = false;

            GenerateFood();

            twoGameTimer.Start();

            isGameRunning = true;
        }

        private void Painting(object sender, PaintEventArgs e)
        {
            Graphics canvas  = e.Graphics;

            if (snake1 == null || snake1.Body == null || snake2 == null || snake2.Body == null) 
                return;


            Brush snakeColor1;

            for (int i = 0; i < snake1.Body.Count; i++)
            {
                if (i == 0)
                {
                    snakeColor1 = Brushes.Yellow;
                }
                else
                {
                    snakeColor1 = Brushes.Black;
                }

                canvas.FillEllipse(snakeColor1, new Rectangle
                (
                    snake1.Body[i].X * settings.Width,
                    snake1.Body[i].Y * settings.Height,
                settings.Width, settings.Height
                    ));
            }

            Brush snakeColor2;

            for (int i = 0; i < snake2.Body.Count; i++)
            {
                if (i == 0)
                {
                    snakeColor2 = Brushes.Purple;
                }
                else
                {
                    snakeColor2 = Brushes.Black;
                }

                canvas.FillEllipse(snakeColor2, new Rectangle
                    (
                    snake2.Body[i].X * settings.Width,
                    snake2.Body[i].Y * settings.Height,
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


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!isGameRunning)
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }

            string snake1Direction = null;
            string snake2Direction = null;

            switch (keyData)
            {
                case Keys.Left:
                    if (snake1.Direction != "right")
                    {
                        snake1Direction = "left";
                    }
                    break;
                case Keys.Right:
                    if (snake1.Direction != "left")
                    {
                        snake1Direction = "right";
                    }
                    break;
                case Keys.Up:
                    if (snake1.Direction != "down")
                    {
                        snake1Direction = "up";
                    }
                    break;
                case Keys.Down:
                    if (snake1.Direction != "up")
                    {
                        snake1Direction = "down";
                    }
                    break;
                case Keys.D:
                    if (snake2.Direction != "left")
                    {
                        snake2Direction = "right";
                    }
                    break;
                case Keys.A:
                    if (snake2.Direction != "right")
                    {
                        snake2Direction = "left";
                    }
                    break;
                case Keys.W:
                    if (snake2.Direction != "down")
                    {
                        snake2Direction = "up";
                    }
                    break;
                case Keys.S:
                    if (snake2.Direction != "up")
                    {
                        snake2Direction = "down";
                    }
                    break;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }

            if (snake1Direction != null)
                snake1Directions.Enqueue(snake1Direction);

            if (snake2Direction != null)
                snake2Directions.Enqueue(snake2Direction);

            return true; // Indicate that the key has been handled
        }

        private void gameEventTimer(object sender, EventArgs e)
        {
            if (snake2Directions.Count > 0)
            {
                string nextDirection2 = snake2Directions.Dequeue();
                snake2.Direction = nextDirection2;
            }

            if (snake1Directions.Count > 0)
            {
                string nextDirection1 = snake1Directions.Dequeue();
                snake1.Direction = nextDirection1;
            }

            (bool over1, bool eat1) = snake1.Move(wall.Checked, maxWidth, maxHeight, food.X, food.Y);

            if (over1 || checkCollision(snake1,snake2)) gameOver();
            if (eat1)
            {
                eatFood1();
                GenerateFood();
            }

             (bool over2, bool eat2) = snake2.Move(wall.Checked, maxWidth, maxHeight, food.X, food.Y);
            if (over2 || checkCollision(snake2, snake1)) gameOver();
            if (eat2)
            {
                eatFood2();
                GenerateFood();
            }
         
            
            
            
            background.Invalidate();
        }
        

        private void eatFood1()
        {
            score1 += 1;
            scoree.Text = $"Player1 Score: {score1}";
            snake1.Grow();
        }

     
        private void eatFood2()
        {
            score2 += 1;
            scoreee.Text = $"Player2 Score: {score2}";
            snake2.Grow();
        }

        //it checks for the collision between two snakes
        private bool checkCollision(Snake snakeA, Snake snakeB)
        {
            foreach (var segment in snakeB.Body)
            {
                if (snakeA.Body[0].X == segment.X && snakeA.Body[0].Y == segment.Y)
                {
                    return true;
                }
            }
            return false;
        }


        private void gameOver()
        {
            twoGameTimer.Stop();

            startbtn.Enabled = true;
            wall.Enabled = true;    

            int maxScore = Math.Max(score1,score2);
            if (maxScore > highScore)
            {
                highScore = maxScore;
                highScoree.Text = $"High Score: {highScore}";
            }

            isGameRunning = false;
                
        }

    }
}

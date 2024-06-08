using System;
using System.Collections.Generic;

namespace Practice
{
    public class Snake
    {
        public List<Circle> Body { get; private set; }
        public string Direction { get; set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Snake(int startX, int startY, int width, int height)
        {
            Body = new List<Circle>();
            Direction = Settings.directions;
            Width = width;
            Height = height;

            // Initialize the snake with a head and a few body parts
            Circle head = new Circle { X = startX, Y = startY };
            Body.Add(head);

            for (int i = 0; i < 5; i++)
            {
                Circle body = new Circle();
                Body.Add(body);
            }
        }

        public (bool gameOver,bool eatFood) Move(bool wall, int maxWidth, int maxHeight,int foodX,int foodY)
        {
            bool gameOver = false;
            bool eatFood= false;

            for (int i = Body.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Direction)
                    {
                        case "left":
                            Body[i].X--;
                            break;
                        case "right":
                            Body[i].X++;
                            break;
                        case "up":
                            Body[i].Y--;
                            break;
                        case "down":
                            Body[i].Y++;
                            break;
                    }

                    if (wall)
                    {
                        if (Body[i].X < 0) Body[i].X = maxWidth;
                        if (Body[i].X > maxWidth) Body[i].X = 0;
                        if (Body[i].Y < 0) Body[i].Y = maxHeight;
                        if (Body[i].Y > maxHeight) Body[i].Y = 0;
                    }
                    else
                    {
                        if (Body[i].X < 0 || Body[i].Y < 0 || Body[i].X > maxWidth || Body[i].Y > maxHeight)
                        {
                            gameOver = true;
                        }
                    }

                    if (foodX == Body[i].X && foodY == Body[i].Y)
                        eatFood= true;

                    for (int j = 1; j < Body.Count; ++j)
                    {
                        if (Body[i].X == Body[j].X && Body[i].Y == Body[j].Y)
                            gameOver= true;
                    }

                }

                else
                {
                    Body[i].X = Body[i - 1].X;
                    Body[i].Y = Body[i - 1].Y;
                }
            }

            return (gameOver, eatFood);
        }

        public void Grow()
        {
            Circle newPart = new Circle
            {
                X = Body[Body.Count - 1].X,
                Y = Body[Body.Count - 1].Y
            };
            Body.Add(newPart);
        }
    }
}

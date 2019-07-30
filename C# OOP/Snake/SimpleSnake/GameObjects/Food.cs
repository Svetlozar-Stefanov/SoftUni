

using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleSnake.GameObjects
{
    public abstract class Food : Point
    {
        private char foodSymbol;
        private Random random;
        private Wall wall;

        public Food(Wall wall, char foodSymbol, int points)
            : base(1, 1)
        {
            this.wall = wall;
            this.foodSymbol = foodSymbol;
            FoodPoints = points;
            random = new Random();
        }

        public int FoodPoints { get; private set; }

        public void SetRandomPosition(Queue<Point> snake)
        {
            LeftX = random.Next(0, wall.LeftX);
            TopY = random.Next(0, wall.TopY - 2);

            bool isInSnake = snake.Any(s => s.LeftX == LeftX && s.TopY == TopY);

            while (isInSnake)
            {
                LeftX = random.Next(0, wall.LeftX);
                TopY = random.Next(0, wall.TopY - 2);

                isInSnake = snake.Any(s => s.LeftX == LeftX && s.TopY == TopY);
            }

            Console.BackgroundColor = ConsoleColor.Red;
            Draw(LeftX, TopY, foodSymbol);
            Console.BackgroundColor = ConsoleColor.White;
        }

        public bool IsFoodPoint(Point snake)
        {
            return snake.LeftX == LeftX && snake.TopY == TopY;
        }
    }
}

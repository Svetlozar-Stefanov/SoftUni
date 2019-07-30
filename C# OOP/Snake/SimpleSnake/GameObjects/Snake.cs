

using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleSnake.GameObjects
{
    public class Snake
    {
        private const char emptySpace = ' ';
        private const char snakeSymbol = '\u25CF';
        private const int snakeLength = 6;

        private Queue<Point> elements;
        private List<Food> foods;
        private Wall wall;

        private int nextLeftX = 0;
        private int nextTopY = 0;
        private int foodIndex = 0;

        public Snake(Wall wall)
        {
            elements = new Queue<Point>();
            foods = new List<Food>();
            foodIndex = RandomFoodNumber;
            this.wall = wall;
            GetFoods();
            CreateSnake();

            foods[foodIndex].SetRandomPosition(elements);
        }

        private int RandomFoodNumber => new Random().Next(0, foods.Count());

        public bool IsMoving(Point direction)
        {
            Point snakeHead = elements.Last();

            GetNextPoint(direction, snakeHead);

            bool isPointOfSnake = elements.Any(e => e.LeftX == nextLeftX && e.TopY == nextTopY);

            if (isPointOfSnake)
            {
                return false;
            }

            Point snakeNewHead = new Point(nextLeftX, nextTopY);

            if (wall.IsPointInWall(snakeNewHead))
            {
                return false;
            }

            elements.Enqueue(snakeNewHead);
            snakeNewHead.Draw(snakeSymbol);

            if (foods[foodIndex].IsFoodPoint(snakeNewHead))
            {
                Eat(direction, snakeHead);
            }

            Point snakeTrail = elements.Dequeue();
            snakeTrail.Draw(emptySpace);

            return true;
        }

        private void CreateSnake()
        {
            for (int TopY = 1; TopY <= snakeLength; TopY++)
            {
                elements.Enqueue(new Point(2, TopY));
            }
        }

        private void GetFoods()
        {
            foods.Add(new FoodAsterisk(wall));
            foods.Add(new FoodDollar(wall));
            foods.Add(new FoodHash(wall));
        }

        private void GetNextPoint(Point direction, Point snakeHead)
        {
            nextLeftX = snakeHead.LeftX + direction.LeftX;
            nextTopY = snakeHead.TopY + direction.TopY;
        }

        private void Eat(Point direction, Point currentSnakeHead)
        {
            int length = foods[foodIndex].FoodPoints;

            for (int i = 0; i < length; i++)
            {
                elements.Enqueue(new Point(nextLeftX, nextTopY));
                GetNextPoint(direction,currentSnakeHead);
            }

            foodIndex = RandomFoodNumber;
            foods[foodIndex].SetRandomPosition(elements);
        }
    }
}

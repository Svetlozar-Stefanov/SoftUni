using System;
using System.Linq;

namespace PointInRectangle
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] rectangleCoordinates = ParseInput();

            Rectangle rectangle = new Rectangle(new Point(rectangleCoordinates[0], rectangleCoordinates[1]),
                new Point(rectangleCoordinates[2], rectangleCoordinates[3]));

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int[] pointCoordinates = ParseInput();
                Point point = new Point(pointCoordinates[0], pointCoordinates[1]);

                Console.WriteLine(rectangle.Contains(point));
            }
        }

        private static int[] ParseInput()
        {
                 return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}

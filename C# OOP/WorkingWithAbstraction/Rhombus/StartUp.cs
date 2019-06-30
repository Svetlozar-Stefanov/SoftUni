using System;
using System.Text;

namespace Rhombus
{
    public class StartUp
    {
        static int size;
        public static void Main(string[] args)
        {
            size = int.Parse(Console.ReadLine());

            DrawRhombus(size);
        }

        private static void DrawRhombus(int size)
        {
            for (int stars = 1; stars <= size; stars++)
            {
                Console.WriteLine(DrawLine(stars));
        }
            for (int stars = size - 1; stars >= 1; stars--)
            {
                Console.WriteLine(DrawLine(stars));
            }
        }

        private static string DrawLine(int stars)
        {
            string space = new string(' ', size - stars);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < stars; i++)
            {
                sb.Append("* ");
            }

            return space + sb.ToString().TrimEnd();
        }
    }
}

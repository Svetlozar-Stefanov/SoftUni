using System;

namespace BoxData
{
    static class Engine
    {
        private static Box box;
        public static void Run()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());

            try
            {
                box = new Box(length, width, heigth);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }

            Console.WriteLine(box);
        }
    }
}

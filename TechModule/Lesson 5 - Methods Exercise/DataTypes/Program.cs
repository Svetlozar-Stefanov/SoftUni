using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string input = Console.ReadLine();

            PrintInput(type, input);
        }

        private static void PrintInput(string type, string input)
        {
            if (type == "int")
            {
                int num = int.Parse(input);
                Console.WriteLine(num * 2);
            }
            else if (type == "real")
            {
                double num = double.Parse(input);
                Console.WriteLine($"{(num * 1.5):f2}");
            }
            else
            {
                Console.WriteLine($"${input}$");
            }
        }
    }
}

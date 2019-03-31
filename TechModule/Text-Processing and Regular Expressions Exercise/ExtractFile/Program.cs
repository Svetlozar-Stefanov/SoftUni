using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split("\\");
            string file = path[path.Length - 1];
            string[] substract = file.Split(".");
            string name = substract[0];
            string extension = substract[1];

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");

        }
    }
}

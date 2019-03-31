using System;

namespace ContactsName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            string symbol = Console.ReadLine();

            Console.WriteLine($"{name}{symbol}{surname}");
        }
    }
}

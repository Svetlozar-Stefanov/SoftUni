using System;

namespace ReversedStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = Console.ReadLine().Split(" ");

            Array.Reverse(strArray);

            foreach (var word in strArray)
            {
                Console.Write(word + " ");
            }
        }
    }
}

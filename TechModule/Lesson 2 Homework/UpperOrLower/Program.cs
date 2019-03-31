using System;

namespace UpperOrLower
{
    class Program
    {
        static void Main(string[] args)
        {
            string ch = Console.ReadLine();

            if (ch == ch.ToUpper())
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}

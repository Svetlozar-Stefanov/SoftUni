using System;

namespace CharsInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());

            PrintRange(ch1, ch2);
        }

        private static void PrintRange(char ch1, char ch2)
        {
            int start = ch1;
            int end = ch2;
            if (ch1 > ch2)
            {
                start = ch2;
                end = ch1;
            }
            
            for (int i = start + 1; i < end; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}

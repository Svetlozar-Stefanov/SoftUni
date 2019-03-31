using System;
using System.Text;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeatCount = int.Parse(Console.ReadLine());
            string repeatedString = Repeat(text, repeatCount);
            Console.WriteLine(repeatedString);
        }

        private static string Repeat(string text, int repeatCount)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < repeatCount; i++)
            {
                result.Append(text);
            }
            return result.ToString();
        }
    }
}

using System;

namespace AskiiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            int sum = 0;

            int start = Math.Min((int)firstChar, (int)secondChar);
            int end = Math.Max((int)firstChar, (int)secondChar);

            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > start && input[i] < end)
                {
                    sum += (int)input[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}

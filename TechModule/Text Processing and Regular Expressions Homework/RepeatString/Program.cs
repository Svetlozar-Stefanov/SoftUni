using System;
using System.Text;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder();

            string[] input = Console.ReadLine().Split();

            foreach (var word in input)
            {
                int counter = word.Length;
                for (int i = 0; i < counter; i++)
                {
                    result.Append(word);
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}

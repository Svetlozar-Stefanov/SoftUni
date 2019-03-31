using System;
using System.Collections.Generic;
using System.Linq;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arrayNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string text = Console.ReadLine();

            List<char> listText = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                listText.Add(text[i]);
            }

            string result = "";
            for (int i = 0; i < arrayNumbers.Count; i++)
            {
                int number = arrayNumbers[i];
                int index = Sum(number);
                if (index >= listText.Count)
                {
                    index = 0;
                }
                result += listText[index];
                listText.RemoveAt(index);
            }
            Console.WriteLine(result);
        }

        private static int Sum(int number)
        {
            int sum = 0;
            while (number % 10 != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}

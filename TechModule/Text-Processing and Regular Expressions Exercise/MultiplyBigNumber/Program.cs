using System;
using System.Collections.Generic;
using System.Linq;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            if (number == "0" || multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            List<string> result = new List<string>();

            int reminder = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                int currentNum = ((number[i] - '0') * multiplier) + reminder;

                reminder = currentNum / 10;
                currentNum = currentNum % 10;

                result.Add(currentNum.ToString());
            }
            if (reminder > 0)
            {
                result.Add(reminder.ToString());
            }
            result.Reverse();
            while (result[0] == "0")
            {
                result.RemoveAt(0);
            }
            Console.WriteLine(String.Join("",result));
        }
    }
}

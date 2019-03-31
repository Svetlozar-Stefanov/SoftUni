using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int testNum = number;
            int sum = 0;

            while (testNum != 0)
            {
                int lastDigit = testNum % 10;
                int fact = 1;
                for (int i = 1; i <= lastDigit; i++)
                {
                    fact *= i;
                }
                sum += fact;
                testNum /= 10;
            }
            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}

using System;

namespace SumOfOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int oddnum = 1;
            int sum = 0;

            while (counter < n)
            {
                Console.WriteLine(oddnum);
                sum += oddnum;
                oddnum += 2;
                counter++;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}

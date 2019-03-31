using System;
using System.Linq;

namespace Top3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).Take(3).ToArray();

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}

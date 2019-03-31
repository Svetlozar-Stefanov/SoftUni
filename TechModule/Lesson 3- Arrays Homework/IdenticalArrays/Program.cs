using System;
using System.Linq;

namespace IdenticalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int sum = 0;
            int i = 0;
            if (firstArray.Length == secondArray.Length)
            {
                for (i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] == secondArray[i])
                    {
                        sum += firstArray[i];
                    }
                    else
                    {
                        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                        return;
                    }
                }
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}

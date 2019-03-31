using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int colLength = inputArray.Length / 2;

            int[] upperArray = new int[colLength];
            int[] lowerArray = new int[colLength];

            for (int i = 0; i < colLength / 2; i++)
            {
                upperArray[i] = inputArray[colLength / 2 - 1 - i];
            }

            for (int i = 0; i < colLength; i++)
            {
                lowerArray[i] = inputArray[i + colLength / 2];
            }

            for (int i = 0; i < colLength / 2; i++)
            {
                upperArray[i + colLength / 2] = inputArray[colLength - i + colLength - 1];
            }

            int[] sum = new int[colLength];

            for (int i = 0; i < colLength; i++)
            {
                sum[i] = upperArray[i] + lowerArray[i];
            }
            Console.WriteLine(String.Join(" ",sum));
        }
    }
}

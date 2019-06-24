using System;
using System.Linq;

namespace RecursiveArraySum
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(Sum(input,0));
        }

        public static int Sum(int[] arr, int index)
        {
            if (index == arr.Length - 1)
            {
                return arr[index];
            }
            return arr[index] + Sum(arr, index + 1);
        }
    }
}

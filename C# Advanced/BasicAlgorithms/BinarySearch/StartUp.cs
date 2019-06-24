using System;
using System.Linq;

namespace BinarySearch
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int key = int.Parse(Console.ReadLine());

            int index = Binarysearch.IndexOf(arr, key);
            Console.WriteLine(index);
        }
    }
}

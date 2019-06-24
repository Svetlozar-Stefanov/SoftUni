using System;
using System.Collections.Generic;

namespace MergeSort
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<int> input = new List<int>() { 5, 4, 3, 2, 1 };
            List<int> sorted = Mergesort<int>.Sort(input);
            Console.WriteLine(string.Join(" ",sorted));
        }
    }
}

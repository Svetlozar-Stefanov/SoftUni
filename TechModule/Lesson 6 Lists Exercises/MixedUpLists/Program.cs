using System;
using System.Collections.Generic;
using System.Linq;

namespace MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            int length = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < length; i++)
            {
                result.Add(firstList[i]);
                result.Add(secondList[secondList.Count - 1 - i]);
            }

            //Console.WriteLine(String.Join(" ", result));

            List<int> longerList = new List<int>();

            int start = 0;
            int end = 0;

            if (firstList.Count > secondList.Count)
            {
                start = Math.Min(firstList[firstList.Count - 1], firstList[firstList.Count - 2]);
                end = Math.Max(firstList[firstList.Count - 1], firstList[firstList.Count - 2]);
            }
            else
            {
                start = Math.Min(secondList[0], secondList[1]);
                end = Math.Max(secondList[0], secondList[1]);
            }

            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] <= start || result[i] >= end)
                {
                    result.RemoveAt(i);
                    i--;
                }
            }
            result.Sort();
            Console.WriteLine(String.Join(" ", result));


        }
    }
}

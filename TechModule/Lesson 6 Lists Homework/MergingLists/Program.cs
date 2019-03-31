using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            int length = Math.Min(list1.Count, list2.Count);
            int i;
            for (i = 0; i < length; i++)
            {
                result.Add(list1[i]);
                result.Add(list2[i]);
            }
            if (list1.Count > length)
            {
                for (int j = i; j < list1.Count; j++)
                {
                    result.Add(list1[j]);
                }
            }
            else
            {
                for (int j = i; j < list2.Count; j++)
                {
                    result.Add(list2[j]);
                }
            }
            Console.WriteLine(String.Join(" ",result));
        }
    }
}

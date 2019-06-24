using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeSort
{
    public class Mergesort<T> where T : IComparable<T>
    {
        public static List<T> Sort(List<T> list)
        {
            if (list.Count <= 1)
            {
                return list;
            }
            List<T> left = new List<T>();
            List<T> right = new List<T>();

            int middle = list.Count / 2;
            for (int i = 0; i < middle; i++)
            {
                left.Add(list[i]);
            }
            for (int j = middle; j < list.Count; j++)
            {
                right.Add(list[j]);
            }

            left = Sort(left);
            right = Sort(right);
            return Merge(left, right);
        }
        private static List<T> Merge(List<T> left, List<T> right)
        {
            List<T> result = new List<T>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First().CompareTo(right.First()) < 0)
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return result;
        }
    }
}

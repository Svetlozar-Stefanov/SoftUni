using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch
{
    public class Binarysearch
    {
        public static int IndexOf(int[] arr, int key)
        {
            int lo = 0;
            int hi = arr.Length - 1;
            while (lo <= hi)
            {
                int mid = (lo + hi) / 2;
                if (key == arr[mid])
                {
                    return mid;
                }
                else if (key < arr[mid])
                {
                    hi = mid - 1;
                }
                else if (key > arr[mid])
                {
                    lo = mid + 1;
                }
            }
            return default(int);
        }
    }
}

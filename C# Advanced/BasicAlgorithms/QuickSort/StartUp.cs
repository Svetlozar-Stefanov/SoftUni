using System;

namespace QuickSort
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[]
            {
                5, 4, 3, 2, 1
            };

            QuickSort(arr, 0, arr.Length - 1);

            Console.WriteLine(string.Join(" ",arr));
        }

        private static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);
                if (pivot > 1)
                {
                    QuickSort(arr, left, right - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(arr, pivot + 1, right); 
                }
            }
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right])
                    {
                        return right;
                    }
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}

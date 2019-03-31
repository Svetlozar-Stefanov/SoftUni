using System;
using System.Linq;

namespace zig_zag
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];
            int[] array2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] number = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    array1[i] = number[0];
                    array2[i] = number[1];
                }
                else
                {
                    array1[i] = number[1];
                    array2[i] = number[0];
                }
            }

            foreach (var num in array1)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            foreach (var num in array2)
            {
                Console.Write(num + " ");
            }
        }
    }
}

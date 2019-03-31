using System;
using System.Linq;

namespace TopInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length-1; i++)
            {
                bool bigger = false;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        bigger = true;
                    }
                    else
                    {
                        bigger = false;
                        break;
                    }
                }
                if (bigger)
                {
                    Console.Write(array[i] + " ");
                }
            }
            Console.Write(array[array.Length - 1]);
        }
    }
}

using System;
using System.Linq;

namespace Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] oldArray = new int[array.Length];
            int rotate = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotate; i++)
            {
                for (int j = 0; j < array.Length-1; j++)
                {
                    oldArray[j] = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = oldArray[j];
                }
            }

            foreach (var item in array)
            {
                Console.Write(item+" ");
            }
        }
    }
}

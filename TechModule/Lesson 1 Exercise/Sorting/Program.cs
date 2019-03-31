using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];
            for (int i = 0; i < 3; i++)
            {
                int number = int.Parse(Console.ReadLine());
                array[i] = number;
            }

            Array.Sort(array);

            for (int i = 2; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}

using System;

namespace Similar_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split(" ");
            string[] array2 = Console.ReadLine().Split(" ");

            for (int i1 = 0; i1 < array1.Length; i1++)
            {
                for (int i2 = 0; i2 < array2.Length; i2++)
                {
                    if (array1[i1] == array2[i2])
                    {
                        Console.Write(array2[i2] + " ");
                    }
                }
            }
        }
    }
}

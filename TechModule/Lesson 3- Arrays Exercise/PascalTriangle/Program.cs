using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine(1);
                return;
            }
            int[,] array = new int[n,n];

            int row, col;
            for (row = 0; row < n; row++)

                for (col = 0; col < n; col++) array[row, col] = 0;
            array[0, 0] = 1;
            array[1, 0] = 1;
            array[1, 1] = 1;

            for (row = 2; row < n; row++)
            {
                array[row, 0] = 1;
                for (col = 1; col <= row; col++)
                {
                    array[row, col] = array[row - 1, col - 1] + array[row-1, col];
                }
            }

            for (row = 0; row < n; row++)
            {

                for (col = 0; col <= row; col++)
                {

                    Console.Write($"{array[row,col]} ");

                }
                Console.WriteLine();
            }



        }
    }
}

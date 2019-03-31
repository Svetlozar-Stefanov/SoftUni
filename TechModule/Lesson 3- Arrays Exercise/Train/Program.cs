using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] wagons = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                sum += wagons[i];
            }

            foreach (var number in wagons)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);

        }
    }
}

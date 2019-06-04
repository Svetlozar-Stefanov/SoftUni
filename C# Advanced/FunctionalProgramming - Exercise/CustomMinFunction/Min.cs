namespace CustomMinFunction
{
    using System;
    using System.Linq;

    public class Min
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(Minimal(numbers));
        }

        public static Func<int[], int> Minimal = n =>
         {
             int min = int.MaxValue;

             foreach (var item in n)
             {
                 if (item < min)
                 {
                     min = item;
                 }
             }
             return min;
         };

    }
}

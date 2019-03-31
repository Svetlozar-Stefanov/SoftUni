using System;
using System.Linq;

namespace CondensedSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int index = 0;
            while (numbers.Length != 1)
            {
                int[] condenser = new int[numbers.Length-1];
                for (int i = 0; i < condenser.Length; i++)
                {
                    condenser[i] = numbers[i] + numbers[i + 1];
                }
                numbers = new int[condenser.Length];
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = condenser[i];
                }
            }
            Console.WriteLine(numbers[0]);
        }
    }
}

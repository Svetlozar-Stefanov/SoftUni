namespace AppliedArithmetics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Calculator
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            while (command != "end")
            {
                if (command == "add")
                {
                    AddOne(numbers);
                }
                else if(command == "multiply")
                {
                    Multiply(numbers);
                }
                else if (command == "subtract")
                {
                    Subtract(numbers);
                }
                else if (command == "print")
                {
                    Console.WriteLine(string.Join(" ",numbers));
                }

                command = Console.ReadLine();
            }
        }

        public static Action<List<int>> AddOne = arr =>
        {
            for (int i = 0; i < arr.Count; i++)
            {
                arr[i]++;
            }
        };

        public static Action<List<int>> Multiply = arr =>
        {
            for (int i = 0; i < arr.Count; i++)
            {
                arr[i] *= 2;
            }
        };

        public static Action<List<int>> Subtract = arr =>
        {
            for (int i = 0; i < arr.Count; i++)
            {
                arr[i]--;
            }
        };
    }
}

using System;

namespace FactorialDivide
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            decimal secondNumber = decimal.Parse(Console.ReadLine());

            decimal result = GetFactorial(firstNumber) / GetFactorial(secondNumber);
            Console.WriteLine($"{result:f2}");
        }

        private static decimal GetFactorial(decimal number)
        {
            decimal factroial = 1;
            for (int i = 1; i <= number; i++)
            {
                factroial *= i;
            }
            return factroial;
        }
    }
}

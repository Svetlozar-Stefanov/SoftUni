using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            char action = char.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            PrintOperation(firstNumber, action, secondNumber);
        }

        private static void PrintOperation(double n1, char op, double n2)
        {
            double result = 0;
            if (op == '+')
            {
                result = Add(n1, n2);
            }
            else if (op == '*')
            {
                result = Multiply(n1, n2);
            }
            else if (op == '-')
            {
                result = Subtract(n1, n2);
            }
            else if (op == '/')
            {
                result = Divide(n1, n2);
            }

            Console.WriteLine(Math.Round(result));
        }

        private static double Divide(double n1, double n2)
        {
            return n1 / n2;
        }

        private static double Subtract(double n1, double n2)
        {
            return n1 - n2;
        }

        private static double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }

        private static double Add(double n1, double n2)
        {
            return n1 + n2;
        }
    }
}

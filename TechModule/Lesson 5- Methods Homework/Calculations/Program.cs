using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (action == "add")
            {
                Add(firstNum, secondNum);
            }
            else if (action == "multiply")
            {
                Multiply(firstNum, secondNum);
            }
            else if (action == "subtract")
            {
                Subtract(firstNum, secondNum);
            }
            else if (action == "divide")
            {
                Divide(firstNum, secondNum);
            }
        }

        private static void Divide(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum / secondNum);
        }

        private static void Subtract(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum - secondNum);
        }

        private static void Multiply(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum * secondNum);
        }

        private static void Add(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum + secondNum);
        }
    }
}

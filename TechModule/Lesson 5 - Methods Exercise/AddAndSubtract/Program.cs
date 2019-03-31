using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int result = Result(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(result);
        }

        private static int Result(int firstNumber, int secondNumber, int thirdNumber)
        {
            return Subtraction(firstNumber, secondNumber, thirdNumber);
        }

        private static int Subtraction(int firstNumber, int secondNumber, int thirdNumber)
        {
            return Add(firstNumber, secondNumber) - thirdNumber;
        }

        private static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}

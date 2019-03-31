using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            string calculation = Console.ReadLine();

            if (calculation == "+")
            {
                double cal = number1 + number2;

                if (cal % 2 == 0)
                {
                    Console.WriteLine($"{number1} + {number2} = {cal} - even");
                }
                else
                {
                    Console.WriteLine($"{number1} + {number2} = {cal} - odd");
                }
            }
            else if (calculation == "-")
            {
                double cal = number1 - number2;

                if (cal % 2 == 0)
                {
                    Console.WriteLine($"{number1} - {number2} = {cal} - even");
                }
                else
                {
                    Console.WriteLine($"{number1} - {number2} = {cal} - odd");
                }
            }
            else if (calculation == "*")
            {
                double cal = number1 * number2;

                if (cal % 2 == 0)
                {
                    Console.WriteLine($"{number1} * {number2} = {cal} - even");
                }
                else
                {
                    Console.WriteLine($"{number1} * {number2} = {cal} - odd");
                }
            }

            else if (calculation == "/")
            {

                if (number2 == 0)
                {
                    Console.WriteLine($"Cannot divide {number1} by zero");
                }
                else
                {
                    double cal = number1 / number2;

                    Console.WriteLine($"{number1} / {number2} = {cal:f2}");
                }
               
                
            }
            else if (calculation == "%")
            {
                if (number2 == 0)
                {
                    Console.WriteLine($"Cannot divide {number1} by zero");
                }
                else
                {
                    double cal = number1 % number2;

                    Console.WriteLine($"{number1} % {number2} = {cal}");
                }

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator v1.0");
            Console.Write("Write NEW to start a new operation: ");
            double result = 0;

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                if (command == "cont")
                {
                    Console.WriteLine(result);
                    char calculation = char.Parse(Console.ReadLine());
                    double num2 = double.Parse(Console.ReadLine());

                    if (calculation == '+')
                    {
                        result = result + num2;
                    }
                    else if (calculation == '-')
                    {
                        result = result - num2;
                    }
                    else if (calculation == '*')
                    {
                        result = result * num2;
                    }
                    else if (calculation == '/')
                    {
                        result = result / num2;
                    }
                    else if (calculation == '%')
                    {
                        result = result % num2;
                    }
                    Console.WriteLine($"Result = {result:f2}");
                    Console.WriteLine("");

                }
                if(command == "new")
                {
                    Console.WriteLine("Enter an operation:");
                    double num1 = double.Parse(Console.ReadLine());
                    char calculation = char.Parse(Console.ReadLine());
                    double num2 = double.Parse(Console.ReadLine());

                    if (calculation == '+')
                    {
                        result = num1 + num2;
                    }
                    else if (calculation == '-')
                    {
                        result = num1 - num2;
                    }
                    else if (calculation == '*')
                    {
                        result = num1 * num2;
                    }
                    else if (calculation == '/')
                    {
                        result = num1 / num2;
                    }
                    else if (calculation == '%')
                    {
                        result = num1 % num2;
                    }
                    Console.WriteLine($"Result = {result:f2}");
                    Console.WriteLine("");
                 
                }
                Console.WriteLine("Do you wish to proceed?");
                Console.WriteLine("Choose command - cont || new || end");
                command = Console.ReadLine().ToLower();
                Console.WriteLine("");
            }
            Console.WriteLine("Thank you for using Calculator v1.0");
            Console.WriteLine("");
        }
    }
}

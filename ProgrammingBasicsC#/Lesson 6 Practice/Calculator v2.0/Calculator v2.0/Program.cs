using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_v2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            double num = 0;
            char operation = '1';

            Console.WriteLine("---------------------------");
            Console.WriteLine("Welcome to Calculator v2.0");
            Console.WriteLine("---------------------------");
            Console.WriteLine("");
            Console.Write("Write NEW to start: ");
            string command = Console.ReadLine().ToLower();
            Console.WriteLine("");

            while (command != "end")
            {
                if (command == "new")
                {
                    result = 0;
                    Console.WriteLine("How many numbers do you wish to calculate: ");
                    int n = int.Parse(Console.ReadLine());

                    Console.WriteLine("");
                    Console.WriteLine("Enter your operation: ");
                    for (int i = 1; i <= n; i++)
                    {
                        if (i == 1)
                        {
                            num = double.Parse(Console.ReadLine());
                            result = num;
                            operation = '1';
                        }
                        else
                        {
                            operation = char.Parse(Console.ReadLine());
                            num = double.Parse(Console.ReadLine());
                        }
                        if (operation == '+')
                        {
                            result += num;
                        }
                        else if (operation == '-')
                        {                                                  
                            result -= num;                        
                        }
                        else if (operation == '*')
                        {
                            result *= num;
                        }
                        else if (operation == '/')
                        {
                            result /= num;
                        }
                      
                    }
                    Console.WriteLine($"Result = {result:f2}");
                    Console.WriteLine("");
                }
                if (command == "cont")
                {
                    Console.WriteLine("How many numbers do you wish to calculate: ");
                    int n = int.Parse(Console.ReadLine());

                    Console.WriteLine("");
                    Console.WriteLine(result);
                    for (int i = 1; i <= n - 1; i++)
                    {
                        operation = char.Parse(Console.ReadLine());
                        num = double.Parse(Console.ReadLine());


                        if (operation == '+')
                        {
                            result += num;
                        }
                        else if (operation == '-')
                        {
                            result -= num;
                        }
                        else if (operation == '*')
                        {
                            result *= num;
                        }
                        else if (operation == '/')
                        {
                            result /= num;
                        }
                    }
                    Console.WriteLine($"Result = {result:f2}");
                    Console.WriteLine("");
                }
                Console.WriteLine("Do you wish to proceed?");
                Console.WriteLine("Enter command - new || cont || end");
                command = Console.ReadLine().ToLower();
                Console.WriteLine("");
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Thanks for using Calculator v2.0");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("");

        }
    }
}

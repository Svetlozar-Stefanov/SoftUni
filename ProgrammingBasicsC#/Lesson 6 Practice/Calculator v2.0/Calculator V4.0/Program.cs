using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_V4._0
{
    class Program
    {
        static void Main(string[] args)
        {
            double finalResult = 0;
            string command = Console.ReadLine().ToLower();
            while (command != "end")
            {
                if (command == "c")
                {
                    finalResult = 0;
                    finalResult += Operation();
                    Console.WriteLine(finalResult);
                }
                else
                {
                    finalResult += Operation();
                    Console.WriteLine(finalResult);
                }
                Console.WriteLine("enter command");
                command = Console.ReadLine();
            }
        }

        static double Calculate(double firstN, double n, char op)
        {
            double sum = firstN;
            if (op == '+')
            {
                sum += n;
            }
            else if (op == '-')
            {
                sum -= n;
            }
            else if (op == '*')
            {
                sum *= n;
            }
            else if (op == '/')
            {
                sum /= n;
            }
            return sum;
        }

        static double Operation()
        {
            double result = 0;
            double firstN = double.Parse(Console.ReadLine());
            while (true)
            {
                char op = char.Parse(Console.ReadLine());
                if (op == '=')
                {
                    return result;
                }
                double n = double.Parse(Console.ReadLine());

                if (op == '(')
                {
                    double permanentSum = 0;
                    while (true)
                    {
                        firstN = double.Parse(Console.ReadLine());
                        op = char.Parse(Console.ReadLine());
                        if (op == ')')
                        {
                            result += permanentSum;
                            continue;
                        }
                        n = double.Parse(Console.ReadLine());
                        permanentSum += Calculate(firstN, n, op);
                    }
                }
                else
                {
                    result += Calculate(firstN, n, op);
                }
            }
        }
    }
}

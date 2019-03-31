using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftNRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                double leftSum = 0;
                double rightSum = 0;

                string num = i.ToString();
                leftSum += Char.GetNumericValue(num[0]) + Char.GetNumericValue(num[1]);
                rightSum += Char.GetNumericValue(num[3]) + Char.GetNumericValue(num[4]);
                if (leftSum == rightSum)
                {
                    Console.Write(i + " ");
                }
                else if (leftSum > rightSum)
                {
                    rightSum += Char.GetNumericValue(num[2]);
                    if (rightSum == leftSum)
                    {
                        Console.Write(i + " ");
                    }
                }
                else
                {
                    leftSum += Char.GetNumericValue(num[2]);
                    if (rightSum == leftSum)
                    {
                        Console.Write(i + " ");
                    }
                }
                i = int.Parse(num);
            }

        }
    }
}

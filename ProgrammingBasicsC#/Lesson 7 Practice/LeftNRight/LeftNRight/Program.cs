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

            for (int i = num1; i < num2; i++)
            {
                double leftSum = 0;
                double rightSum = 0;

                string num = num1.ToString();
                leftSum += (char)num[0] + (char)num[1];
                Console.WriteLine(leftSum);
            }
            
        }
    }
}

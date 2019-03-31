using System;

namespace FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            bool equal = (Math.Max(num1,num2) - Math.Min(num1, num2)) < 0.000001;

            Console.WriteLine(equal);
        }
    }
}

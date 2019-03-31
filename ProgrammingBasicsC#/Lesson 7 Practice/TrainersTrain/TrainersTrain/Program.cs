using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainersTrain
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double grade = 0;
            int counter = 0;
            double finalSum = 0;

            while (command != "Finish")
            {
                double midSum = 0;
                string subject = command;

                for (int i = 0; i < n; i++)
                {
                    grade = double.Parse(Console.ReadLine());
                    midSum += grade;
                }
                Console.WriteLine($"{subject} - {(midSum/n):f2}.");
                finalSum += midSum;
                counter++;
                command = Console.ReadLine();

            }
            Console.WriteLine($"Student's final assessment is {(finalSum/(n * counter)):f2}.");

        }
    }
}

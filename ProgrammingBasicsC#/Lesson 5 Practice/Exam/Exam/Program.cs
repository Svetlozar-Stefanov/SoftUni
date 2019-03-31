using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxBadGrades = int.Parse(Console.ReadLine());
            int badGrades = 0;
            string input = Console.ReadLine();
            double sum = 0;
            int counter = 0;
            string nameTask = "";
            double grade = 0;

            while (input != "Enough")
            {
                nameTask = input;
                grade = int.Parse(Console.ReadLine());
                sum += grade;
                
                if (grade <= 4)
                {
                    badGrades++;
                    if (badGrades >= maxBadGrades)
                    {
                        Console.WriteLine($"You need a break, {badGrades} poor grades.");
                        return;
                    }
                }
                input = Console.ReadLine();
                counter++;
            }
            double avg = sum / counter;
            if (input == "Enough")
            {
                Console.WriteLine($"Average score: {avg:f2}");
                Console.WriteLine($"Number of problems: {counter}");
                Console.WriteLine($"Last problem: {nameTask}");
            }
        }
    }
}

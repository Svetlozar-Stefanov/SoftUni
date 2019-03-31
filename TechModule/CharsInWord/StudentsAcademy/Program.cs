using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students[name] = new List<double>();
                }
                students[name].Add(grade);
            }

            students = students.Where(x => x.Value.Average() >= 4.5).OrderByDescending(x => x.Value.Average()).ToDictionary(x => x.Key, x => x.Value);

            foreach (var person in students)
            {
                Console.WriteLine($"{person.Key} -> {person.Value.Average():f2}");
            }

        }
    }
}

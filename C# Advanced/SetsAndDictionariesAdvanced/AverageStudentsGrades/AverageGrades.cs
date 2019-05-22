namespace AverageStudentsGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageGrades
    {
        public static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                double grade = double.Parse(input[1]);

                if (!grades.ContainsKey(name))
                {
                    grades[name] = new List<double>();
                }
                grades[name].Add(grade);
            }

            foreach (var pair in grades)
            {
                Console.Write($"{pair.Key} -> ");
                foreach (var grade in pair.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.Write($"(avg: {pair.Value.Average():f2})");
                Console.WriteLine();
            }
        }
    }
}

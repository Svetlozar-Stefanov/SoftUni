using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            Dictionary<string, int> languages = new Dictionary<string, int>();

            string input = Console.ReadLine();
            while (input != "exam finished")
            {
                string[] info = input.Split("-");

                if (info[1] == "banned")
                {
                    string name = info[0];
                    students.Remove(name);
                }
                else
                {
                    string name = info[0];
                    string language = info[1];
                    int points = int.Parse(info[2]);

                    if (!students.ContainsKey(name))
                    {
                        students[name] = 0;
                    }
                    if (students[name] < points)
                    {
                        students[name] = points;
                    }

                    if (!languages.ContainsKey(language))
                    {
                        languages[language] = 0;
                    }
                    languages[language]++;
                }

                input = Console.ReadLine();
            }

            students = students.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine($"Results:");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }

            languages = languages.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine("Submissions:");
            foreach (var language in languages)
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}

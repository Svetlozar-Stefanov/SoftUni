using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string[] command = Console.ReadLine().Split(" : ");
            while (command[0] != "end")
            {
                string courseName = command[0];
                string studetName = command[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new List<string>();
                }
                courses[courseName].Add(studetName);

                command = Console.ReadLine().Split(" : ");
            }

            courses = courses.OrderByDescending(x => x.Value.Count).ToDictionary(x => x.Key, x => x.Value);

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                course.Value.Sort();
                for (int i = 0; i < course.Value.Count; i++)
                {
                    Console.WriteLine($"-- {course.Value[i]}");
                }
            }
        }
    }
}

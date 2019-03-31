using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();

            string[] input = Console.ReadLine().Split(":");
            while (input[0].ToLower() != "end of contests")
            {
                if (input.Length >= 2)
                {
                    string contest = input[0];
                    string password = input[1];

                    if (!contests.ContainsKey(contest))
                    {
                        contests[contest] = "";
                    }
                    contests[contest] = password;
                }
                input = Console.ReadLine().Split(":");
            }

            Dictionary<string, Dictionary<string, int>> students = new Dictionary<string, Dictionary<string, int>>();

            input = Console.ReadLine().Split("=>");

            while (input[0] != "end of submissions")
            {
                if (input.Length >= 4)
                {
                    string contest = input[0];
                    string password = input[1];
                    string username = input[2];
                    int points = int.Parse(input[3]);

                    if (contests.ContainsKey(contest))
                    {
                        if (contests[contest] == password)
                        {
                            if (!students.ContainsKey(username))
                            {
                                students[username] = new Dictionary<string, int>
                            {
                                { contest, points }
                            };
                            }
                            if (!students[username].ContainsKey(contest))
                            {
                                students[username].Add(contest, points);
                            }
                            if (students[username][contest] < points)
                            {
                                students[username][contest] = points;
                            }
                        }
                    }
                }   
                input = Console.ReadLine().Split("=>");
            }

            var bestStudent = "";
            int bestPoints = int.MinValue;
            foreach (var student in students)
            {
                int currentPoints = 0;
                currentPoints += student.Value.Values.Sum();
                if (currentPoints > bestPoints)
                {
                    bestPoints = currentPoints;
                    bestStudent = student.Key;
                }
            }

            if (students.Count > 0)
            {
                Console.WriteLine($"Best candidate is {bestStudent} with total {bestPoints} points.");

                Console.WriteLine("Ranking: ");
                students = students.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
                foreach (var student in students)
                {
                    Console.WriteLine(student.Key);
                    var currentContests = student.Value;
                    currentContests = currentContests.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                    foreach (var item in currentContests)
                    {
                        Console.WriteLine($"#  {item.Key} -> {item.Value}");
                    }
                }
            }
        }
    }
}

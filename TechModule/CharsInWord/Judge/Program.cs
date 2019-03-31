using System;
using System.Collections.Generic;
using System.Linq;

namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();

            string[] input = Console.ReadLine().Split(" -> ");
            while (input[0] != "no more time")
            {
                string username = input[0];
                string contest = input[1];
                int points = int.Parse(input[2]);

                if (!contests.ContainsKey(contest))
                {
                    contests[contest] = new Dictionary<string, int>();
                }
                if (!contests[contest].ContainsKey(username))
                {
                    contests[contest].Add(username, 0);
                }
                if (contests[contest][username] < points)
                {
                    contests[contest][username] = points;
                }
                
                input = Console.ReadLine().Split(" -> ");
            }

            foreach (var contest in contests)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                var students = contest.Value.ToDictionary(x => x.Key, x => x.Value);
                students = students.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
                int position = 1;
                foreach (var student in students)
                {
                    Console.WriteLine($"{position}. {student.Key} <::> {student.Value}");
                    position++;
                }
            }

            var individualScore = new Dictionary<string, int>();
            foreach (var contest in contests)
            {
                foreach (var student in contest.Value)
                {
                    if (!individualScore.ContainsKey(student.Key))
                    {
                        individualScore.Add(student.Key, 0);
                    }
                    individualScore[student.Key] += student.Value;
                }
            }

            individualScore = individualScore.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine("Individual standings:");
            int position2 = 1;
            foreach (var score in individualScore)
            {
                Console.WriteLine($"{position2}. {score.Key} -> {score.Value}");
                position2++;
            }
        }
    }
}

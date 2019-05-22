namespace Ranking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Rank
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();

            string[] input = Console.ReadLine()
                .Split(":", StringSplitOptions.RemoveEmptyEntries);

            while (input[0]?.ToLower() != "end of contests")
            {
                string contestName = input[0];
                string password = input[1];

                if (!contests.ContainsKey(contestName))
                {
                    contests[contestName] = "";
                }
                contests[contestName] = password;

                input = Console.ReadLine()
                .Split(":", StringSplitOptions.RemoveEmptyEntries);
            }

            Dictionary<string, Dictionary<string, int>> students = new Dictionary<string, Dictionary<string, int>>();

            input = Console.ReadLine()
                .Split("=>", StringSplitOptions.RemoveEmptyEntries);
            while (input[0]?.ToLower() != "end of submissions")
            {
                string contest = input[0];
                string password = input[1];
                string username = input[2];
                int points = int.Parse(input[3]);

                if (contests.ContainsKey(contest) && contests[contest] == password)
                {
                    if (!students.ContainsKey(username))
                    {
                        students[username] = new Dictionary<string, int>();
                    }
                    if (!students[username].ContainsKey(contest))
                    {
                        students[username][contest] = 0;
                    }
                    if (points > students[username][contest])
                    {
                        students[username][contest] = points;
                    }
                }

                input = Console.ReadLine()
                .Split("=>", StringSplitOptions.RemoveEmptyEntries);
            }

            string bestCandidate = "";
            int bestResult = int.MinValue;
            foreach (var student in students)
            {
                if (student.Value.Values.Sum() > bestResult)
                {
                    bestResult = student.Value.Values.Sum();
                    bestCandidate = student.Key;
                }
            }
            
            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestResult} points.");
            Console.WriteLine("Ranking: ");
            foreach (var student in students.OrderBy(x => x.Key))
            {
                Console.WriteLine(student.Key);
                foreach (var contest in student.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}

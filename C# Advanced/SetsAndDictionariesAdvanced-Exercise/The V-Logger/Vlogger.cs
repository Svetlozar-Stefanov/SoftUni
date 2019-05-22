namespace The_V_Logger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Vlogger
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Statistics> vLogger = new Dictionary<string, Statistics>();

            string input = Console.ReadLine();
            while (input?.ToLower() != "statistics")
            {
                if (input.Contains("joined The V-Logger"))
                {
                    string[] info = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string vloggername = info[0];

                    if (!vLogger.ContainsKey(vloggername))
                    {
                        vLogger[vloggername] = new Statistics();
                    }
                }
                else if (input.Contains(" followed "))
                {
                    string[] info = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string vlogger1 = info[0];
                    string vlogger2 = info[2];

                    if (vLogger.ContainsKey(vlogger1) && vLogger.ContainsKey(vlogger2))
                    {
                        if (vlogger1 != vlogger2 && !vLogger[vlogger2].Followers.Contains(vlogger1))
                        {
                            vLogger[vlogger2].Followers.Add(vlogger1);
                            vLogger[vlogger2].FollowedBy++;
                            vLogger[vlogger1].Following++;
                        }
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vLogger.Count} vloggers in its logs.");
            vLogger = vLogger
                .OrderByDescending(x => x.Value.FollowedBy)
                .ThenBy(x => x.Value.Following)
                .ToDictionary(x => x.Key, x => x.Value);
            int index = 1;
            foreach (var vlogger in vLogger)
            {
                if (index == 1)
                {
                    Console.WriteLine($"{index}. {vlogger.Key} : {vlogger.Value.FollowedBy} followers, {vlogger.Value.Following} following");
                    if (vlogger.Value.Followers.Count > 0)
                    {
                        foreach (var follower in vlogger.Value.Followers.OrderBy(x => x))
                        {
                            Console.WriteLine($"*  {follower}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"{index}. {vlogger.Key} : {vlogger.Value.FollowedBy} followers, {vlogger.Value.Following} following");
                }
                index++;
            }
        }
    }

    public class Statistics
    {
        public Statistics()
        {
            Following = 0;
            FollowedBy = 0;
            Followers = new List<string>();
        }
        public int Following { get; set; }
        public int FollowedBy { get; set; }

        public List<string> Followers { get; set; }
    }
}

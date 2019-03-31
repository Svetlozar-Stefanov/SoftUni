using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string[] command = Console.ReadLine().Split(" -> ");
            while (command[0] != "End")
            {
                string company = command[0];
                string id = command[1];

                if (!companies.ContainsKey(company))
                {
                    companies[company] = new List<string>();
                }

                if (!companies[company].Contains(id))
                {
                    companies[company].Add(id);
                }

                command = Console.ReadLine().Split(" -> ");
            }

            companies = companies.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var company in companies)
            {
                Console.WriteLine($"{company.Key}");
                for (int i = 0; i < company.Value.Count; i++)
                {
                    Console.WriteLine($"-- {company.Value[i]}");
                }
            }
        }
    }
}

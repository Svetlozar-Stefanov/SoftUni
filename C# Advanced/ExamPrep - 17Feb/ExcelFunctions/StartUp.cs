using System;
using System.Collections.Generic;
using System.Linq;

namespace ExcelFunctions
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            List<string> header = new List<string>();
            List<List<string>> table = new List<List<string>>();

            for (int i = 0; i < size; i++)
            {
                string[] info = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                if (i == 0)
                {
                    header = info.ToList();
                    continue;
                }
                table.Add(new List<string>(info));
            }

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string command = input[0];
            if (command.ToLower() == "hide")
            {
                string headerToDelete = input[1];
                int index = header.IndexOf(headerToDelete);

                header.RemoveAt(index);
                for (int i = 0; i < table.Count; i++)
                {
                    table[i].RemoveAt(index);
                }
            }
            else if (command.ToLower() == "sort")
            {
                string sortHeader = input[1];
                int index = header.IndexOf(sortHeader);

                table = table.OrderBy(i => i[index]).ToList();
            }
            else if (command.ToLower() == "filter")
            {
                string filterHeader = input[1];
                string value = input[2];
                int index = header.IndexOf(filterHeader);

                for (int i = 0; i < table.Count; i++)
                {
                    var row = table[i];
                    if (row[index] != value)
                    {
                        table.Remove(row);
                        i--;
                    }
                }
            }
            Console.WriteLine(string.Join(" | ",header));
            foreach (var row in table)
            {
                Console.WriteLine(string.Join(" | ", row));
            }
        }
    }
}

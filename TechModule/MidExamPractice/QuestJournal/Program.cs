using System;
using System.Collections.Generic;
using System.Linq;

namespace QuestJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine().Split(", ").ToList();

            string[] command = Console.ReadLine().Split(" - ");

            while (command[0] != "Retire!")
            {
                if (command[0] == "Start")
                {
                    if (!journal.Contains(command[1]))
                    {
                        journal.Add(command[1]);
                    }
                }
                else if (command[0] == "Complete")
                {
                    if (journal.Contains(command[1]))
                    {
                        journal.Remove(command[1]);
                    }
                }
                else if (command[0] == "Side Quest")
                {
                    string[] sideQuest = command[1].Split(":");
                    if (journal.Contains(sideQuest[0]) && !journal.Contains(sideQuest[1]))
                    {
                        journal.Insert(journal.IndexOf(sideQuest[0]) + 1, sideQuest[1]);
                    }
                }
                else if (command[0] == "Renew")
                {
                    if (journal.Contains(command[1]))
                    {
                        journal.Remove(command[1]);
                        journal.Add(command[1]);
                    }
                }

                command = Console.ReadLine().Split(" - ");
            }

            Console.WriteLine(String.Join(", ", journal));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace SantasList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> naughtyList = Console.ReadLine().Split("&").ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "Finished!")
            {
                if (command[0] == "Bad")
                {
                    if (!naughtyList.Contains(command[1]))
                    {
                        naughtyList.Insert(0, command[1]);
                    }
                }
                else if (command[0] == "Good")
                {
                    if (naughtyList.Contains(command[1]))
                    {
                        naughtyList.Remove(command[1]);
                    }
                }
                else if (command[0] == "Rename")
                {
                    if (naughtyList.Contains(command[1]))
                    { 
                        naughtyList[naughtyList.IndexOf(command[1])] = command[2];
                    }
                }
                else if (command[0] == "Rearrange")
                {
                    if (naughtyList.Contains(command[1]))
                    {
                        naughtyList.Remove(command[1]);
                        naughtyList.Add(command[1]);
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(String.Join(", ", naughtyList));
        }
    }
}

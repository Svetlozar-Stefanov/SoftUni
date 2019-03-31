using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().ToLower().Split().ToArray();
            while (command[0] != "end")
            {
                if (command[0] == "delete")
                {
                    int numToDelete =int.Parse(command[1]);
                    list.RemoveAll(x => x == numToDelete);
                }
                else if (command[0] == "insert")
                {
                    int element = int.Parse(command[1]);
                    int position = int.Parse(command[2]);

                    list.Insert(position, element);
                }

                command = Console.ReadLine().ToLower().Split().ToArray();
            }

            Console.WriteLine(String.Join(" ", list));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagon = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());

            string[] command = Console.ReadLine().ToLower().Split().ToArray();
            while (command[0] != "end")
            {
                if (command[0] == "add")
                {
                    int num = int.Parse(command[1]);
                    wagon.Add(num);
                }
                else
                {
                    int num = int.Parse(command[0]);
                    for (int i = 0; i < wagon.Count; i++)
                    {
                        if (wagon[i] + num <= capacity)
                        {
                            wagon[i] += num;
                            break;
                        }
                    }
                }
                command = Console.ReadLine().ToLower().Split().ToArray();
            }

            Console.WriteLine(String.Join(" ", wagon));
        }
    }
}

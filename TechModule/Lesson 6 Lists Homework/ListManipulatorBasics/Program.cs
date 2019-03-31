using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulatorBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> check = numList.ToList();
            string[] command = Console.ReadLine().ToLower().Split().ToArray();
            while (command[0] != "end")
            {
                if (command[0] == "add")
                {
                    int numAdd = int.Parse(command[1]);
                    numList.Add(numAdd);
                }

                else if (command[0] == "remove")
                {
                    int numRemove = int.Parse(command[1]);
                    numList.Remove(numRemove);
                }

                else if (command[0] == "removeat")
                {
                    int numRemoveIndex = int.Parse(command[1]);
                    numList.RemoveAt(numRemoveIndex);
                }

                else if (command[0] == "insert")
                {
                    int num = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    numList.Insert(index, num);
                }

                else if (command[0] == "contains")
                {
                    int checkNum = int.Parse(command[1]);
                    if (numList.Contains(checkNum))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }

                else if (command[0] == "printeven")
                {
                    List<int> evenList = numList.Where(x => x % 2 == 0).ToList();
                    Console.WriteLine(String.Join(" ", evenList));
                }

                else if (command[0] == "printodd")
                {
                    List<int> oddList = numList.Where(x => x % 2 != 0).ToList();
                    Console.WriteLine(String.Join(" ", oddList));
                }

                else if (command[0] == "getsum")
                {
                    Console.WriteLine(numList.Sum());
                }

                else if (command[0] == "filter")
                {
                    string condition = command[1];
                    int num = int.Parse(command[2]);
                    if (condition == ">")
                    {
                        Console.WriteLine(string.Join(" ", numList.Where(x => x > num)));
                    }
                    else if (condition == ">=")
                    {
                        Console.WriteLine(String.Join(" ", numList.Where(x => x >= num)));
                    }
                    else if (condition == "<")
                    {
                        Console.WriteLine(string.Join(" ", numList.Where(x => x < num)));
                    }
                    else if (condition == "<=")
                    {

                        Console.WriteLine(String.Join(" ", numList.Where(x => x <= num)));
                    }
                }

                command = Console.ReadLine().ToLower().Split().ToArray();
            }

            if (!numList.SequenceEqual(check))
            {
                Console.WriteLine(string.Join(" ", numList));
            }
        }
    }
}

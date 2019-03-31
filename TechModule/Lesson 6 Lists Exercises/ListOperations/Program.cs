using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNum = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().ToLower().Split().ToArray();

            while (command[0] != "end")
            {
                if (command[0] == "add")
                {
                    int number = int.Parse(command[1]);

                    listOfNum.Add(number);
                }
                else if (command[0] == "insert")
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    if (index < listOfNum.Count && index >= 0)
                    {
                        listOfNum.Insert(index, number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command[0] == "remove")
                {
                    int index = int.Parse(command[1]);
                    if (index < listOfNum.Count && index >= 0)
                    {
                        listOfNum.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command[0] == "shift")
                {
                    int count = int.Parse(command[2]);
                    if (command[1] == "left")
                    {
                        ShiftLeft(listOfNum, count);
                    }
                    else if (command[1] == "right")
                    {
                        ShiftRight(listOfNum, count);
                    }
                }

                command = Console.ReadLine().ToLower().Split().ToArray();
            }
            Console.WriteLine(String.Join(" ", listOfNum));
        }

        private static void ShiftRight(List<int> listOfNum, int count)
        {
            for (int i = 0; i < count; i++)
            {
                listOfNum.Insert(0, listOfNum[listOfNum.Count-1]);
                listOfNum.RemoveAt(listOfNum.Count - 1);
            }
        }

        private static void ShiftLeft(List<int> listOfNum, int count)
        {
            for (int i = 0; i < count; i++)
            {
                listOfNum.Add(listOfNum[0]);
                listOfNum.RemoveAt(0);
            }
        }
    }
}

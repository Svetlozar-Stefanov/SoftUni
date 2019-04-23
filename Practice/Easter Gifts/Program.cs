using System;
using System.Collections.Generic;
using System.Linq;

namespace Easter_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfGifts = Console.ReadLine().Split().ToList();

            string command = Console.ReadLine();
            while (command != "No Money")
            {
                string[] actions = command.Split();
                if (actions[0] == "OutOfStock")
                {
                    string gift = actions[1];
                    for (int i = 0; i < listOfGifts.Count; i++)
                    {
                        if (listOfGifts[i] == gift)
                        {
                            listOfGifts[i] = "None";
                        }
                    }
                }
                else if (actions[0] == "Required")
                {
                    string gift = actions[1];
                    int index = int.Parse(actions[2]);

                    if (index >= 0 && index < listOfGifts.Count)
                    {
                        listOfGifts[index] = gift;
                    }
                }
                else if (actions[0] == "JustInCase")
                {
                    string gift = actions[1];

                    listOfGifts[listOfGifts.Count - 1] = gift;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", listOfGifts.Where(x => x != "None")));
        }
    }
}

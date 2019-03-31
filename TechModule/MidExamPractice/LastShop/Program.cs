using System;
using System.Collections.Generic;
using System.Linq;

namespace LastShop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> paintings = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();
            while (command[0] != "END")
            {
                if (command[0] == "Change")
                {
                    int paintingNumber = int.Parse(command[1]);
                    if (paintings.Contains(paintingNumber))
                    {
                        int changeNumber = int.Parse(command[2]);
                        int index = paintings.IndexOf(paintingNumber);
                        paintings[index] = changeNumber;
                    }
                }
                else if (command[0] == "Hide")
                {
                    int paintingNumber = int.Parse(command[1]);

                    if (paintings.Contains(paintingNumber))
                    {
                        paintings.Remove(paintingNumber);
                    }
                }
                else if (command[0] == "Switch")
                {
                    int paintingNumber1 = int.Parse(command[1]);
                    int paintingNumber2 = int.Parse(command[2]);
                    if (paintings.Contains(paintingNumber1) && paintings.Contains(paintingNumber2))
                    {
                        int index1 = paintings.IndexOf(paintingNumber1);
                        int index2 = paintings.IndexOf(paintingNumber2);

                        paintings[index1] = paintingNumber2;
                        paintings[index2] = paintingNumber1;
                    }
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[1]) + 1;
                    int number = int.Parse(command[2]);

                    if (index >= 0 && index <= paintings.Count)
                    {
                        paintings.Insert(index, number);
                    }
                }
                else if (command[0] == "Reverse")
                {
                    paintings.Reverse();
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(String.Join(" ", paintings));
        }
    }
}

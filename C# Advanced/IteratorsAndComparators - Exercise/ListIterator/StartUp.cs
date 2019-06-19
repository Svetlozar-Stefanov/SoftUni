using System;
using System.Collections.Generic;
using System.Linq;

namespace ListIterator
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> info = input.
                    Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();


            info.RemoveAt(0);
            ListyIterator<string> listyIterator = new ListyIterator<string>(info);

            input = Console.ReadLine();
            while (input.ToLower() != "end")
            {
                if (input.ToLower() == "move")
                {
                    Console.WriteLine(listyIterator.Move());
                }
                if (input.ToLower() == "print")
                {
                    listyIterator.Print();
                }
                if (input.ToLower() == "hasnext")
                {
                    Console.WriteLine(listyIterator.HasIndex());
                }
                if (input.ToLower() == "printall")
                {
                    foreach (var element in listyIterator)
                    {
                        Console.Write(element + " ");
                    }
                    Console.WriteLine();
                }

                input = Console.ReadLine();
            }
        }
    }
}

using Collection_Hierarchy.Collections;
using System;

namespace Collection_Hirearhy
{
    public static class Engine
    {
        private static AddCollection<string> addCollection = new AddCollection<string>();

        private static AddRemoveCollection<string> addRemoveCollection = new AddRemoveCollection<string>();

        private static MyList<string> myList = new MyList<string>();

        public static void Run()
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            PrintAddOperations(input);

            int removeOptions = int.Parse(Console.ReadLine());
            PrintRemove(removeOptions);
        }

        private static void PrintRemove(int removeOptions)
        {
            for (int i = 0; i < removeOptions; i++)
            {
                Console.Write(addRemoveCollection.Remove() + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < removeOptions; i++)
            {
                Console.Write(myList.Remove() + " ");
            }
            Console.WriteLine();
        }

        private static void PrintAddOperations(string[] input)
        {
            foreach (var line in input)
            {
                Console.Write(addCollection.Add(line) + " ");
            }
            Console.WriteLine();
            foreach (var line in input)
            {
                Console.Write(addRemoveCollection.Add(line) + " ");
            }
            Console.WriteLine();
            foreach (var line in input)
            {
                Console.Write(myList.Add(line) + " ");
            }
            Console.WriteLine();
        }
    }
}

namespace UniqueNames
{
    using System;
    using System.Collections.Generic;

    public class Unique
    {
        public static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string name = Console.ReadLine();

                names.Add(name);
            }

            Console.WriteLine(String.Join("\n",names));
        }
    }
}

namespace UniqueUsernames
{
    using System;
    using System.Collections.Generic;

    public class Usernames
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> usernames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();

                usernames.Add(name);
            }

            Console.WriteLine(String.Join("\n",usernames));
        }
    }
}

using System;

namespace OldestFamilyMember
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Family family = new Family();
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                family.AddMember(new Person(input[0], int.Parse(input[1])));
            }

            Person elder = family.GetOldestMember();
            Console.WriteLine($"{elder.Name} {elder.Age}");
        }
    }
}

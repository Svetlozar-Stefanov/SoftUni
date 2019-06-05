namespace TriFunction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Function
    {
        public static void Main(string[] args)
        {
            int desiredSum = int.Parse(Console.ReadLine());
            List<string> people = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            FindPerson(people, Checker,desiredSum);
        }

        public static void FindPerson(List<string> people, Func<string, int, bool> isPass, int desiredSum)
        {
            foreach (var person in people)
            {
                if (isPass(person,desiredSum))
                {
                    Console.WriteLine(person);
                    return;
                }
            }
        }

        public static Func<string, int, bool> Checker = (person, searchedSum) =>
        {
            int sum = 0;
            foreach (var letter in person)
            {
                sum += letter;
            }
            if (sum >= searchedSum)
            {
                return true;
            }
            return false;
        };
    }
}

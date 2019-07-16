using ExplicitInterfaces.Interfaces;
using System;

namespace ExplicitInterfaces
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();

            while (input[0].ToLower() != "end")
            {
                string name = input[0];
                string country = input[1];
                int age = int.Parse(input[2]);

                Person person = new Person(name, country, age);

                ICitizen citizen = person as ICitizen;
                Console.WriteLine(citizen.GetName());

                IResident resident = person as IResident;
                Console.WriteLine(resident.GetName());

                input = Console.ReadLine()
                .Split();
            }
        }
    }
}

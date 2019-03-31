using System;
using System.Collections.Generic;
using System.Linq;

namespace SortByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonInfo> listPeople = new List<PersonInfo>();

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0].ToLower() != "end")
            {
                string name = input[0];
                string id = input[1];
                int age = int.Parse(input[2]);

                listPeople.Add(new PersonInfo(name, id, age));

                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            listPeople = listPeople.OrderBy(x => x.Age).ToList();

            foreach (var person in listPeople)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }

    class PersonInfo
    {
        public PersonInfo(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name;
        public string ID;
        public int Age;

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}

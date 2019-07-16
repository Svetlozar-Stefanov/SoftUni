using ExplicitInterfaces.Interfaces;

namespace ExplicitInterfaces
{
    public class Person : ICitizen, IResident
    {
        public Person(string name, string country, int age)
        {
            Name = name;
            Country = country;
            Age = age;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Country { get; private set; }

        string ICitizen.GetName()
        {
            return Name;
        }

        string IResident.GetName()
        {
            return "Mr/Ms/Mrs " + Name;
        }
    }
}

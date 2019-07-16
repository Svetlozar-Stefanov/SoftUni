using MilitaryElite.Interfaces;

namespace MilitaryElite.Soldiers
{
    public abstract class Soldier : ISoldier
    {

        public Soldier(string id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public string Id { get; protected set; }

        public string FirstName { get; protected set; }

        public string LastName { get; protected set; }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Id: {Id}";
        }
    }
}

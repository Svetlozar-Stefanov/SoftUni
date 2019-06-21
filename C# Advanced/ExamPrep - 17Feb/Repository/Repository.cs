using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class Repository
    {
        public Dictionary<int, Person> people { get;set };
        private int Id = 0;

        public int Count
        {
            get
            {
                return people.Count;
            }
        }
        public Repository()
        {
            people = new Dictionary<int, Person>();
        }

        public void Add(Person person)
        {
            people.Add(Id, person);
            Id++;
        }

        public Person Get(int id)
        {
            return people[id];
        }

        public bool Update(int id, Person newPerson)
        {
            if (people.ContainsKey(id))
            {
                people[id] = newPerson;
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            if (people.ContainsKey(id))
            {
                people.Remove(id);
                return true;
            }
            return false;
        }
    }
}

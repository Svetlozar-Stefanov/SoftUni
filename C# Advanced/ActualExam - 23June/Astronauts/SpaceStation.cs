using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStationRecruitment
{
    public class SpaceStation
    {
        private List<Astronaut> astronauts;

        public SpaceStation(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            astronauts = new List<Astronaut>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count
        {
            get
            {
                return astronauts.Count;
            }
        }


        public void Add(Astronaut astronaut)
        {
            if (Count < Capacity)
            {
                astronauts.Add(astronaut);
            }
        }

        public bool Remove(string name)
        {
            Astronaut astronautToRemove = astronauts.FirstOrDefault(a => a.Name == name);
            return astronauts.Remove(astronautToRemove);
        }

        public Astronaut GetOldestAstronaut()
        {
            return astronauts.OrderByDescending(a => a.Age).FirstOrDefault();
        }

        public Astronaut GetAstronaut(string name)
        {
            return astronauts.FirstOrDefault(a => a.Name == name);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Astronauts working at Space Station {Name}:");
            foreach (var astronaut in astronauts)
            {
                sb.AppendLine(astronaut.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}

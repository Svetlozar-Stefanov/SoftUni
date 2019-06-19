using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        private List<Hero> heroes;
        public int Count
        {
            get
            {
               return heroes.Count;
            }
        }
        public HeroRepository()
        {
            heroes = new List<Hero>();
        }

        public void Add(Hero hero)
        {
            heroes.Add(hero);
        }

        public void Remove(string name)
        {
            Hero hero = heroes.Where(h => h.Name == name).FirstOrDefault();

            if (hero != null)
            {
                heroes.Remove(hero);
            }
        }

        public Hero GetHeroWithHighestStrength()
        {
            return heroes.OrderByDescending(h => h.Item.Strength).FirstOrDefault();
        }

        public Hero GetHeroWithHighestAbility()
        {
            return heroes.OrderByDescending(h => h.Item.Ability).FirstOrDefault();
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            return heroes.OrderByDescending(h => h.Item.Intelligence).FirstOrDefault();
        }

        public override string ToString()
        {
            return string.Join("\n", heroes);
        }
    }
}

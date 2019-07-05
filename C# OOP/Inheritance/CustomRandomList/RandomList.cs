namespace CustomRandomList
{
    using System;
    using System.Collections.Generic;
    public class RandomList : List<string>
    {
        private Random random;

        public RandomList()
        {
            random = new Random();
        }

        public string RandomString()
        {
            int index = random.Next(0, Count);
            string element = base[index];
            Remove(element);
            return element;
        }
    }
}

using ValidationAttributes.Attributes;

namespace ValidationAttributes.Models
{
    public class Person
    {
        private const int min = 12;
        private const int max = 90;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        [MyRequired]
        public string Name { get; set; }

        [MyRange(min,max)]
        public int Age { get; set; }
    }
}

namespace Person
{ 
    public class Person
    {
        private string name;
        private int age;

        public Person(string name)
        {
            Name = name;
        }
        public Person(string name, int age)
            :this(name)
        {
            Age = age;
        }
        public string Name
        {
            get
            {
                return name;
            }
            protected set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            protected set
            {
                if (value >= 0)
                {
                    age = value;
                }
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";

        }
    }
}

namespace Person
{
    public class Child : Person
    {
        public Child(string name, int age)
            :base(name)
        {
            if (age <= 15)
            {
                Age = age;
            }
        }
    }
}

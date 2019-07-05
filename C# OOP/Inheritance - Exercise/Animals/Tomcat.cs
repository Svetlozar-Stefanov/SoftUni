namespace Animals
{
    public class Tomcat : Cat
    {
        const string gender = "Male";
        public Tomcat(string name, int age)
            : base(name, age, gender)
        {

        }
        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}

using WildFarm.Models.AbstractClasses;

namespace WildFarm.Models.Mammals
{
    public class Dog : Mammal
    {
        protected override double WeightGain => 0.40;
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override string MakeSound()
        {
            return "Woof!";
        }
    }
}

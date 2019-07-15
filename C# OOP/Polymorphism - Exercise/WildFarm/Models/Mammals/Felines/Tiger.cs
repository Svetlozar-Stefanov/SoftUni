using WildFarm.Models.AbstractClasses;

namespace WildFarm.Models.Mammals.Felines
{
    public class Tiger : Feline
    {
        protected override double WeightGain => 1.00;

        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override string MakeSound()
        {
            return "ROAR!!!";
        }
    }
}

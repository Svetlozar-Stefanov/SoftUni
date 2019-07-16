using BorderControl.Interfaces;

namespace BorderControl.CityInhabitants
{
    public class Robot : IIdentifiable
    {
        public Robot(string model,string id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get; private set; }

        public string Id { get; private set; }

        public bool CheckId(string lastDigit)
        {
            if (Id.EndsWith(lastDigit))
            {
                return true;
            }
            return false;
        }
    }
}

using System;

namespace Ferrari
{
    public class Ferrari : ICar
    {
        private const string defaultModel = "488-Spider";

        public Ferrari(string driver)
        {
            Model = defaultModel;
            Driver = driver;
        }
        public string Model { get; set; }
        public string Driver { get; set; }

        public string Brakes()
        {
            return "Brakes!";
        }

        public string Gas()
        {
            return "Gas!";
        }

        public override string ToString()
        {
            return $"{Model}/{Brakes()}/{Gas()}/{Driver}";
        }
    }
}

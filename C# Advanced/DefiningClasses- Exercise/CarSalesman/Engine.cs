using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        public string Model { get; set; }
        public int Power { get; set; }
        public string Displacement { get; set; }
        public  string Efficiency { get; set; }

        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
            Displacement = "n/a";
            Efficiency = "n/a";
        }

        public Engine(string model,int power, string addOn):this(model,power)
        {
            if (int.TryParse(addOn ,out int displacement))
            {
                Displacement = addOn;
            }
            else
            {
                Efficiency = addOn;
            }
        }
        public Engine(string model, int power, string displacement, string efficiency):this(model,power)
        {
            Displacement = displacement;
            Efficiency = efficiency;
        }
    }
}

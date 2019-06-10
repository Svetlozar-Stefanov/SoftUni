using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }

        public string Weight { get; set; }
        public string Color { get; set; }

        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
            Weight = "n/a";
            Color = "n/a";
        }
        public Car(string model, Engine engine, string addOn):this(model,engine)
        {
            if (int.TryParse(addOn, out int num))
            {
                Weight = addOn;
            }
            else
            {
                Color = addOn;
            }
        }
        public Car(string model, Engine engine, string weight, string color):this(model,engine)
        {
            Weight = weight;
            Color = color;
        }
    }
}

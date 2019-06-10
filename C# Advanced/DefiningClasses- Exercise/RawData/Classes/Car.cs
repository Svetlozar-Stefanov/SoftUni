using System;
using System.Collections.Generic;
using System.Text;

namespace RawData.Classes
{
    public class Car
    {
        public string Model { get; set; }

        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public List<Tire> Tires { get; set; }

        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tires = tires;
        }
    }
}

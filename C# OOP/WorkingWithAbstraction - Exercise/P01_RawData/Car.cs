using System;
using System.Collections.Generic;
using System.Text;

namespace P01_RawData
{
    public class Car
    {
        public Car(string model, int engineSpeed, int enginePower, Cargo cargo)
        {
            Model = model;
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
            Cargo = cargo;
            Tires = new List<Tire>(4);

        }
        public string Model { get; set; }
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
        public Cargo Cargo { get; set; }
        public List<Tire> Tires { get; set; }
    }
}

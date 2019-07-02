using System;
using System.Collections.Generic;
using System.Text;

namespace P01_RawData
{
    public class Cargo
    {
        public Cargo(int cargoWeight, string cargoType)
        {
            Weight = cargoWeight;
            Type = cargoType;
        }
        public int Weight { get; set; }
        public string Type { get; set; }


    }
}

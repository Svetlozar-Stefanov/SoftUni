using System;
using System.Collections.Generic;
using System.Text;

namespace RawData.Classes
{
    public class Tire
    {
        public double TirePressure { get; set; }
        public int TireAge { get; set; }

        public Tire(double tirePressure, int tireAge)
        {
            TirePressure = tirePressure;
            TireAge = tireAge;  
        }
    }
}

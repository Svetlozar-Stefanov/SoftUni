using System;
using System.Collections.Generic;
using System.Text;

namespace P02_CarsSalesman
{
    public class Engine
    {
        private const string offset = "  ";

        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }
        public Engine(string model, int power, int displacement = -1, string efficiency = "n/a")
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}{1}:\n", offset, Model);
            sb.AppendFormat("{0}{0}Power: {1}\n", offset, Power);
            sb.AppendFormat("{0}{0}Displacement: {1}\n", offset, Displacement == -1 ? "n/a" : Displacement.ToString());
            sb.AppendFormat("{0}{0}Efficiency: {1}\n", offset, Efficiency);

            return sb.ToString();
        }
    }

}

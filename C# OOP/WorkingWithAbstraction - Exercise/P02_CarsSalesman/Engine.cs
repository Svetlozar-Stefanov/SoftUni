using System;
using System.Collections.Generic;
using System.Text;

namespace P02_CarsSalesman
{
    public class Engine
    {
        private const string offset = "  ";

        public Engine(string model, int power, int displacement = -1, string efficiency = "n/a")
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{offset}{Model}:");
            sb.AppendLine($"{offset}{offset}Power: {Power}");
            sb.AppendLine($"{offset}{offset}Displacement: {(Displacement == -1 ? "n/a" : Displacement.ToString())}");
            sb.AppendLine($"{offset}{offset}Efficiency: {Efficiency}");

            return sb.ToString().TrimEnd();
        }
    }

}

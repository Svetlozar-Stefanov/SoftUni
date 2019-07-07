using System;
using System.Collections.Generic;
using System.Text;

namespace P02_CarsSalesman
{
    public class Car
    {
        private const string offset = "  ";

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        public Car(string model, Engine engine, int weight = -1, string color = "n/a")
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Model}:");
            sb.AppendLine(Engine.ToString());
            sb.AppendLine($"{offset}Weight: {(Weight == -1 ? "n/a" : Weight.ToString())}");
            sb.AppendLine($"{offset}Color: {Color}");

            return sb.ToString().TrimEnd();
        }
    }
}

using System;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        private const double PI = Math.PI;

        private double radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get
            {
                return radius;
            }
            private set
            {
                Validator.CheckSide(value);
                radius = value;
            }
        }

        public override double CalculateArea()
        {
            return PI * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * PI * Radius;
        }

        public override string Draw()
        {
            StringBuilder sb = new StringBuilder();

            double rIn = Radius - 0.4;
            double rOut = Radius + 0.4;

            for (double y = Radius; y >= -Radius; --y)
            {
                for (double x = -Radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;

                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        sb.Append("*");
                    }
                    else
                    {
                        sb.Append(" ");
                    }
                }
                sb.AppendLine(" ");
            }

            return base.Draw() + sb.ToString();
        }
    }
}

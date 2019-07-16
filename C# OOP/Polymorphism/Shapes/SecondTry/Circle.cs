using System;
using System.Text;

namespace Shapes.SecondTry
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            Validator.CheckSide(radius);
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override string Draw()
        {
            StringBuilder sb = new StringBuilder();

            double rIn = radius - 0.4;
            double rOut = radius + 0.4;

            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < rOut; x += 0.5)
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

            return sb.ToString();
        }
    }
}

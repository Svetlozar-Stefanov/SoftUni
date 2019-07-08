using System;
using System.Text;

namespace BoxData
{
    public class Box
    {
        private double length;

        private double width;

        private double height;

        public Box(double length, double width, double height)
        {
            SetLength(length);
            SetWidth(width);
            SetHeight(height);
        }

        public double GetVolume()
        {
            return length * width * height;
        }

        public double GetLateralSurfaceArea()
        {
            return (2 * length * height) + (2 * width * height);
        }

        public double GetSurfaceArea()
        {
            return (2 * length * width) + (2 * length * height) + (2 * width * height);
        }


        private void SetLength(double value)
        {
            Validator.CheckLength(value);
            length = value;
        }
        private void SetWidth(double value)
        {
            Validator.CheckWidth(value);
            width = value;
        }
        private void SetHeight(double value)
        {
            Validator.CheckHeight(value);
            height = value;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {GetSurfaceArea():f2}");
            sb.AppendLine($"Lateral Surface Area - {GetLateralSurfaceArea():f2}");
            sb.AppendLine($"Volume - {GetVolume():f2}");

            return sb.ToString().TrimEnd();
        }
    }
}

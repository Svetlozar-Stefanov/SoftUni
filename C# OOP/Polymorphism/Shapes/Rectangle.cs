using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Height
        {
            get
            {
                return height;
            }
            private set
            {
                Validator.CheckSide(value);
                height = value;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            private set
            {
                Validator.CheckSide(value);
                width = value;
            }
        }

        public override double CalculatePerimeter()
        {
            return Height * 2 + Width * 2;
        }

        public override double CalculateArea()
        {
            return Height * Width;
        }

        public override string Draw()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(DrawLine('*', '*'));
            for (int i = 0; i < Width - 2; i++)
            {
                sb.AppendLine(DrawLine('*', ' '));
            }
            sb.AppendLine(DrawLine('*', '*'));

            return base.Draw() + sb.ToString();
        }

        private string DrawLine(char c1, char c2)
        {
            return c1 + (new string(c2,(int)Width - 2)) + c1;
        }
    }
}

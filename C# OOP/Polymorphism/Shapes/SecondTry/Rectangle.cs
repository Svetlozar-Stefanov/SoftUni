using System.Text;

namespace Shapes.SecondTry
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

        public override double CalculateArea()
        {
            return Height * Width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Height + Width);
        }

        public override string Draw()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine('*' + (new string('*', (int)Width - 2)) + '*');
            for (int i = 0; i < Width - 2; i++)
            {
                sb.AppendLine('*' + (new string(' ', (int)Width - 2)) + '*');
            }
            sb.AppendLine('*' + (new string('*', (int)Width - 2)) + '*');

            return sb.ToString().TrimEnd();
        }
    }
}

using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            Validator.CheckSide(height);
            this.height = height;

            Validator.CheckSide(width);
            this.width = width;
        }

        public override double CalculatePerimeter()
        {
            return  height * 2 + width * 2;
        }

        public override double CalculateArea()
        {
            return height * width;
        }

        public override string Draw()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine('*' + (new string('*', (int)width - 2)) + '*');
            for (int i = 0; i < width - 2; i++)
            {
                sb.AppendLine('*' + (new string(' ', (int)width - 2)) + '*');
            }
            sb.AppendLine('*' + (new string('*', (int)width - 2)) + '*');

            return sb.ToString();
        }
    }
}

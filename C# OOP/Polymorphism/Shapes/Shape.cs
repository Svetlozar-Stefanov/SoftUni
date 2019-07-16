namespace Shapes
{
    public abstract class Shape : IShape
    {
        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();

        public virtual string Draw()
        {
            return "";
        }
    }
}

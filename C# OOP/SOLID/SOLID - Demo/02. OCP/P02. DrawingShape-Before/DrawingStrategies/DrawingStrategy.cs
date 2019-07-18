using P02._DrawingShape_Before.Contracts;

namespace P02._DrawingShape_Before.DrawingStrategies
{
    public abstract class DrawingStrategy
    {
        public abstract void Draw();

        public abstract bool IsMatch(IShape shape);
    }
}

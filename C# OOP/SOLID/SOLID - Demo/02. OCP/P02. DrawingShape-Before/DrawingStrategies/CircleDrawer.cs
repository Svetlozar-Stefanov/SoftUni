using P02._DrawingShape_Before.Contracts;

namespace P02._DrawingShape_Before.DrawingStrategies
{
    public class CircleDrawer : DrawingStrategy
    {
        public override void Draw()
        {
            System.Console.WriteLine("Circle");
        }

        public override bool IsMatch(IShape shape)
        {
            return shape is Circle;
        }
    }
}

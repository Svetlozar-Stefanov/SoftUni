using P02._DrawingShape_Before.Contracts;

namespace P02._DrawingShape_Before.DrawingStrategies
{
    public class RectangleDrawer : DrawingStrategy
    {
        public override void Draw()
        {
            System.Console.WriteLine("I drew a rectangle");
        }

        public override bool IsMatch(IShape shape)
        {
            return shape is Rectangle;
        }
    }
}

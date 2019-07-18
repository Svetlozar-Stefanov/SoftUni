namespace P02._DrawingShape_Before
{
    using Contracts;
    using P02._DrawingShape_Before.DrawingStrategies;
    using System.Collections.Generic;
    using System.Linq;

    class DrawingManager : IDrawingManager
    {
        private List<DrawingStrategy> drawingStrategies = new List<DrawingStrategy>
        {
            new RectangleDrawer(),
            new CircleDrawer()
        };

        public void Draw(IShape shape)
        {
            DrawingStrategy drawingStrategy = drawingStrategies.FirstOrDefault(s => s.IsMatch(shape));

            drawingStrategy.Draw();
        }
    }
}

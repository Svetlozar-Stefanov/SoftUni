using P02.Graphic_Editor.Contracts;
using P02.Graphic_Editor.Strategy;
using System.Collections.Generic;
using System.Linq;

namespace P02.Graphic_Editor
{
    public class GraphicEditor
    {
        private List<IDrawingStrategy> strategies = new List<IDrawingStrategy>
        {
            new RectangleDrawer(),
            new SquareDrawer(),
            new CircleDrawer()
        };

        public void DrawShape(IShape shape)
        {
            IDrawingStrategy drawingStrategy = strategies
                .FirstOrDefault(s => s.IsMatch(shape));

            drawingStrategy.Draw();
        }
    }
}

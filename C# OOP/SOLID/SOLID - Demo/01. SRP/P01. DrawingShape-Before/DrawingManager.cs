namespace P01._DrawingShape_Before
{
    using Contracts;

    public class DrawingManager : IDrawingManager
    {
        private readonly IDrawingContext drawingContext;
        private readonly IRenderer renderer;
        private readonly IShape shape;

        public DrawingManager(IDrawingContext drawingContext, IRenderer renderer, IShape shape)
        {
            this.drawingContext = drawingContext;
            this.renderer = renderer;
            this.shape = shape;
        }

        public void Draw()
        {
            renderer.Render(drawingContext, shape);
        }
    }
}

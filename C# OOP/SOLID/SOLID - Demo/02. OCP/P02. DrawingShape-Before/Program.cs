using System;

namespace P02._DrawingShape_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawingManager drawingManager = new DrawingManager();

            drawingManager.Draw(new Rectangle());
        }
    }
}

namespace SimpleSnake.GameObjects
{
    public class Wall : Point
    {
        private const char wallSymbol = '\u25A0';

        public Wall(int leftX, int topY) 
            : base(leftX, topY)
        {
            InitializeWallBorders();
        }

        private void SetHorizontalLine(int topY)
        {
            for (int leftX = 0; leftX < LeftX; leftX++)
            {
                Draw(leftX, topY, wallSymbol);
            }
        }

        private void SetVerticalLine(int leftX)
        {
            for (int topY = 0; topY < TopY; topY++)
            {
                Draw(leftX, topY, wallSymbol);
            }
        }

        private void InitializeWallBorders()
        {
            SetHorizontalLine(0);
            SetHorizontalLine(TopY);

            SetVerticalLine(0);
            SetVerticalLine(LeftX - 1);
        }

        public bool IsPointInWall(Point point)
        {
            return point.LeftX == 0 || point.LeftX == LeftX - 1
                || point.TopY == 0 || point.TopY == TopY;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PointInRectangle
{
    public class Rectangle
    {
        public Rectangle(Point topLeft, Point bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }

        public bool Contains(Point point)
        {
            bool isInX = point.X >= TopLeft.X
                && point.X <= BottomRight.X;

            bool isInY = point.Y >= TopLeft.Y
                && point.Y <= BottomRight.Y;

            return isInX && isInY;
        }
    }
}

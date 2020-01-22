using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Rectangle
{
    public Point TopLeft;
    public Point BottomRight;

    public Rectangle(int topX, int topY, int bottomX, int bottomY)
    {
        TopLeft = new Point(topX, topY);
        BottomRight = new Point(bottomX, bottomY);
    }

    public bool Contains(Point point)
    {
        var contains = point.X >= TopLeft.X && point.X <= BottomRight.X && point.Y >= TopLeft.Y && point.Y <= BottomRight.Y;
        return contains;
    }
}


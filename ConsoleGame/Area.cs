using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleGame
{
    public class Area : Point
    {
        public Area(int _x, int _y) : base(_x, _y) { }

        public bool IsInsideArea(Point point)
        {
            return IsInsideArea(point.x, point.y);
        }
        public bool IsInsideArea(int _x, int _y)
        {
            if (_x < 0 || _y < 0) return false;
            if (_x >= x || _y >= y) return false;

            return true;
        }
    }
}

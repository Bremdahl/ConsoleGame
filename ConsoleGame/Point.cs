using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleGame
{
    public class Point
    {
        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public int x { get; set; }
        public int y { get; set; }


        public override bool Equals(object obj)
        {
            if (GetType() != obj.GetType()) return false;

            return Equals((obj as Point));
        }
        public static bool operator ==(Point a, Point b)
        {
            return a.x.Equals(b.x) && a.y.Equals(b.y);
        }

        public static bool operator !=(Point a, Point b)
        {
            return !(a == b);
        }

        public Point Copy()
        {
            return new Point(x, y);
        }
    }
}

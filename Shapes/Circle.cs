using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Point, ILength, ISquare
    {
        public int R { get; }
        public Circle(int x, int y, int r) : base(x, y)
        {
            R = r;
        }
        public Circle(Point point, int r) : this(point.X, point.Y, r)
        {
        }

        public double Length
        {
            get
            {
                return 2 * Math.PI * R;
            }
        }
        public double Square
        {
            get
            {
                return Math.PI * R * R;
            }
        }
    }
}

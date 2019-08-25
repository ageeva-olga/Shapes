using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle: ILength
    {
        public Line LineAB { get; }
        public Line LineBC { get; }
        public Line LineCA { get; }
        public Triangle(Point a, Point b, Point c)
        {
            LineAB = new Line(a, b);
            LineBC = new Line(b, c);
            LineCA = new Line(c, a);
        }
        public Triangle(Line ab, Line bc, Line ca)
        {
            LineAB = ab;
            LineBC = bc;
            LineCA = ca;
        }
        public double Length { get
            {
                return LineAB.Length + LineBC.Length + LineCA.Length;
            } }
        public double Square
        {
            get
            {
                return Math.Sqrt((Length/2) 
                              * ((Length / 2)-LineAB.Length) 
                              * ((Length / 2) - LineBC.Length) 
                              * ((Length / 2) - LineCA.Length));
            }
        }
    }
}

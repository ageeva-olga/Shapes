using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Line : ILength
    {
        public Point StartPoint { get; }
        public Point EndPoint { get; }
        public Line(Point point1, Point point2)
        {
            StartPoint = point1;
            EndPoint = point2;
        }
        public virtual double Length
        {
            get
            {
                return Math.Sqrt(Math.Pow((EndPoint.X - StartPoint.X), 2)
                                 + Math.Pow((EndPoint.Y - StartPoint.Y), 2));
            }
        }
    }
} 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Qadrat : Line, ILength, ISquare
    {
        public Qadrat(Line line) : base(line.StartPoint, line.EndPoint)
        {
        }
        public override double Length
        {
            get
            {
                return (base.Length)*4;
            }
        }

        public double Square
        {
            get
            {
                return (Length/4) * (Length/4);
            }
        }
    }
}

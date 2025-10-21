using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Square : Rectangle
    {
        private double side;
        public double Side
        {
            get { return side; }
            set
            {
                side = value;
                if (side < 0)
                    throw new ArgumentOutOfRangeException("value must be positive");
            }
        }
        public Square(string color, double side) : base(color, side, side)
        {
            this.color = color;
            this.side = side;
        }
    }
}
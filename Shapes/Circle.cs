using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle : Shape
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("value must be positve");
                radius = value;
            }
        }
        public Circle(double radius, string color) : base(color)
        {
            this.Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
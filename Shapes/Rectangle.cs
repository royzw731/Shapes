using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle : Shape
    {
        private double height, width;
        public double Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("value must be positive");
                height = value;
            }
        }
        public double Width
        {
            get { return width; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("value must be positive");
                width = value;
            }
        }
        public Rectangle(string color, double height, double width) : base(color)
        {
            this.height = height;
            this.width = width;
        }
        public override double Area()
        {
            return height * width;
        }
        public override double Perimeter()
        {
            return (2 * height + 2 * width);
        }



    }
}
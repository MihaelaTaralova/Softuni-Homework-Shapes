using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape, IShape
    {
        public Rectangle(double height, double width) : base(height, width)
        {
            Height = height;
            Width = width;
        }

        public override double CalculateArea()
        {
            return this.Height * this.Width;
        }

        public override double CalculatePerimeter()
        {
            return this.Height + this.Height + this.Width + this.Width;
        }
        public override string Draw()
        {
            return base.Draw() + " I am rectangle"; 
        }
    }
}

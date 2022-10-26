using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape, IShape
    {
        public Circle(double width) : base(width, width)
        {
           
        }

        
        public override double CalculateArea()
        {
            return Math.PI * Width * Width;
        }

        public override double CalculatePerimeter()
        {
            return Math.PI * Width * 2;
        }
        public override string Draw()
        {
            return base.Draw() + " I am circle";
        }
    }
}

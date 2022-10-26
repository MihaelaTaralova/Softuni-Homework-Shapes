using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public abstract class Shape : IShape
    {
        private double height;
        private double width;

        protected Shape(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Height 
        { 
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }
        public double  Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }
        public abstract double CalculatePerimeter();
      
        public abstract double CalculateArea();

        public virtual string Draw()
        {
            return "Draw";
        }
    }
}

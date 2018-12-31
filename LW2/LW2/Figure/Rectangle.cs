using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW2
{

    class Rectangle : GeometryFigure
    {
        public Rectangle(double width,double length)
        {
            this.width = width;
            this.length = length;
        }
        public double width { get; set; }
        public double length { get; set; }

        public override double Area()
        {
            return  length * width;
        }
        public override string ToString()
        {
            return "Прямоугольник с длиной " + width + ", шириной " + length + " и площадью " + Area();
        }
}

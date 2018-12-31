using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW2
{
    
    class Circle : GeometryFigure
    {
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double radius { get; set; }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }
        public override string ToString()
        {
            return "Круг с радиусом " + radius +" и площадью " + Area();
        }
    }
}       

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW2
{
     abstract class GeometryFigure: IPrint
    {
        public abstract double Area();

        public string Print()
        {
            return ToString();
        }
    }
}

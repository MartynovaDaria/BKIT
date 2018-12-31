using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW2
{
  class Square : Rectangle
  {
      public Square(double width): base(width, width){}
      public override string ToString()
      {
          return "Квадрат со стороной " + width + " и площадью " + Area();
      }
  }
}

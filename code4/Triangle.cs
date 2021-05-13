using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code4
{
    class Triangle: Measure
    {
        public double area()
        {
            double a = 0.5 * basee * height;
            return a;
        }
    }
}

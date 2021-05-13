using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code4
{
    class Measure
    {
       
        public double heightof()
        {
            
            Console.WriteLine("enter the height ");
            String str2 = Console.ReadLine();
            height = Convert.ToDouble(str2);
            return height;
        }
        public double baseof()
        {
            Console.WriteLine("enter the base ");
            String str1 = Console.ReadLine();
            basee = Convert.ToDouble(str1);
            return basee;
        }
        public double height, basee;
    }
}

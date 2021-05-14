using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of sides");
            string a = Console.ReadLine();
            int s = Convert.ToInt32(a);
            
            if (s==3)
            {
                
                Triangle t = new Triangle();
                t.heightof();
                t.baseof(); 
                double x = t.area();
                Console.WriteLine("the area is " + x);
                Console.ReadLine();
                
            }
            else if(s==4)
            {
                
                Qudrangle q = new Qudrangle();
                q.heightof();
                q.baseof();
                double y = q.qudra();
                Console.WriteLine("the area is " + y);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("the area is not available");
                Console.ReadLine(); 
            }
        }
    }
}

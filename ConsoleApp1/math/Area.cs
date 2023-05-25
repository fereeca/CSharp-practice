using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.math
{
    internal class Area
    {
        public void AreaOfCircle()
        {
            Console.WriteLine("enter radius=");
            int r = Convert.ToInt32(Console.ReadLine());
            double a = 3.14 * r *r;
            Console.WriteLine("area of circle=" + a);

        }
    }
}

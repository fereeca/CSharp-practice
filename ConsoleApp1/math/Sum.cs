using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.math
{
    internal class Sum
    {
        public void Addition()
        {

            Console.WriteLine("enter first number=");
           int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("eneter second number=");
            int b =Convert.ToInt32(Console.ReadLine());
            int s = a + b;
            Console.WriteLine("sum of two no. is=" + s);


        }
    }
}

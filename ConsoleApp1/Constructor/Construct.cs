using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Constructor
{
    internal class Construct
    {
        int n = 0;
        int b, c;
        public Construct()
        {
            n = 5;

        }

        public void Defcon()
        {
            Console.WriteLine(n);
        }

        public Construct(int a, int d)
        {
            b = a;
            c = d;
        }

        public void Sum()
        {
            int s = b + c;
            Console.WriteLine(s);
        }
    }
}

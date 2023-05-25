using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.loop
{
    internal class Ifloops
    {
        public void Ifloop()
        {
            Console.WriteLine("enter your age=");
            int a= Convert.ToInt32(Console.ReadLine());
            if (a > 18)
            {
                Console.WriteLine("you are eligible to vote");
                
            }
            else
            {
                Console.WriteLine("you are not eligible to vote");
            }
        }
    }
}

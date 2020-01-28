using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample4_Sum
{
    class Sample4_Sum
    {
        static void Main(string[] args)
        {
            double fn, sn;
            Console.Write("enter the numbers to be added.\n\n\n");
            Console.Write("\nEnter the first number: ");
            fn = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nEnter the second number: ");
            sn = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nThe sum is: {0} ", (fn + sn));
            Console.ReadKey();
        }
    }
}

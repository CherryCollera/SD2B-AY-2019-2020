using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample5_BasicOperations
{
    class Sample5_BasicOperations
    {
        static void Main(string[] args)
        {
            int fn, sn, sum, dif, pro, mod;
            double quot;
            Console.Write("Basic Operations.\n\n\n");
            Console.Write("\nEnter the first number: ");
            fn = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the second number: ");
            sn = Convert.ToInt32(Console.ReadLine());
            sum = fn + sn;
            Console.Write("\nThe sum is: " + sum);
            dif = fn - sn;
            Console.Write("\nThe difference is: " + dif);
            pro = fn * sn;
            Console.Write("\nThe product is: " + pro);
            quot = fn / sn;
            Console.Write("\nThe quotient is: " + quot);
            mod = fn % sn;
            Console.Write("\nThe remainder is: " + mod);
            Console.ReadKey();
        }
    }
}

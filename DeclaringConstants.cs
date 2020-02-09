using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringConstants
{
    class DeclaringConstants
    {
        static void Main(string[] args)
        {
            int radius;
            double AreaCircle;
            const double pi = 3.14159;
            Console.Write("Enter Radius: ");
            radius = Convert.ToInt32(Console.ReadLine());
            AreaCircle = pi * radius * radius;
            Console.Write("Radius : " + radius + ", " + "Area: " + AreaCircle);
            Console.ReadKey();
        }
    }
}

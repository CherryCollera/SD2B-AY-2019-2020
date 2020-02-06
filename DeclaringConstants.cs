using System;

namespace DeclaringConstants
{
    class DeclaringConstants
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            int AreaCircle;
            double Radius;
           Console.Write("Enter Radius: ");
            Radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nRadius: " + Radius + "\nArea: = {0}"  , pi  * Radius * Radius);
            Console.ReadLine();

        }
    }
}
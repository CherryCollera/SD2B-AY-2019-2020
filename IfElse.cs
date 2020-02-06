using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
                Console.Write(num1 + " is Greater than " + num2);
           else if (num2 > num1)
                Console.Write(num2 + " is Greater than "+ num1);
            else 
                Console.Write(num1 + " is Equal than " + num2);
            Console.ReadKey();

        }
    }
}
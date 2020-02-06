using System;

namespace ConsoleApp2
{
    class BasicOperations
    {
        static void Main()
        {
            int num1, num2;
            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nSum = {0}  \n\nDifference = {1} \n\nProduct = {2} \n\nQoutient = {3}\n\nRemainder = {4}", num1 + num2, num1 - num2, num1 * num2, num1 / num2, num1 % num2 );
            Console.ReadLine();
        }
    }
}
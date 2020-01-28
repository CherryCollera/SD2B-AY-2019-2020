using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample3_InputMyName
{
    class Sample3_InputMyName
    {
        static void Main(string[] args)
        {
            String fn, ln;
            Console.Write("Enter your name (First Name, Last Name): ");
            fn = Console.ReadLine();
            ln = Console.ReadLine();
            Console.Write("Hello,\t" + fn + "\t" + ln + "!");
            Console.Write("\nWelcome to OOP Environment");
            Console.ReadKey();
        }
    }
}

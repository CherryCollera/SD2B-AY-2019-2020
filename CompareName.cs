using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperation_Colorado
{
    class CompareName
    {
       static void Main(string[] args)
        {
            string string1 = "Janrey";
            string string2 = "Janrey";
            string string3 = "Johnrey";
            string string4 = "johnrey";
            string string5 = "JOHNREY";

            Console.WriteLine("Using equals() method");
            Console.WriteLine("\tcompare {0} to {1}: {2}", string1, string2, String.Equals(string1, string2));
            Console.WriteLine("\tcompare {0} to {1}: {2}", string1, string3, String.Equals(string1, string3));
            Console.WriteLine("\tlength of {0} is {1}", string1, string1.Length);
            Console.WriteLine("\tString {0} Substring(0, 3) will return {1}", string5, string5.Substring(0, 3));

            Console.WriteLine("Using compare() method");
            Console.WriteLine("\tcompare {0} to {1}: {2}", string1, string2, String.Compare(string1, string2));
            Console.WriteLine("\tcompare {0} to {1}: {2}", string1, string3, String.Compare(string1, string3));
            Console.WriteLine("\tcompare {0} to {1}: {2}", string3, string1, String.Compare(string3, string1));
            Console.WriteLine("\tcompare {0} to {1}: {2}", string4, string5, String.Equals(string4, string5));

            Console.WriteLine("Using compare() method");
            Console.WriteLine("\tcompare {0} to {1}: {2}", string1, string2, string1.CompareTo(string2));
            Console.WriteLine("\tcompare {0} to {1}: {2}", string1, string3, string1.CompareTo(string3));
            Console.WriteLine("\tcompare {0} to {1}: {2}", string3, string2, string3.CompareTo(string1));

            Console.ReadKey();
        }
    }
}


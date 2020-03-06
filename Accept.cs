using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_Colorado
{

    class Accept
    {
        public string firstname, lastname;
        public void AcceptDetails()
        {
            System.Console.Write("Enter your First name and Last name:\t");
            firstname = System.Console.ReadLine();
            lastname = System.Console.ReadLine();
        }

    }
}

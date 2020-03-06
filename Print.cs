using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_Colorado
{
    class print
    {
        public void PrintDetailes()

        {
            Accept a = new Accept();
            a.AcceptDetails();

            System.Console.Write("Hello\n" + a.firstname + "" + a.lastname + "!!!\nYou have created classes in OOP");
            MyProfile mp = new MyProfile();
            mp.DisplayProfile();

        }
    }
}

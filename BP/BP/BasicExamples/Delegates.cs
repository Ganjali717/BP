using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class Delegate
    {
        public delegate void NoParameters();

        public delegate string WithParameters(string name, string surname);

        public  static void ShowMessage()
        {
            Console.WriteLine("Hello Baku");
        }

        public static string ShowMessage2(string name, string surname)
        {
            return  $"Fullname: {name} {surname}";
        }

    }
   
}

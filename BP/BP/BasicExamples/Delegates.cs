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
            Console.Write("\nHello Baku");
        }

        public static string ShowMessage2(string name, string surname)
        {
            return  $"Fullname: {name} {surname}";
        }

        public static void ShowMultiCasting()
        {
            Console.Write(" and Azerbaijan\n");
        }
    }
   
}

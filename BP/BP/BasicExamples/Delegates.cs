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

        public  static void ShowMessage()
        {
            Console.WriteLine("Hello Baku");
        }

    }
   
}

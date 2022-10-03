using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class Week : IEnumerable
    {
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday","Friday", "Saturday", "Sunday" };
        public IEnumerator GetEnumerator() => days.GetEnumerator();
    }
}

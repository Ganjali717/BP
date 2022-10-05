using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    public class Solution
    {
        public int CalPoints(string[] ops)
        {
            string c = "C";
            string d = "D";
            string plus = "+";
            int output = 0;
            string[] newOps = new string[]{}; 
            if (ops.Length < 1)
            {
                return Convert.ToInt32(ops[0]);
            }
            else if (1 <= ops.Length || ops.Length <= 1000)
            {
                for (int i = 0; i < ops.Length; i++)
                {
                    if (ops[i] == c)
                    { 
                        int cIndex = Array.IndexOf(ops, c);
                        newOps = newOps.Except(new string[] {ops[cIndex - 1]}).ToArray();
                    }
                    else if (ops[i] == d)
                    {
                        int dIndex = Array.IndexOf(ops, d);
                        int lastElement = 0;
                        if (ops.Length == 1)
                        { 
                            lastElement = Array.IndexOf(ops, (dIndex - 1));
                        }
                       
                        int newElement = Convert.ToInt32(ops[lastElement]) * 2;
                        newOps = newOps.Concat(new string[] {newElement.ToString()}).ToArray(); 
                    }
                    else if (ops[i] == plus)
                    {
                        int plusIndex = Array.IndexOf(ops, plus);
                        int first = Array.IndexOf(ops, (plusIndex - 1));
                        int second = Array.IndexOf(ops, (plusIndex - 2));
                        int newDigit = Convert.ToInt32(ops[second] + ops[first]);
                        newOps = newOps.Concat(new string[] {newDigit.ToString()}).ToArray();
                    }
                    else
                    {
                        newOps = newOps.Concat(new string[] { ops[i] }).ToArray();
                    }
                }

            }

            for (int i = 0; i < newOps.Length; i++)
            {
                output += Convert.ToInt32(newOps[i]);
            }

            return output; 
        }
    }
}

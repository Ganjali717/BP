using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExamples
{
    public class ConditionalOperators
    {



        public int EvenNumbersAverageSum()
        {
            int[] numbers = new int[] { 2, 3, 4, 6 };
            int summary = 0, count = 0, average;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    count++;
                    summary += numbers[i];
                }
            }
            average = summary / count;
            return average;
        }
           
        public int FindLongest()
        {
            int[] numbersSecond = new int[5] { 12, 15, 68, 55, 55 };
            int maxNumber = 0;
            for (int i = 0; i < numbersSecond.Length; i++)
            {
                if (numbersSecond[i] > maxNumber)
                {
                    maxNumber = numbersSecond[i];
                }
            }
            return maxNumber;
        }

        public int SumOfDigits(int number)
        {
            int sum = 0;
            if (number > 0)
            {
                while (number > 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }
            }
            return sum;
        }
        
    }
}

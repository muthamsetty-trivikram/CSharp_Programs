using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programs
{
    public class SumOfMultiplesOf17lessthan100
    {
        public void Sum()
        {
            int sum = 0;
            int i = 0;
            while (i < 100)
            {
                if (i % 17 == 0)
                {
                    sum += i;
                }
                i++;
            }
            Console.WriteLine($"The sum of multiples of 17 less than 100 is: {sum}.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programs
{
    public class PrintOddNumbers
    {
        public void OddNumbers()
        {
            Console.WriteLine("Enter a range of a number to print odd numbers:");

            int range = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Odd numbers in the given range are:");
            int i = 0;
            while (i <= range)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }

        }

    }
}

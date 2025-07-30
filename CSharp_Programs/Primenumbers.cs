using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programs
{
    public class Primenumbers
    {
        public Primenumbers() {
            Console.WriteLine("PrimeNumbers from 1 to 100");
            int i = 1;
            while (i <= 100) 
            {
                int count = 0;
                int j = 1;
                while (j <= i)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                    j++;
                }
                if (count == 2)
                {
                    Console.WriteLine(i);
                }
                i++;
            }

        }
    }
}

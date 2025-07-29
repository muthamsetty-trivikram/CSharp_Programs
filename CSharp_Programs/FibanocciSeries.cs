using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programs
{
    public class FibanocciSeries
    {
        public FibanocciSeries()
        {
            int f1 = 0, f2 = 1, f3 = 0;
            Console.WriteLine("Enter the number of terms in Fibonacci series:");
            string count = Console.ReadLine();
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            if (int.TryParse(count, out int limit))
            {
                for (int i = 0; i < limit; i++)
                {
                    f3 = f1 + f2;
                    Console.WriteLine(f3);
                    f1 = f2;
                    f2 = f3;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}

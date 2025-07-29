using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programs
{
    public class Factorial
    {
        public Factorial()
        {
            Console.WriteLine("Enter a number to find its factorial:");
            string input = Console.ReadLine();

            if ((int.TryParse(input,out int num)) && num> 0)
            {
                int factorial = 1;
                int i = 1;
                while (i<=num)
                {
                    factorial *= i;
                    i++;

                }
                Console.WriteLine("The factorial is: " + factorial);
            }
            else
            {
                Console.WriteLine("Please enter a valid positive integer.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programs
{
    public class PosNeg
    {
        public void PositiveNegativeNumber()
        {
            Console.WriteLine("Enter a Number and get Know it is a positive number or  negative number");

            string number = Console.ReadLine();

            if (int.TryParse(number,out int num))
            {
                if (num < 0)
                {
                    Console.WriteLine("The Given Number {0} is Negative Number:", num);
                }
                else if (num > 0)
                {
                    Console.WriteLine("The Given Number {0} is Postitive Number:", num);
                }
                else
                {
                    Console.WriteLine("The Give number is Neutral {0}", num);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid inputs");
            }
        }
    }
}

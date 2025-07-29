using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programs
{
    public class EvenOddS
    {
        public void EvenOdd()
        {
            Console.WriteLine("Enter a Numbet and get know it is Even Or Odd");

            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {

                if (number % 2 == 0)
                {
                    Console.WriteLine("The given Number {0} is even Number", number);
                }
                else
                {
                    Console.WriteLine("The given Number is {0} is Odd Number ", number);
                }
            }
            else
            {
                Console.WriteLine("Please Enter a Valid Inputs");
            }
        }
    }
}

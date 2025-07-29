using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programs
{
    public class BinaryEquvalentInteger
    {
        public  BinaryEquvalentInteger()
        {
            Console.WriteLine("Enter a number to convert to binary:");
            string input = Console.ReadLine();

            if(int.TryParse(input,out int number))
            {
                if (number == 0)
                {
                    Console.WriteLine("Binary equivalent of 0 is 0");
                }
                else
                {
                    string binaryEquivalent = "";
                    while (number >=1)
                    {
                        int R = number % 2;
                        number = number / 2;
                        binaryEquivalent = R.ToString() + binaryEquivalent;
                    }
                    Console.Write(binaryEquivalent);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}

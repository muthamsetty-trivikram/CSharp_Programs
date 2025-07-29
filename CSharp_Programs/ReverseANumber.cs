using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programs
{
    public class ReverseANumber
    {
        public void Reverse()
        {
            int rev = 0;

            Console.WriteLine("Enter a number and make it reverse");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int num))
            {
                while (num != 0)
                {
                    int digit = num % 10;
                    rev = rev * 10 + digit;
                    num /= 10;
                }
                Console.WriteLine("Reversed Number is: " + rev);
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid integer number.");
            }
        }
    }
}

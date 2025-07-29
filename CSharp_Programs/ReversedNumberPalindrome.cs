using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programs
{
    public class ReversedNumberPalindrome
    {
        public ReversedNumberPalindrome()
        {
            int rev = 0;
            Console.WriteLine("Enter a number to check if it is a palindrome:");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int num))
            {
                int originalNum = num; // Store the original number for comparison
                while (num != 0)
                {
                    int digit = num % 10;
                    rev = rev * 10 + digit;
                    num /= 10;
                }
                if (rev == originalNum)
                {
                    Console.WriteLine("The number is a palindrome.");
                }
                else
                {
                    Console.WriteLine("The number is not a palindrome.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}

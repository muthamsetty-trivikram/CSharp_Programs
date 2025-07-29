using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programs
{
    public class PrimeNumber
    {
        public PrimeNumber() 
        {
            Console.WriteLine("Enter a number to check if its prime or not:");
            string num= Console.ReadLine();
            if(int.TryParse(num,out int number))
            {
                int i = 1;
                int count = 0;
                while (i <= number)
                {
                    if (number % i == 0)
                    {
                        count++;
                    }
                    i++;
                }
                if(count == 2)
                {
                    Console.WriteLine($"{number} is a prime number.");
                }
                else
                {
                    Console.WriteLine($"{number} is not a prime number.");
                }   
            }
            else
            {
                               Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}

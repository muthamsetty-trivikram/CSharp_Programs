using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programs
{
    public class MutliplesSum
    {
        public MutliplesSum() { 
            Console.WriteLine("Enter a number to find the sum of multiples of 3 and 5 below that number:");
            string input = Console.ReadLine();

            int sum = 0;

            if(int.TryParse(input,out int number)){

                int i = 0;

                while (i <= number)
                {
                    if ((i%3==0) && (i % 5 == 0))
                    {
                        sum += i;
                    }
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            Console.WriteLine($"The sum of multiples of 3 and 5 below {number} is: {sum}");


        }
    }
}

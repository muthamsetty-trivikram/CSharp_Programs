using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programs
{
    public  class EvenNUmber
    {
        public void Even()
        {
            Console.WriteLine("Enter a number and get to know whether it is Even Number Or Not");

            string input = Console.ReadLine();

            if(int.TryParse(input,out int number))
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("The given number {0} is Even number", number);
                }
                else
                {
                    Console.WriteLine("The given number {0} is Not Even number", number);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid integer number.");
            }
        }
    }
}

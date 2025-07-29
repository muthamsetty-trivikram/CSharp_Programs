using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programs
{
    public class LogicalConditional
    {
        public LogicalConditional()
        {
            Console.WriteLine("Enter Your age;");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int age))
            {
                if (age >= 1 && age <= 10)
                {
                    Console.WriteLine("You are a Child");
                }
                else if (age >= 11 && age <= 20)
                {
                    Console.WriteLine("You are a Teenager");
                }
                else if (age >= 21 && age <= 30)
                {
                    Console.WriteLine("You are a Young Adult");
                }
                else if (age >= 31 && age <= 50)
                {
                    Console.WriteLine("You are an Adult");
                }
                else if (age > 50)
                {
                    Console.WriteLine("You are a Senior Citizen");
                }

            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }
    }
}

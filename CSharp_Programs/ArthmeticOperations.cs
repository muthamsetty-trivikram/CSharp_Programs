using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programs
{
    public class ArthmeticOperations
    {
        public ArthmeticOperations() {
            
            Console.WriteLine("Enter First Number:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter Second Number:");
            string input2 = Console.ReadLine();
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Modulus");
            string choice = Console.ReadLine();
            if (double.TryParse(input1,out double num1) && double.TryParse(input2,out double num2) && int.TryParse(choice,out int operation))
            {
                switch (operation)
                {
                    case 1:
                        Console.WriteLine($"Result: {num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine($"Result: {num1 - num2}");
                        break;
                    case 3:
                        Console.WriteLine($"Result: {num1 * num2}");
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            Console.WriteLine($"Result: {num1 / num2}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;
                    case 5:
                        if (num2 != 0)
                        {
                            Console.WriteLine($"Result: {num1 % num2}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation selected.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");

            }
        }
    }
}

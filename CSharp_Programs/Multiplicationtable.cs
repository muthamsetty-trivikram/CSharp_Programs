using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programs
{
    public class Multiplicationtable
    {
        public Multiplicationtable()
        {
            Console.WriteLine("Enter the number for multiplication table:");    
            string input = Console.ReadLine();
            if(int.TryParse(input,out int number))
            {
                Console.WriteLine($"Multiplication table for {number}:");
                for (int i=1; i <= 10; i++)
                {
                    Console.WriteLine($"{number} x {i} = {number * i}");
                }
            }
            else
            {
                  Console.WriteLine("Invalid input. Please enter a valid number.");    
            }
        }
    }
}

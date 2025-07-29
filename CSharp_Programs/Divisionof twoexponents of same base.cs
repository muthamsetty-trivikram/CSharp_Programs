using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programs
{
    public class Divisionof_twoexponents_of_same_base
    {
        public Divisionof_twoexponents_of_same_base()
        {
            Console.WriteLine("Enter a Base Number:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter Exponent 1:");
            string input2 = Console.ReadLine();
            Console.WriteLine("Enter Exponent 2:");
            string input3 = Console.ReadLine();
            if ((int.TryParse(input1, out int base1)) && (int.TryParse(input2, out int exp1)) && (int.TryParse(input3, out int exp2)))
            {
                int div = exp1 - exp2;
                Console.WriteLine($"Division of two exponents of same base {base1} is: {Math.Pow(base1, div)}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid integers for base and exponents.");
            }
        }
    }
}

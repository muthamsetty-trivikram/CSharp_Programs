using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programs
{
    public class MultiplyTwoBinarys
    {
        public MultiplyTwoBinarys()
        {
            Console.WriteLine("Enter first binary number:");
            string binary1 = Console.ReadLine();
            Console.WriteLine("Enter second binary number:");
            string binary2 = Console.ReadLine();
            // Convert binary strings to integers
            int num1 = Convert.ToInt32(binary1, 2);
            int num2 = Convert.ToInt32(binary2, 2);
            // Calculate the product
            int product = num1 * num2;
            // Convert the product back to binary
            string binaryProduct = Convert.ToString(product, 2);
            Console.WriteLine($"The product of {binary1} and {binary2} is: {binaryProduct}");
        }
    }
}

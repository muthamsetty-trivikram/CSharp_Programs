using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programs
{
    public class SumOfDigits
    {
        public void Sum()
        {
            int sum = 0;

            Console.WriteLine("Enter a numbet and get to know its sum :");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int num))
            {
                int spare = num;

                while (num != 0)
                {
                    int r = num % 10;

                    num = num / 10;

                    sum += r;
                }
                Console.WriteLine($"The Sum of Digits of A given Number is {spare} and its sum is {sum}");
            }
            else
            {
                Console.WriteLine("Please Enter a valid integers");
            }
        }
    }
}

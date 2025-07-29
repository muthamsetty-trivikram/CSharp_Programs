using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programs
{
    public  class Swap2Numbers
    {
        public void  Swapping()
        {
            Console.WriteLine("Enter First Number:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter Second Number:");
            string input2 = Console.ReadLine();

            if (int.TryParse(input1,out int number1) && int.TryParse(input2 ,out int number2)){

                Console.WriteLine("Before Swapping: Number1 = " + number1 + ", Number2 = " + number2);

                int temp = number1;
                number1 = number2;
                number2 = temp;

                Console.WriteLine("After Swapping: Number1 = " + number1 + ", Number2 = " + number2);

            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
            }

        }
    }
}
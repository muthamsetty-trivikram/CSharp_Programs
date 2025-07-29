using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programs
{
    public class GratestNumberInTwoNumbers
    {
        public void Greatest()
        {
            Console.WriteLine("Entr First Number :");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter Second Number:");
            string input2 = Console.ReadLine();

            if(int.TryParse(input1,out int number1) && int.TryParse(input2,out int number2))
            {
                if (number1> number2)
                {
                    Console.WriteLine("The Greatest number between {0} and {1} is : {2}", number1, number2, number1);

                }
                else
                {
                    Console.WriteLine("The Greatest Number Between {0} and {1} is {2}", number1, number2, number2);
                }

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programs
{
    public class HeightDecider
    {
        public HeightDecider() 
        {
            Console.WriteLine("Enter Your height in Feets:");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double height))
             {
               if (height <= 4.5)
                {
                    Console.WriteLine("Dwarf");
                }
                else if((height >=5.4) && (height <= 5.10))
                {
                    Console.WriteLine("Average");
                }
                else
                {
                    Console.WriteLine("Taller");
                }
            }
        }
    }
}

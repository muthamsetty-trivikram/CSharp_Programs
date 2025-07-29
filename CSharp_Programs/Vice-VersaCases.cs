using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programs
{
    public class Vice_VersaCases
    {
        public Vice_VersaCases()
        {
            Console.WriteLine("Enter characters in a string to convert them to their vice versa cases (uppercase to lowercase and vice versa");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input cannot be null or empty.");
                return;
            }
            else
            {
                foreach (var item in input)
                {
                    if (item >= 'a' && item <= 'z')
                    {
                        Console.Write((char)(item-32));
                    }
                    else if (item >= 'A' && item <= 'Z')
                    {
                        Console.Write((char)(item+32));
                    }
                    else
                    {
                        Console.Write(item);
                    }
                }
            }
        }
    }
}

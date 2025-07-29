using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programs
{
    public class Unboxing
    {
        public Unboxing() 
        {
            object boxing = 1;
            Console.WriteLine("Boxing {0}", boxing.GetType());
            Console.WriteLine(boxing is int);
            int Unboxing = (int)boxing;
            Console.WriteLine("UnBoxing {0}", Unboxing.GetType());
            Console.WriteLine(Unboxing is int);
        }
    }
}

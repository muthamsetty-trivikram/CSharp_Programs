using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programs
{
    public class Boxing
    {
        public Boxing() 
        {
            int a = 1;
            Console.WriteLine( "Before Boxing {0}",a.GetType());
            Console.WriteLine(a is object); //All types should be treated as object
            Object BOXING = a;
            Console.WriteLine("After Boxing {0}",BOXING.GetType());
            Console.WriteLine(BOXING is object); //This type is treated also object with boxing
        }
    }
}

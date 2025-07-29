using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programs
{
    public class SumOfDigitsRecusion
    {
        public int sumRecursion(int n)
        {
            if (n != 0)
            {
                return ((n % 10) + sumRecursion(n/10));
            }
            else
            {
                return 0;
            }
        }
    }
}

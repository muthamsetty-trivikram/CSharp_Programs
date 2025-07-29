using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programs
{
    public class GradeDisplay
    {
        public GradeDisplay()
        {
            Console.WriteLine("Enter Your Grade In A,B,C,D and F");
            string grade = Console.ReadLine();
            switch (grade.ToUpper())
            {
                case "A":
                    Console.WriteLine("Excellent");
                    break;
                case "B":
                    Console.WriteLine("Good");
                    break;
                case "C":
                    Console.WriteLine("Average");
                    break;
                case "D":
                    Console.WriteLine("Poor");
                    break;
                case "F":
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid Grade");
                    break;
            }
        }
    }
}

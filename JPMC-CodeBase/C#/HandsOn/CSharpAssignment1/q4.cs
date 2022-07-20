using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1
{
    internal class q4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            string val;
            val = Console.ReadLine();
            int a = Convert.ToInt32(val);
            if (a % 2 == 0)
                Console.WriteLine("Given number is even");
            else
                Console.WriteLine("Given number is odd");
            
        }
    }
}

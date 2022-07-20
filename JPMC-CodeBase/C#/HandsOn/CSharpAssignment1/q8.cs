using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1
{
    internal class q8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER A NUMBER: ");
            int a = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 2; i <= a; i++)
                fact *= i;
            Console.WriteLine("The factorial of {0} is {1}", a, fact);
        }
    }
}

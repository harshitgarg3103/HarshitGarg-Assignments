using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1
{
    internal class q13   {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THREE NUMBERS: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                    Console.WriteLine("{0} is the highest", a);
                else
                    Console.WriteLine("{0} is the highest",c);
            }
            else if(b>a)
            {
                if (b > c)
                    Console.WriteLine("{0} is the highest", b);
                else
                    Console.WriteLine("{0} is the highest", c);
            }
        }
    }
}

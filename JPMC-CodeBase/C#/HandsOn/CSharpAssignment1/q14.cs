using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1
{
    internal class q14   {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER FIVE NUMBERS: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            if (a <b && a<c && a<d && a<e)
            {
                Console.WriteLine("{0} is the smallest",a);
            }
            else if(b<a && b<c && b<d && b<e)
                Console.WriteLine("{0} is the smallest", b);
            else if(c<a && c<b && c<d && c<e)
                Console.WriteLine("{0} is the smallest", c);
            else if(d<a && d<b && d<c && d<e)
                Console.WriteLine("{0} is the smallest", d);
            else
                Console.WriteLine("{0} is the smallest", e);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1
{
    internal class q9
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c = a + b;
            Console.WriteLine(a + "\n" + b);
            while(c<=40)
            {
                Console.WriteLine(c);
                a = b;
                b = c;
                c = a + b;
            }
        }
    }
}

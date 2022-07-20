using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1
{
    internal class q7
    {
        static void Main(string[] args)
        {
            int a = 0;
            while (a * a <= 625)
            {
                Console.WriteLine(a*a);
                a++;
            }
        }
    }
}

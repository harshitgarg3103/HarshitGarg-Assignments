using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1
{
    internal class q12    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers divisible by 7 between 200 and 300 are");
            for(int i=200;i<=300;i++)
            {
                if (i % 7 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}

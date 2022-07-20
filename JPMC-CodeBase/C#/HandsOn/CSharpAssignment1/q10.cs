using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1
{
    internal class q10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER A NUMBER: ");
            int n = int.Parse(Console.ReadLine());
            for(int i=5;i<=n;i++)
            {
                Console.WriteLine(Math.Pow(i, 3));
            }
        }
    }
}

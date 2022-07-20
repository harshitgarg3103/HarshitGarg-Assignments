using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1
{
    internal class q11    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER A NUMBER: ");
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=20;i++)
            {
                Console.WriteLine("{0} X {1} = {2}",n,i,n*i);
            }
        }
    }
}

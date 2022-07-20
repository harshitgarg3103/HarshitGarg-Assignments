using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1
{
    internal class q3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");
            string val;
            val = Console.ReadLine();
            int a =Convert.ToInt32(val); ;
            val = Console.ReadLine();
            int b = Convert.ToInt32(val);
            Console.WriteLine("Numbers between {0} and {1} are:\n",a,b);
            for(int i=a+1;i<b;i++)
            {
                Console.WriteLine(i+" ");
            }
        }
    }
}

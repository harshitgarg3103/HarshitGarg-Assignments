using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1
{
    internal class q5
    {
        static void Main(string[] args)
        {
            int status=0,a,even=0,odd=0;
            while (true)
            {
                Console.WriteLine("Enter a number: ");
                string val;
                val = Console.ReadLine();
                a = Convert.ToInt32(val);
                if (a == -1)
                    break;
                if (a % 2 == 0)
                    even++;
                else
                    odd++;
            }
            Console.WriteLine("Odd = "+odd+" Even = "+even);
        }
    }
}

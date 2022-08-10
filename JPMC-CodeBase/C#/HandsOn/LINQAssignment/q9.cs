using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignment
{
    internal class q9
    {
        static void Main()
        {
            int[] arr = { 2,4,6,3,5,7,8};
            var lquery=from k in arr
                       where (k%2==0)
                       select k;
            int i = 0;
            foreach(var k in lquery)
            {
                Console.Write(k + " ");
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("The count of even numbers is "+i);
        }
    }
}

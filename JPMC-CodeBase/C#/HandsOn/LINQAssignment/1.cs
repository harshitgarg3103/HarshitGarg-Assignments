using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignment
{
    internal class _1
    {
        static void Main()
        {
            int[] arr = { 2,4,8,10,11,13,45,32};
            var lquery=from k in arr
            where (k*k*k>100 && k*k*k<1000)
            select k*k*k;
            foreach (var s in lquery)
                Console.WriteLine(s);
        }
    }
}

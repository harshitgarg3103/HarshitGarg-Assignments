using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAssignment
{
    internal class q2
    {
        static void Main(string[]args)
        {
            ArrayList arr = new ArrayList() { "Harshit","John","Kennedy","Asha","Vibhor","Bhajan"};
            
            arr.Sort();
            arr.Reverse();
            Console.WriteLine("Names sorted in descending order are ");
            foreach (var k in arr)
            {
                Console.Write(k + " ");
            }
        }
    }
}

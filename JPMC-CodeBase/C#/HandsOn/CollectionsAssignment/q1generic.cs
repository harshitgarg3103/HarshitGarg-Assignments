using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAssignment
{
    internal class q1generic
    {
        static void Main(string[]args)
        {
            List arr<int> = new List<int>();
            Console.WriteLine("Enter 10 numbers: ");
            for(int i=0;i<10;i++)
            {
                int item = int.Parse(Console.ReadLine());
                arr.Add(item);
            }
            arr.Sort();
            arr.Reverse();
            Console.WriteLine("10 numbers sorted in descending order are ");
            foreach(var k in arr)
            {
                Console.Write(k + " ");
            }
        }
    }

}

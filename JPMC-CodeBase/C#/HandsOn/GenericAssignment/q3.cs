using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

using System.Threading.Tasks;

namespace GenericAssignment
{
    internal class q3
    {
        static void Main(string[] args)
        {
            SortedList<int,string> hs = new SortedList<int,string>();
            Console.WriteLine("Enter number of employees: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER EMPLOYEE CODE AND NAME: ");
            for (int i = 0; i < n; i++)
            {
                int code = int.Parse(Console.ReadLine());
                string name = Console.ReadLine();
                hs.Add(code, name);
            }
            Console.WriteLine("Employee names and code in ascending order are: ");
            foreach (var k in hs.Keys)
            {
                Console.WriteLine(k + " " + hs[k]);
            }
        }
    }
}

using System;
using System.Linq;
namespace AssignmentLinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] no = { 2, 5, 8, 10, 12, 23, 43, 54, 43, 32, 21, 56, 67, 78, 87, 76, 65 };
            var result = from k in no
                         where k * k * k > 100 && k * k * k < 1000
                         select k * k * k;
            foreach (var n in result)
                Console.WriteLine(n);
        }
    }
}
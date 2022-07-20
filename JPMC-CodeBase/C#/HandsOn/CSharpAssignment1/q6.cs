using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1
{
    internal class q6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature in fahreinheit: ");
            string val;
            val = Console.ReadLine();
            double a = Convert.ToDouble(val);
            double b = (a - 32) / 1.8;
            Console.WriteLine("Temp. in Celsius is " + b);
        }
    }
}

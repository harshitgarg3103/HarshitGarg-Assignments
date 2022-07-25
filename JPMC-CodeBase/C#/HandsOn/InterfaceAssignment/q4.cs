using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment
{
    
    public interface f
    {
        public double yearlySales();
    }
    public abstract class c
    {
        public double d;
        public abstract double getmonthlySales();
        public double dailySales()
        {
            return d;
        }
    }
    public class absnc: c,f
    {
        public override double getmonthlySales()
        {
            return 30 * d ;
        }
        public double yearlySales()
        {
            return 365.0D * d;
        }
    }
    public class q4
    {
        static void Main(string[]args)
        {
            absnc c1 = new absnc();
            c1.d = 400;
            Console.WriteLine("Daily sales is " + c1.d);
            Console.WriteLine("Monthly sales is " + c1.getmonthlySales());
            Console.WriteLine("Yearly sales is " + c1.yearlySales());
        }
    }
}

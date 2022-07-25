using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment
{
    public interface Payable
    {
        public double amountDue();
        public double addAmountDue(double d);
        public string paymentAddress();
    }
    class Accounting: Payable
    {
        public double amount;
        public string pay;
        public Accounting(double d,string s)
        {
            amount = d;
            pay = s;
        }
        public double amountDue()
        {
            return amount;
        }
        public double addAmountDue(double d)
        {
            amount += d;
            return amount;
        }
        public string paymentAddress()
        {
            return pay;
        }
    }
    internal class q2
    {
        static void Main(string[]args)
        {
            Accounting ac = new Accounting(5604.0D, "Pune");
            Console.WriteLine("Amount due is " + ac.amountDue());
            Console.WriteLine("Amount after adding is " + ac.addAmountDue(1000.0D));
            Console.WriteLine("Payment address is " + ac.paymentAddress());
        }
    }
}

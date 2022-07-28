using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class q5
    {
        static void Main(string[] args)
        {
            Transactions c1 = new Transactions();
            Transactions c2 = new Transactions();
            c1.amount = "Donumber";
            c1.TransactionID = "HSBC";
            c1.td = DateTime.Parse("21.07.2022");
            c1 = c2;
            Checkings ch = new Checkings();
            ch.Equals(c1, c2);
        }
    }
    class Transactions
    {
        public string TransactionID;
        public string amount;
        public DateTime td;
    }
    class Checkings : Transactions
    {
        public void Equals(Transactions c1, Transactions c2)
        {
            if (c1.Equals(c2))
            {
                Console.WriteLine("Transactions are same");
                return;
            }
            else
            {
                Console.WriteLine("Transaction are not same");
                return;
            }
        }
    }
}

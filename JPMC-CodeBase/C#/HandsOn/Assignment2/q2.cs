using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class q2
    {
        class Transaction
        {
            public int transactionId;
            public double amount;
            public DateTime dob;
            public Transaction() { }
            public Transaction(int t,double a,DateTime d)
            {
                transactionId = t;
                amount = a;
                dob = d;
            }
        }
        class TransactionManager
        {
            public void createTransaction(Transaction trans)
            {
                trans.transactionId = 123;
                trans.amount = 123.43D;
                trans.dob=DateTime.Parse("22.01.3000");
            }
            public void showTransactionDetails(Transaction trans)
            {
                Console.WriteLine("ID= {0} Amount= {1} DOB= {2}", trans.transactionId, trans.amount,trans.dob);
            }
        }
        static void Main(string[]args)
        {
            Transaction t = new Transaction();
            TransactionManager tm = new TransactionManager();
            tm.createTransaction(t);
            tm.showTransactionDetails(t);
        }
    }
}

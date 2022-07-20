using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Account
    {
        public int account_no;
        public string cust_name;
        public string acc_type;
        public string tran_type;
        public double amount, balance;
        public void credit(double amt)
        {
            balance += amt;
        }
        public void debit(double amt)
        {
            if (balance >= amt)
                balance -= amt;
            else
                balance = 0.0D;
        }
        public void accept(int acc, string name, string type,double balance)
        {
            account_no = acc;
            cust_name = name;
            acc_type = type;
            this.balance = balance;
        }
        public void show_details()
        {
            Console.WriteLine("Account No = {0} Customer Name = {1} Account type = {2} Balance = {3}",account_no,cust_name,acc_type,balance);
        }
    }
}

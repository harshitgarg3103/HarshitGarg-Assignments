using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class q3
    {
        class Account
        {
            public int accountNo;
            public string type;
            public int debitNo;
            public int pin;
            public string loginId;
            public string password;
            public double balance;
        }
        class current : Account
        {
            public string companyName;
            public string typeOfBusiness;
            public string website;
            public string contactName;

        }
        class savings_corporate : Account
        {
            public string companyName;
        }
        class BankManager
        {
            List<Account> list = new List<Account>();
            public void createAccount(Account ac)
            {
                ac.accountNo = 123456;
                ac.type = "Savings";
                ac.debitNo = 545445;
                ac.pin = 4561;
                ac.loginId = "UTyut";
                ac.password = "gdgdg";
                ac.balance = 4562.36D;
                list.Add(ac);
            }
            public Account getAccountById(int acNo)
            {
                foreach(var a in list)
                {
                    if (a.accountNo == acNo)
                        return a;
                }
                return list[0];
            }
            public List<Account> getAllAccounts()
            {
                return list;
            }
            public void displayAccount(Account ac)
            {
                Console.WriteLine("AccountNo= {0} type= {1} DebitNo= {2} Pin= {3} LoginId= {4} Password= {5} Balance= {6}", ac.accountNo, ac.type, ac.debitNo, ac.pin, ac.loginId, ac.password, ac.balance);
            }
        }
        static void Main(string[]args)
        {
            Account ac = new Account();
            BankManager am = new BankManager();
            am.createAccount(ac);
            am.displayAccount(ac);
            Account a = am.getAccountById(123);
            List<Account> l = new List<Account>();
            l = am.getAllAccounts();
        }
    }
}

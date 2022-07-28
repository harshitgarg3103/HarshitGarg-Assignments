using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class q4
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
        class current: Account
        {
            public string companyName;
            public string typeOfBusiness;
            public string website;
            public string contactName;

        }
        class savings_corporate: Account
        {
            public string companyName;
        }
        class AccountManager
        {
            public void createAccount(Account ac)
            {
                ac.accountNo = 123456;
                ac.type = "Savings";
                ac.debitNo = 545445;
                ac.pin = 4561;
                ac.loginId = "UTyut";
                ac.password = "gdgdg";
                ac.balance =4562.36D;
            }
            public void displayAccount(Account ac)
            {
                Console.WriteLine("AccountNo= {0} type= {1} DebitNo= {2} Pin= {3} LoginId= {4} Password= {5} Balance= {6}", ac.accountNo, ac.type,ac.debitNo,ac.pin,ac.loginId,ac.password,ac.balance);
            }
        }
        static void Main()
        {
            Account ac = new Account();
            AccountManager am = new AccountManager();
            am.createAccount(ac);
            am.displayAccount(ac);
        }
    }
}

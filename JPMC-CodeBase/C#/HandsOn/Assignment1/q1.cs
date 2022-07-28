namespace Assignment1
{
    internal class q1

    {
        static void Main(string[] args)
        {
            Account ac = new Account();
            AccountMgr am = new AccountMgr();
            am.storedata(ac);
            am.showdata(ac);
        }
    }
    class Account
    {
        public int accountno { get; set; }
        public string accounttype { get; set; }
        public int debitcardno { get; set; }
        public int pin { get; set; }
        public string loginid { get; set; }
        public string password { get; set; }
        public double balance { get; set; }
    }
    class AccountMgr
    {
        public void storedata(Account ac)
        {
            Console.WriteLine("Eneter account number");
            ac.accountno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter pin");
            ac.pin = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter account type");
            ac.accounttype = Console.ReadLine();
            Console.WriteLine("enter debit card number");
            ac.debitcardno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter loginid");
            ac.loginid = Console.ReadLine();
            Console.WriteLine("Enter password");
            ac.password = Console.ReadLine();
            Console.WriteLine("enter balance");
            ac.balance = double.Parse(Console.ReadLine());

        }
        public void showdata(Account ac)
        {
            Console.WriteLine($"Account number: {ac.accountno} \nAccount type: {ac.accounttype} \nDebit card number: {ac.debitcardno} \nLogin ID: {ac.loginid} \nBalnace: {ac.balance}");
        }

    }
}
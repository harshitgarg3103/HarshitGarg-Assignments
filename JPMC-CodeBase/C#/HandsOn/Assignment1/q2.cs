using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class q2
    {
        static void Main(string[] args)
        {
            Payee py = new Payee();
            PayeeMgr pm = new PayeeMgr();
            pm.storedata(py);
            pm.showdata(py);
        }
    }
    class Payee
    {
        public int Id { get; set; }
        public string accname { get; set; }
        public int accno { get; set; }
        public string bank { get; set; }
    }
    class PayeeMgr
    {
        public void storedata(Payee py)
        {
            Console.WriteLine("Eneter account number");
            py.accno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ID");
            py.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter account name");
            py.accname = Console.ReadLine();

            Console.WriteLine("Enter bank name");
            py.bank = Console.ReadLine();

        }
        public void showdata(Payee ac)
        {
            Console.WriteLine($"Account number: {ac.accno} \nAccount name: {ac.accname} \nID: {ac.Id} \nBank name: {ac.bank}");
        }

    }
}

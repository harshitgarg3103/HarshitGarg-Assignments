using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class q3
    {
        static void Main(string[] args)
        {
            ContactInfo ac = new ContactInfo();
            ContactInfoMgr am = new ContactInfoMgr();
            am.storedata(ac);
            am.showdata(ac);

        }
    }
    class ContactInfo
    {
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string nobileno { get; set; }
        public string emailid { get; set; }
        public double balance { get; set; }
    }
    class ContactInfoMgr
    {
        public void storedata(ContactInfo ac)
        {
            Console.WriteLine("Eneter address");
            ac.address = Console.ReadLine();
            Console.WriteLine("Enter country");
            ac.country = Console.ReadLine();
            Console.WriteLine("Enter city");
            ac.city = Console.ReadLine();
            Console.WriteLine("enter state");
            ac.state = (Console.ReadLine());
            Console.WriteLine("Enter nobileno");
            ac.nobileno = Console.ReadLine();
            Console.WriteLine("Enter emailid");
            ac.emailid = Console.ReadLine();

        }
        public void showdata(ContactInfo ac)
        {
            Console.WriteLine($"ContactInfo address: {ac.address} \nContactInfo city: {ac.city} \nContactInfo state: {ac.state} \nContact number: {ac.nobileno} \nEmail ID: {ac.emailid}");
        }

    }
}

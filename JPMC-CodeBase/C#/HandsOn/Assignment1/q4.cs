using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class q4
    {
        static void Main(string[] args)
        {
            Current c1 = new Current();
            Current c2 = new Current();
            c1.businesstype = "Donumber";
            c1.compname = "HSBC";
            c1.website = "hsbc.com";
            c2.contactname = "9876545629";
            c1 = c2;
            Checking ch = new Checking();
            ch.Equals(c1, c2);
        }
    }
    class Current
    {
        public string compname;
        public string businesstype;
        public string website;
        public string contactname;
    }
    class Checking : Current
    {
        public void Equals(Current c1, Current c2)
        {
            if (c1.Equals(c2))
            {
                Console.WriteLine("Company are same");
                return;
            }
            else
            {
                Console.WriteLine("Comapny are not same");
                return;
            }
        }
    }
}

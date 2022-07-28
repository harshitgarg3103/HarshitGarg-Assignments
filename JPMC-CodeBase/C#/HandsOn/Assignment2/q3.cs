using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class q3
    {
        class ContactInfo
        {
            public string address;
            public string city, state, country, phoneNo, mobileNo, emailId;
            public ContactInfo() { }
            public ContactInfo(string a,string c,string s,string co,string p,string m,string e)
            {
                address = a;
                city = c;
                state = s;
                country = co;
                phoneNo = p;
                mobileNo = m;
                emailId = e;
            }
        }
        class ContactInfoManager
        {
            public void createContact(ContactInfo c)

            {
                c.address = "234 indra";
                c.city = "Pune";
                c.state = "UP";
                c.country = "India";
                c.phoneNo = "1576537";
                c.mobileNo = "76526436437";
                c.emailId = "ysyutdyugdygu@gmail.com";
            }
            public void displayContactDetails(ContactInfo c)
            {
                Console.WriteLine("Address= {0} City= {1} State= {2} Country= {3} Phone= {4} Mobile= {5} Email= {6}",c.address,c.city,c.state,c.country,c.phoneNo,c.mobileNo,c.emailId);
            }
        }
        static void Main()
        {
            ContactInfo c = new ContactInfo();
            ContactInfoManager c1 = new ContactInfoManager();
            c1.createContact(c);
            c1.displayContactDetails(c);
        }
    }
}

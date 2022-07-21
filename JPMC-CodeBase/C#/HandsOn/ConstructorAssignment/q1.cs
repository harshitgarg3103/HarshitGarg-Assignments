using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    internal class q1
    {

    }
    class Person
    {
        public string fname, lname;
        public string mail;
        public DateTime dob;
        public Person(string f,string l,string m, DateTime d)
        {
            fname = f;
            lname = l;
            mail = m;
            dob = d;
        }
        public static Person create()
        {
            Console.WriteLine("ENTER FNAME: ");
            string f = Console.ReadLine();
            Console.WriteLine("ENTER LNAME: ");
            string l = Console.ReadLine();
            Console.WriteLine("ENTER Mail: ");
            string m = Console.ReadLine();
            Console.WriteLine("Enter dob: ");
            DateTime t = DateTime.Parse(Console.ReadLine());
            Person p = new Person(f,l,m,t);
            return p;
        }
        public void display()
        {
            Console.WriteLine("FName= {0} LName= {1} Mail= {2} DOB = {3}",fname,lname,mail,dob);
        }
    }
}

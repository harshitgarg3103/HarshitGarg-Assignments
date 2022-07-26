using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace CollectionsAssignment
{
    class Bookstore
    {
        public int bookid;
        public string name;
        public Hashtable hs = new Hashtable();
        public Bookstore()
        {
            Console.WriteLine("Enter number of books: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER ID AND NAME OF BOOK: ");
            for(int i=0;i<n;i++)
            {
                bookid = int.Parse(Console.ReadLine());
                name = Console.ReadLine();
                hs.Add(bookid, name);
            }
        }
        public void display()
        {
            Console.WriteLine("Book information is: ");
            foreach (var k in hs.Keys)
                Console.WriteLine(k + " " + hs[k]);
        }
    }
    internal class q4
    {
        static void Main(string[]args)
        {
            Bookstore b = new Bookstore();
            b.display();
        }
    }
}

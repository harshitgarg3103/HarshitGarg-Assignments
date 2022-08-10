using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignment
{
    class match
    {
        public string Name { get; set; }    
        public string country { get; set; }
    }
    internal class q2
    {
        static void Main()
        {
            // i am going by taking 2 lists of same length instead of dividing it
            List<match> list1 = new List<match>()
            {
                new match() { Name = "Joshua",country="India" },
                new match() { Name = "Hema",country="India" },
                new match() { Name = "Jaya",country="Columbia" },
            };
            List<match> list2 = new List<match>()
            {
                new match() { Name = "Klaus",country="India" },
                new match() { Name = "Elijah",country="Germany" },
                new match() { Name = "Stefan",country="Columbia" },
            };
            var lquery = from m1 in list1 from m2 in list2
                       where m1.country != m2.country
                         select new {m1,m2};
            Console.WriteLine("List of matches are: ");
            foreach (var k in lquery)
                Console.WriteLine(k.m1.Name + " " + k.m2.Name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignment
{
    class Item:Order
    {
        public string Name { get; set; }
        public int price { get; set; }
    }
    internal class q5
    {
        static void Main()
        {
            List<Item> items = new List<Item>()
            {
                new Item(){Name="Tea",price=100,OrderID=1,Orderdate=new DateTime(2022,05,25),quantity=12},
                new Item() { Name="Coffee", price=200,OrderID=2,Orderdate=new DateTime(2022,06,25),quantity=14},
            };
            var lquery = from Item item in items
                         orderby item.Orderdate
                         group item by item.Orderdate.Month;
            foreach(var i in lquery)
            {
                foreach(var o in i)
                {
                    Console.WriteLine(o.Name+" "+o.OrderID+" "+o.Orderdate+" "+(o.price*o.quantity));
                }
            }

        }
    }
}

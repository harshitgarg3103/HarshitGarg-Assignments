﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignment
{
    
    internal class q4
    {
        static void Main()
        {
            List<Order> orders = new List<Order>()
            {
                new Order() { OrderID = 1, OrderName = "Tea", Orderdate=new DateTime(2012,05,25),quantity=12 },
                new Order() { OrderID = 2, OrderName = "Coffee", Orderdate=new DateTime(2013,05,25),quantity=13 },
                new Order() { OrderID = 3, OrderName = "Water", Orderdate=new DateTime(2012,06,25),quantity=2 },
                new Order() { OrderID = 4, OrderName = "Coca Cola", Orderdate=new DateTime(2012,05,28),quantity=10 },
            };
            var lquery = from Order o in orders
                         orderby o.Orderdate descending
                         group o by o.Orderdate.Month;
            foreach (var k in lquery)
                Console.WriteLine(k.Key + " " + k.Count());
        }
    }
}

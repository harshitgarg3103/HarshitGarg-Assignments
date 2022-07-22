using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAssignment
{
    internal class q1
    {
    }
    class Book
    {
        private int isbn,quantity;
        private string bookname;
        private string title,author;
        private double price;
        public int ISBN
        {
            get{ return isbn; }
            set{ 
                isbn = value;
            }
        }
        public int quantit
        {
            get { return quantity; }
            set
            {
                quantity = value;
            }
        }
        public string name
        {
            get { return bookname; }
            set
            {
                bookname = value;
            }
        }
        public string TITLE
        {
            get { return title; }
            set
            {
                title = value;
            }
        }
        public string AUTHOR
        {
            get { return author; }
            set
            {
                author = value;
            }
        }
        public double PRICE
        {
            get { return price; }
            set
            {
                price = value;
            }
        }
        public void display()
        {
            double amount = (double)quantity * price;
            Console.WriteLine("Amount is " + amount);
        }
    }
}


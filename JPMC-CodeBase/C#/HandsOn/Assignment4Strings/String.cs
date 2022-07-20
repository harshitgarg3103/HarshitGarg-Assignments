using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4Strings
{
    class String
    {
        public string name = "The quick brown fox jumps over the lazy dog";
        public void print12()
        {
            Console.WriteLine("Character at 12th index is " + name[12]);
        }
        public void containsIs()
        {
            string[] str = name.Split(' ');
            int flags = 0;
            foreach (string s in str)
            {
                if (s == "is")
                {
                    Console.WriteLine("Found Is");
                    flags = 1;
                    break;
                }
            }
            if (flags == 0)
                Console.WriteLine("Not found Is");
        }
        public void cancatenate()
        {
            name = name + " and killed it";
            Console.WriteLine("Modified string is " + name);
        }
        public void EndWithDogs()
        {
            if (name.EndsWith("dogs"))
            {
                Console.WriteLine("String ends with dogs");
            }
            else
                Console.WriteLine("String does not end with dogs");
        }
        public void checkEqualsto()
        {
            if (name.Equals("The quick brown fox jumps over the lazy dog"))
            {
                Console.WriteLine("Given two strings are equal");
            }
            else
            {
                Console.WriteLine("Given two strings are not equal");
            }
            if (name.Equals("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG"))
            {
                Console.WriteLine("Given two strings are equal");
            }
            else
                Console.WriteLine("Given two strings are not equal");
        }
        public void findLength()
        {
            Console.WriteLine("The length of the string is " + name.Length);
        }
        public void matches()
        {
            if (string.Compare(name, "The quick brown fox jumps over the lazy dog") == 0)
            {
                Console.WriteLine("Given two strings are equal");
            }
            else
            {
                Console.WriteLine("Given two strings are not equal");
            }
        }
        public void replace()
        {
            name = name.Replace("The", "A");
            Console.WriteLine("String after replacing the with A is " + name);
        }
        public void substring()
        {
            string subS1 = name.Substring(0, 19);
            string subS = name.Substring(20, name.Length - 20);
            Console.WriteLine("Two strings after separation are " + subS1 + " and " + subS);
        }
        public void printAnimal()
        {
            string[] s = name.Split(' ');
            foreach (string s1 in s)
            {
                if (s1 == "fox" || s1 == "dog")
                    Console.WriteLine(s1);
            }
        }
        public void printLower()
        {
            Console.WriteLine("string in lowercase is " + name.ToLower());
        }
        public void printUpper()
        {
            Console.WriteLine("string in uppercase is " + name.ToUpper());
        }
        public void findIndex()
        {
            Console.WriteLine("Index position of character is " + name.IndexOf('a'));
        }
        public void findLastIndex()
        {
            Console.WriteLine("Last index position of e is " + name.LastIndexOf('e'));
        }
        public void serverPrint()
        {
            Console.WriteLine("ENTER THE DIRECTORY OF TOMCAT SERVER: ");
            string ser = Console.ReadLine();
            ser = string.Join("/", "WebApps/MyApps/Images");
            Console.WriteLine("New Directory path is " + ser);
        }
        public void constantString()
        {
            const string cs = "I wandered lonely as a cloud\nThat floats on high o'er vales and hills,\nWhen all at once I saw a crowd,\nA host, of golden daffodils;\nBeside the lake, beneath the trees,\nFluttering and dancing in the breeze.";
            Console.WriteLine(cs);
        }
    }
}

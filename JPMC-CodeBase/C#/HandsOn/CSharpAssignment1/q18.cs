using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1
{
    internal class q18 {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word: ");
            string word = Console.ReadLine();
            Console.WriteLine("Enter second word: ");
            string reverse = Console.ReadLine();
            if (word == reverse)
                Console.WriteLine("Given two words are same");
            else
                Console.WriteLine("Given two words are not same");
        }
    }
}

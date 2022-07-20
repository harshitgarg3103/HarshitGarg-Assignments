using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1
{
    internal class q17 {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();
            string reverse = "";
            for(int i=word.Length-1;i>=0;i--)
            {
                reverse = reverse + word[i];
            }
            Console.WriteLine("REVERSE WORD IS "+reverse);
        }
    }
}

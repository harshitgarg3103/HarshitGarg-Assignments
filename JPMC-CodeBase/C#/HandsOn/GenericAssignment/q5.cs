using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace GenericAssignment
{
    internal class q5
    {
        class Student
        {
            public string name;
            public List<string> arr = new List<string>();
            public Student()
            {
                Console.WriteLine("Enter number of students: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    name = Console.ReadLine();
                    arr.Add(name);
                }
            }
            public void display()
            {
                Console.WriteLine("Student details are: ");
                foreach (var k in arr)
                    Console.WriteLine(k);
            }
        }
        static void Main(string[] args)
        {
            Student s = new Student();
            s.display();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Student
    {
        public int roll;
        public string name;
        public int classe,sem;
            public string branch;
        public int[] marks = new int[5];
        public Student(int r, string n, int c,int s,string b )
        {
            roll = r;
            name = n;
            classe = c;
            sem = s;
            branch = b;
            marks[0] = 10;
            for (int i = 1; i < 5; i++)
                marks[i] = marks[i - 1] + 10;
        }
        public void calculate()
        {
            int sum = 0,Flag=0;
            for(int i=0;i<5;i++)
            {
                sum += marks[i];
                if (marks[i]<35)
                {
                    Console.WriteLine("Failed");
                    Flag = 1;
                    break;
                }
            }
            double avg = (double)sum / 5.0D;
            if (Flag == 0)
            {
                Console.WriteLine("The average of marks is " + avg);
            }
            else if (avg < 50)
            {
                Console.WriteLine("Failed");
            }
            else
                Console.WriteLine("Passed");

        }
        public void display()
        {
            Console.WriteLine("Name = {0} Roll No.= {1} Class = {2} Sem = {3} Branch = {4}",name,roll,classe,sem,branch);
            Console.WriteLine("Marks are: ");
            for (int i = 0; i < 5; i++)
                Console.Write(marks[i]+" ");
        }

    }
}

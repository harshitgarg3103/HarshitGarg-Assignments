using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1
{
    internal class q15  {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER 10 NUMBERS: ");
            int[] marks=new int[10];
            int sum=0 ;
            //double avg =0.0;

           for(int i=0;i<10;i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
                sum += marks[i];
            }
            Console.WriteLine("Sum = {0}", sum);
            float avg = sum / 10;
            Console.WriteLine("Average = {0}", avg);
            for(int i=0;i<10;i++)
            {
                for(int j=i+1;j<10;j++)
                {
                    if (marks[i] > marks[j])
                    {
                        int a = marks[i];
                        marks[i] = marks[j];
                        marks[j] = a;
                    }
                }
            }
            Console.WriteLine("Minimum marks are " + marks[0]);
            Console.WriteLine("Marks in ascending order are:");
            for(int i=0;i<10;i++)
            {
                Console.WriteLine(marks[i]);
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (marks[i] < marks[j])
                    {
                        int a = marks[i];
                        marks[i] = marks[j];
                        marks[j] = a;
                    }
                }
            }
            Console.WriteLine("Maximum marks are " + marks[0]);
            Console.WriteLine("Marks in descending order are:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(marks[i]);
            }

        }
    }
}

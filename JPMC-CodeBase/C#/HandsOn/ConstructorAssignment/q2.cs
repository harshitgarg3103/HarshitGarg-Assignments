using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    internal class q2
    {
    }
    class Building
    {
        public string type,dimension,capacity;
        public int flat;
        public string villa;
        public DateTime completion;
        public Building()
        {
            Console.WriteLine("ENTER flat type: ");
            type = Console.ReadLine();
            Console.WriteLine("ENTER Dimesnion: ");
            dimension = Console.ReadLine();
            Console.WriteLine("ENTER CAPACITY: ");
            capacity = Console.ReadLine();
            if (type == "Flat")
            {
                Console.WriteLine("ENTER Flat number: ");
                flat = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("ENTER VILLA DIMESNION: ");
                villa = Console.ReadLine();
            }
            Console.WriteLine("Enter date of completion: ");
            completion = DateTime.Parse(Console.ReadLine());
        }
        public void showDetails()
        {
            Console.WriteLine("Type= {0} Dimension = {1} Capacity= {2} Flat= {3} Villa= {4} DateOfCompletion= {5}",type,dimension,capacity,flat,villa,completion);
        }
    }
}

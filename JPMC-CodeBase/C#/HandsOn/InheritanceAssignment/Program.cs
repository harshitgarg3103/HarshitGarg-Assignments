namespace InheritanceAssignment
{
    class Furniture
    {
        public int orderId;
        public DateTime orderDate;
        public string type;
        public int q;
        public double amount;
        public string mode;
        public double rate;
        public void getDetails()
        {
            Console.WriteLine("Enter orderId: ");
            orderId = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER ORDER DATE: ");
            orderDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter type (Chair/Cot): ");
            type = Console.ReadLine();
            if (type == "chair")
            {
               Chair c = new Chair();
                c.getDetails();
            }
            else
            {
                Cot ch = new Cot();
                ch.getDetails();
            }
        }
        public void showDetails()
        {
            Console.WriteLine("Order id= {0} Order Date= {1} Type= {2}", orderId, orderDate, type);
            if (type == "chair")
            {
                Chair c = new Chair();
                c.showDetails();
            }
            else
            {
                Cot ch = new Cot();
                ch.showDetails();
            }
        }


    }
    class Chair: Furniture
    {
        public string chairType;
        public string purpose;
        public string color;
        new public void getDetails()
        {
            Console.WriteLine("Enter chairType: ");
            chairType = Console.ReadLine();
            Console.WriteLine("Enter purpose: ");
            purpose = Console.ReadLine();
            Console.WriteLine("Enter color: ");
            color = Console.ReadLine();

            Console.WriteLine("ENTER QUANTITY: ");
            q = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter mode of payment: ");
            mode = Console.ReadLine();
            Console.WriteLine("Enter rate: ");
            rate = double.Parse(Console.ReadLine());
        }
       new public void showDetails()
        {
            amount = (double)q * rate;
            Console.WriteLine("CHAIR TYPE= {0} Purpose= {1} Color= {2} Quantity= {3} Mode= {4} Amount= {5}",chairType,purpose,color,q,mode,amount);

        }
    }
    class Cot: Furniture
    {
        public int capacity;
        public string cotType;
        new public void getDetails()
        {
            Console.WriteLine("Enter cotType: ");
            cotType = Console.ReadLine();
            Console.WriteLine("ENTER CAPACITY: ");
            capacity = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER QUANTITY: ");
            q = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter mode of payment: ");
            mode = Console.ReadLine();

            Console.WriteLine("Enter rate: ");
            rate = double.Parse(Console.ReadLine());
        }
        new public void showDetails()
        {
            amount = q * rate;
            Console.WriteLine("Capacity= {0} Quantity= {1} Mode= {2} Amount= {3}", capacity,q,mode,amount);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Furniture f = new Furniture();
            f.getDetails();
            f.showDetails();
        }
    }
}
namespace Assignment_3
{
    internal class q1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of M: ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value of N: ");
            double n = Convert.ToDouble(Console.ReadLine());
            int counter = 1;
            while (m > 0.0D)
            {
                m = m - 100.0D + m * 0.015D;
                Console.WriteLine("Month: {0} balance: {1} total payments {2}", counter, m, n);
                n += 100;
                counter++;
            }
        }
    }
}
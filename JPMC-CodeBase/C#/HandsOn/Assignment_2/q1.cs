namespace Assignment_2
{
    internal class q1
    {
        static void Main(string[] args)
        {
            int counter = 0;
            double initial = 1000.0D;
            while (initial <= 100000.0D)
            {
                initial = initial + initial * 0.05D;
                counter++;
            }
            Console.WriteLine("THE AMOUNT WILL REACH 100000 in {0} years", counter);
        }
    }
}
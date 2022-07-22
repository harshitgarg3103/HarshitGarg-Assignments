namespace PropertiesAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of books: ");
            int n = int.Parse(Console.ReadLine());
            Book[] b = new Book[n];
            for(int i=0;i<n;i++)
            {
                b[i] = new Book();
                Console.WriteLine("ENTER ISBN: ");
                b[i].ISBN = int.Parse(Console.ReadLine()) ;
                Console.WriteLine("ENTER quantity: ");
                b[i].quantit = int.Parse(Console.ReadLine());
                Console.WriteLine("ENTER BOOKNAME: ");
                b[i].name = Console.ReadLine();
                Console.WriteLine("ENTER TITLE: ");
                b[i].TITLE = Console.ReadLine();
                Console.WriteLine("ENTER AUTHOR: ");
                b[i].AUTHOR = Console.ReadLine();
                Console.WriteLine("ENTER PRICE: ");
                b[i].PRICE = double.Parse(Console.ReadLine());

            }
            for (int i = 0; i < n; i++)
                b[i].display();
        }
    }
}
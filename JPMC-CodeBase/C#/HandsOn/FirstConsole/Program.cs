namespace FirstConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
          string name = Console.ReadLine();
            Console.WriteLine("Hello "+name);
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello {0} your age is {1}", name, age);
            //Console.ReadKey();// freezing the screen
        }
    }
}
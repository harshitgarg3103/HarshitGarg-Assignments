namespace ConstructorAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p=Person.create();
            p.display();
            Building b = new Building();
            b.showDetails();
            Shapes sh = new Shapes();
            Console.WriteLine("Area of Circle is " + sh.calculateArea(sh.radius));
            Console.WriteLine("Area of Triangle is " + sh.calculateArea(sh.height,sh.s));
            Console.WriteLine("Area of Square is " + sh.calculateArea(sh.side));
            Console.WriteLine("Area of Rectangle is " + sh.calculateArea(sh.length,sh.breadth));
        }
    }
}
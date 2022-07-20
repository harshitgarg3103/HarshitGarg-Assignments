namespace ClassAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account ac = new Account();
            ac.accept(46732737,"John","Savings",10000000.0D);
            ac.debit(765375.0D);
            ac.credit(456213.0D);
            ac.show_details();
            Student s=new Student(3040, "John", 5, 2, "CSE");
            s.calculate();
            s.display();
        }
    }
}
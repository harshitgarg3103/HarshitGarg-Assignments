namespace InterfaceAssignment
{
    public interface GovtRules
    {
        public double EmployeePF(double basicSalary);
        public string LeaveDetails();
        public double gratuityAmount(float serviceCompleted, double basicSalary);

    }
    class TCS : GovtRules
    {
        public string empid, name, dept, desg;
        public double basicSalary;
        public TCS(string id,string n,string d,string de,double b)
        {
            empid = id;
            name = n;
            dept = d;
            desg = de;
            basicSalary = b;
        }
        public double EmployeePF(double basicSalary)
        {
            return 0.12D * basicSalary+0.083D*basicSalary;
        }
        public string LeaveDetails()
        {
            return "1 Day of casual Leave per month\n12 Days of Sick Leave per year\n10 days of privilege leave per year";
        }
        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            if (serviceCompleted > 5)
            {
                return basicSalary / 12.0D;
            }
            else if (serviceCompleted > 10)
            {
                return 2 * basicSalary;
            }
            else if (serviceCompleted > 20)
                return 3 * basicSalary;
            else
                return 0.0D;
        }
    }
    class Accenture: GovtRules
    {
        public string empid, name, dept, desg;
        public double basicSalary;
        public Accenture(string id, string n, string d, string de, double b)
        {
            empid = id;
            name = n;
            dept = d;
            desg = de;
            basicSalary = b;
        }
        public double EmployeePF(double basicSalary)
        {
            return 0.12D * basicSalary + 0.12D * basicSalary;
        }
        public string LeaveDetails()
        {
            return "2 Day of casual Leave per month\n5 Days of Sick Leave per year\n5 days of privilege leave per year";
        }
        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            return 0.0D;
        }
    }
    internal class q1
    {
        static void Main(string[] args)
        {
            TCS t = new TCS("E912948","John","Software trainee","CSE",360000);
            Console.WriteLine("The pf of tcs employee is " + t.EmployeePF(t.basicSalary));
            Console.WriteLine("Leave details are " + t.LeaveDetails());
            Console.WriteLine("The gratuity amount of tcs employee is "+t.gratuityAmount(10,t.basicSalary));

            Accenture a = new Accenture("E912940", "John A.", "Software trainee", "ECE", 3600000);
            Console.WriteLine("The pf of Accenture employee is " + a.EmployeePF(a.basicSalary));
            Console.WriteLine("Leave details are " + a.LeaveDetails());
            Console.WriteLine("The gratuity amount of accenture employee is " + a.gratuityAmount(10, a.basicSalary));
        }
    }
}
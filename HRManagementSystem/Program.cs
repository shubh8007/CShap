// See https://aka.ms/new-console-template for more information

using ClassLibrary1;
using Delegate;
using Dispatcher;
using HRManagementSystem;
using System.Xml.Serialization;

Console.WriteLine("Hello, World!");


taxmanager t = new taxmanager();

t.payServiceTax(2000.2);

TaxOperation t1 = new TaxOperation(t.payServiceTax);
TaxOperation t2 = new TaxOperation(t.payProfessionalTax);
TaxOperation t3 = new TaxOperation(t.payIncomeTax);

t1(200000);
t2(50000);
t3(45200);

List<Employee> emplist = new List<Employee>();

bool exit = false;

while (!exit)
{
    Console.WriteLine("Enter your Choice..");
    Console.WriteLine("0.exit,1.add SalesMan,2.add Hr,3.Display All employee");
    {
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter the Salesman Details");
                Console.WriteLine("  target, id, name,  age,  email, phone,  city,  salary,  dept");
                int target = int.Parse(Console.ReadLine());
                int id = int.Parse(Console.ReadLine());
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());
                string email = Console.ReadLine();
                string phone = Console.ReadLine();
                string city = Console.ReadLine();
                string dept = Console.ReadLine();
                double salary = double.Parse(Console.ReadLine());

                Salesman s1 = new Salesman(target, id, name, age, email, phone, city, salary, dept);
                emplist.Add(s1);
                Console.WriteLine("Salesman Added Sucessfully.");
                break;

            case 2:

                Console.WriteLine("enter the hr details...");
                Console.WriteLine("bonus,id,name,age,email,phone,city, salary, dept");
                double bonus = double.Parse(Console.ReadLine());
                int id1 = int.Parse(Console.ReadLine());
                string name1 = Console.ReadLine();
                int age1 = int.Parse(Console.ReadLine());
                string email1 = Console.ReadLine();
                string phone1 = Console.ReadLine();
                string city1 = Console.ReadLine();
                double salary1 = double.Parse(Console.ReadLine());
                string dept1 = Console.ReadLine();
                Hr hr = new Hr(bonus, id1, name1, age1, email1, phone1, city1, salary1, dept1);
                emplist.Add(hr);
                Console.WriteLine("Hr Added Sucessfully");
                break;

            case 3:
                Console.WriteLine("show all employees");
                foreach (var s in emplist)
                {
                    Console.WriteLine(s);
                }
                break;
            case 0:
                exit = true;
                break;

            default:

                Console.WriteLine("Enter the Valid Choice");
                break;
        }
    }
}
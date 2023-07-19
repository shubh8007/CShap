// See https://aka.ms/new-console-template for more information

using BOL;
using DAL;
using DLL;

Console.WriteLine("Jay Shri Ram...");

List<Department> departments=DBManager.GetAllDepartments();

foreach (var dept in departments)
{
    Console.WriteLine(dept.Name+" "+dept.Location);
}

Department d = DBManager.GetDepartment(1);
Console.WriteLine(d.Name+" "+d.Location);


Console.WriteLine("_______________________________");
Department d1 = new Department(2,"Hr","satara");

Console.WriteLine(DBManager.insert(d1));

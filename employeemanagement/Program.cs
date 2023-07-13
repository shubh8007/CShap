using MANG;


//DateTime currentDate=DateTime.Now();
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

DateTime bdate=new DateTime(2001,01,16);
DateTime jDate=new DateTime(2023,02,13);
//string dept,DateTime bDate,string firstName,string lastName,DateTime jdate,double salary,long mobileno
Manager m=new Manager("production",bdate,"shubham","suryawanshi",jDate,420000,8007992007);
Console.WriteLine(m);
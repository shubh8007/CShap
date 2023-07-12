
// See https://aka.ms/new-console-template for more information
using Drawing;
using System.Reflection;
using System.Collections.Generic;
using specification;
using Cust;

Console.WriteLine("Hello, World!");

Drawing.Point startPoint1=new Point(12, 45);
Drawing.Point endPoint1=new Point(75, 23);

Drawing.Point startPoint2=new Point(74, 60);
Drawing.Point endPoint2=new Point(12, 23);

Drawing.Point startPoint3=new Point(63, 60);
Drawing.Point endPoint3=new Point(74, 12);


Drawing.Shape l1=new Drawing.Line(startPoint1,endPoint1,5,"red");
Drawing.Shape l2=new Drawing.Line(startPoint2,endPoint2,5,"black");
Drawing.Shape l3=new Drawing.Line(startPoint3,endPoint3,5,"green");

List<Drawing.Shape> shapes=new List<Drawing.Shape>();

shapes.Add(l1);
shapes.Add(l2);
    shapes.Add(l3);

    foreach (Drawing.Shape s in shapes)
    {
        s.Draw();
    }
//String fname, String lname,String email,String pass,double balance
 Customer c1=new Customer("shubham","Suryawanshi","ss@gmail.com","ss8007",450000);

 IBank customer1=new Customer("shubham","Suryawanshi","ss@gmail.com","ss8007",450000);
 List<IBank> blist=new List<IBank>();

 blist.Add(c1);
foreach(IBank b in blist){
    b.withdraw();
    b.deposite();
    b.transfer ();
}
Console.WriteLine(c1);
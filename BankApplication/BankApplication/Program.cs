

using BankApp;
using Bank;

using System.Collections.Generic;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//string fname,string lname,long accno,long mobno,double balance,string address
AccountHolder accb=new AccountHolder("shubham","suryawanshi",123456,8007992007,500000,"satara");
IBank b1=new AccountHolder("shubham","suryawanshi",123456,8007992007,500000,"satara");

List<IBank> blist=new List<IBank>();
blist.Add(b1);

foreach(IBank b in blist){
 b.deposite();
 b.transfer();
 b.withdraw();  
}
Console.WriteLine(b1);

using Account;
using TaxLibarary;
using CorporatePolicy;



// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Account1 acc = new Account1();
TaxManager tax =new TaxManager();

//event handler
acc.OverBalance += tax.incomeTax;
acc.OverBalance += tax.serviceTax;

acc.balance = 500000;


acc.deposite(12000);
acc.OverBalance -= tax.incomeTax;
acc.deposite(12000);

double balance=acc.balance;
Console.WriteLine(balance);




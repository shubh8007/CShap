namespace BankApp;
using Bank;


public class AccountHolder:IBank{
    private string fname;
    private string lname;
    private long accno;
    private long mobno;
    private double balance;
     private string address;

     public AccountHolder(){
        Console.WriteLine("In AccountHolder Class");
     }

     public AccountHolder(string fname,string lname,long accno,long mobno,double balance,string address){
               this.fname=fname;
               this.lname=lname;
               this.accno=accno;
               this.mobno=mobno;
               this.balance=balance;
               this.address=address;

     }

     public override string  ToString(){
         return string.Format("{0},{1},{2},{3},{4},{5}",fname,lname,accno,mobno,balance,address);
     }


     public void withdraw(){
      Console.WriteLine("Ammount withdraw sucessfully.....");
     }
   
    
    
    
    public void deposite(){
      Console.WriteLine("Ammount deposited Sucessfully.");
     }
    public void transfer(){
      Console.WriteLine("Amount Tranfer Sucessfully...");
     }

}

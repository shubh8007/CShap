
using specification;
namespace Cust;

public class Customer:IBank{
    private String fname;
    private String lname;
    private String email;
    private String pass;
    private double balance;



    public Customer(String fname, String lname,String email,String pass,double balance) {

        this.fname = fname;
        this.lname = lname;
        this.email = email;
        this.pass = pass;
        this.balance = balance;
    }

    public override string ToString()
    {
        return String.Format("{0},{1},{2},{3},{4}",fname,lname,email,pass,balance);
    }
    
void IBank.deposite(){
    Console.WriteLine("Amount deposited sucessfully");

}
void IBank.withdraw() {
     Console.WriteLine("Amount Withdraw sucessfully");
}

void IBank.transfer() {
    Console.WriteLine("Amount transfer Sucessfully");
}
}
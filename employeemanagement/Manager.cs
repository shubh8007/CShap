using EMP;

namespace MANG;

public class Manager:Employee{
    private string dept;
    private DateTime bDate;


    

    public Manager(string dept,DateTime bDate,string firstName,string lastName,DateTime jdate,double salary,long mobileno
    ):base(firstName,lastName,jdate,salary,mobileno){
        this.dept=dept;
        this.bDate=bDate;
    }
    public override string ToString()
    {
       string data= base.ToString();
       return data+ this.dept+" "+this.bDate;
    }



}
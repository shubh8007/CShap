namespace EMP;

public class Employee{
    private string firstName;

    private string lastName;
    private DateTime jdate;
    private double salary;
    private long mobileno;

    public Employee(string firstName,string lastName,DateTime jdate,double salary,long mobileno){
        this.firstName=firstName;
        this.lastName=lastName;
        this.jdate=jdate;
        this.salary=salary;
        this.mobileno=mobileno;
    }

    public string FirstName{
        get{return this.firstName;}
        set{this.firstName=value;}
    }
     public string LastName{
        get{return this.lastName;}
        set{this.lastName=value;}
    }
     public DateTime Jdate{
        get{return this.jdate;}
        set{this.jdate=value;}
    }
    public double Salary{
        get{return this.salary;}
        set{this.salary=value;}
    }
     
public long Mobileno{
        get{return this.mobileno;}
        set{this.mobileno=value;}
    }
    public override string ToString()
    {
       string data=base.ToString();
       Console.WriteLine(data+" ");
       return data+this.firstName+" "+this.lastName+" "+this.jdate+" "+this.salary+" "+this.mobileno;
    }

    
}


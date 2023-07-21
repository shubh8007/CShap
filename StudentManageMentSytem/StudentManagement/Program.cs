using BOL;
using DAL;
// See https://aka.ms/new-console-template for more information


Console.WriteLine("Jay Shri Ram");


bool exit = false;

while (!exit)
{
    Console.WriteLine("0.exit,1.get AllStudent,2.insert student,3.get Student By id,4.delete student by Id");
    int choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            List<Student> list = DBManger.getAllStudents();

            foreach (Student st in list)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine("Student data showed");
            break;
            case 2:
            Console.WriteLine("enter id,name,age,course ,fees,BDate");
            int id=int.Parse(Console.ReadLine());
            string name=Console.ReadLine();
            int age=int.Parse(Console.ReadLine());
            string course=Console.ReadLine();
            double fees= double.Parse(Console.ReadLine());
            DateOnly bDate=DateOnly.Parse(Console.ReadLine());
            Student stud=new Student(id,name,age,course,fees,bDate);
            Console.WriteLine(DBManger.insert(stud));
            Console.WriteLine("Student Added Suceesfully");
                break; 
        case 3:
            Console.WriteLine("get by id");
            Console.WriteLine("Enter id");
            int id1 = int.Parse(Console.ReadLine());
            Student stud1=DBManger.GetStudentbyId(id1);
            Console.WriteLine(stud1);
            break;


            case 4:

            Console.WriteLine("enter id for delete student");
            int id2=int.Parse(Console.ReadLine());
          Console.WriteLine( DBManger.deleteById(id2));
            
            break;

        case 0:

            exit = true;
            break;
    }

}




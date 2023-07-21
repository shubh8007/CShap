namespace BOL
{
    public class Student
    {
        public int id;
        public string name;
        public int age;
        
        public string course;
        public double fees;
        public DateOnly bDate;

        public Student() { }

        public Student(int id, string name, int age,  string course, double fees, DateOnly bDate)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.bDate = bDate;
            this.course = course;
            this.fees = fees;
            this.bDate = bDate;
        }

        public override string ToString()
        {
         return   string.Format("{0},{1},{2},{3},{4},{5}",id,name,age,course,fees,bDate);
        }
    }
}
using BOL;
using MySql.Data.MySqlClient;
namespace DAL
{
    public class DBManger
    {
        public static string coString = @"server=localhost;port=3306;user=root;password=8007992007;database=dotnet";


        public static List<Student> getAllStudents()
        {
            List<Student> students = new List<Student>();
            MySqlConnection con=new MySqlConnection();

            con.ConnectionString=coString;
            string query = "select * from student";
            try
            {
                MySqlCommand cmd=new MySqlCommand(query, con);
                con.Open();
           
                MySqlDataReader reader=cmd.ExecuteReader();
                while(reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    string name = reader["name"].ToString();
                    int age = int.Parse(reader["age"].ToString());
                  
                    string course = reader["course"].ToString();
                    double fees = double.Parse(reader["fees"].ToString());
                    DateOnly bDate = DateOnly.Parse(reader["bDate"].ToString().Substring(0,10));
                    Student student = new Student()
                    {
                        id=id,
                        name=name,
                        age=age,
                     
                        course=course,
                        fees=fees,
                         bDate = bDate,

                    };
                    students.Add(student);
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { 
                con.Close();
            }
            return students;
        }

        public static Student GetStudentbyId(int id)
        {
            Student student = null;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = coString;
            
            try
            {
                string query = "select * from student where id=" + id;
                con.Open();
                MySqlCommand cmd=new MySqlCommand(query, con);  
                
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id1 = int.Parse(reader["id"].ToString());
                  
                    string name = reader["name"].ToString();
                  

                    int age = int.Parse(reader["age"].ToString());
                   
                    string course = reader["course"].ToString();
                  
                    double fees = double.Parse(reader["fees"].ToString());
                    DateOnly bDate = DateOnly.Parse(reader["bDate"].ToString().Substring(0, 10));
                   student = new Student()
                    {
                        id = id1,
                        name = name,
                        age = age,

                        course = course,
                        fees = fees,
                        bDate = bDate,

                    };

                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally {
                con.Close(); 
            }

            return student;
        }


        public static bool insert(Student stud)
        { 
            bool status = false;
            string query = "insert into student(id,name,age,course ,fees,bDate)" +
                "" + "values('" + stud.id + "','" + stud.name + "','" + stud.age + "','" + stud.course + "','" + stud.fees + "','" + stud.bDate +"')";

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString=coString;
            try
            {
                con.Open();
                MySqlCommand cmd=new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                status = true;
            }catch(Exception ex) {
                Console.WriteLine(ex.Message);
                    }
            return status;
        }

        public static bool deleteById(int id)
        
        {
            bool status = false;
         
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString=coString;

            try
            {
                string query = "delete from student where id=" + id;
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                status = true;
            }catch(Exception e)
            {
                Console.WriteLine (e.Message);
            }
            finally { 
                con.Close();
            }    
            return false;
        }
    }
}
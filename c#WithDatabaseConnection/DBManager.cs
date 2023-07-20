using BOL;
using DocumentFormat.OpenXml.Drawing.Charts;
using MySql.Data.MySqlClient;
namespace DAL
{
    public class DBManager
    {
        public static string conString = @"server=localhost;port=3306;user=root;password=8007992007;database=dotnet";

        public static List<Department> GetAllDepartments()
        {
            List<Department> departmentList = new List<Department>();
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = conString;
            string query = "select * from department";
            try
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    int id = int.Parse(reader["id"].ToString());
                    string name = reader["name"].ToString();
                    string location = reader["location"].ToString();
                    Department dept = new Department()
                    {
                       Id = id,
                       Name=name,
                       Location=location

                    };
                    departmentList.Add(dept);




}

            }catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
            }
            finally { 
                con.Close();
            }
            return departmentList;
        }
        public static Department GetDepartment(int id)
        {

            Department dept = null;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = conString;
            string query = "select * from department where id=" + id;
            try
            {
                MySqlCommand cmd=new MySqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                MySqlDataReader reader=cmd.ExecuteReader();
                while (reader.Read())
                {
                    int Id = int.Parse(reader["id"].ToString());
                    string Name = reader["name"].ToString();
                    string Location= reader["location"].ToString();


                    dept = new Department()
                    {
                        Id= id,
                        Name=Name,
                        Location=Location

                    };
                }

            }catch(Exception ee)
            {
                Console.WriteLine (ee.Message);
            }
            finally
            {
                con.Close ();
            }
            return dept;
        }
        public static bool insert(Department dept)
        {
            bool status = false;

            string query="insert into department (id,name,location)"+
                "Values('"+dept.Id+"','" + dept.Name + "','" + dept.Location + "')";

            MySqlConnection con=new MySqlConnection();
            con.ConnectionString = conString; 
            try
            {
                con.Open();
                MySqlCommand con2=new MySqlCommand(query,con);
               
                con2.ExecuteNonQuery();

                status = true;

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
            return status;
        }
        public static bool deleteById(int id)

        {
            bool status = false;


            string query = "delete from department where id=" + id;
            MySqlConnection con=new MySqlConnection();
            con.ConnectionString = conString;
            try
            {
                con.Open();
                MySqlCommand con2= new MySqlCommand(query,con);
                ; con2.ExecuteNonQuery();
                status = true;
            }catch(Exception ee)
            {
                Console.WriteLine (ee.Message);
            }
            finally
            {
                con.Close () ;
            }

                

            return status;
        }
    }
}
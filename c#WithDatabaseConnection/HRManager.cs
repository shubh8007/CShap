using DAL;
using BOL;
using System.Reflection.Metadata.Ecma335;

namespace DLL
{
    public class Hrmanager
    {
        public List<Department> getAllDepartments() { 
         List<Department> allDepartments = new List<Department>();
        allDepartments = DBManager.GetAllDepartments();
        return allDepartments;
            }
    }
    }

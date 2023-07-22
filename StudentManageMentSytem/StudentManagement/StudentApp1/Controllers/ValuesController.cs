using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BOL;
using DAL;
using BLL;
namespace StudentApp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [HttpGet]
        public List<Student>  Getstudent()
        {
            List<Student> list = new List<Student>();

            list = Bll.displayStudent();
            foreach (Student student in list)
            {
                Console.WriteLine(student);
            }
            return list;
           
        }
    }
}

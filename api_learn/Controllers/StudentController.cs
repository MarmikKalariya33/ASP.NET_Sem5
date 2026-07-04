using api_learn.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_learn.Controllers
{
    [Route("api/StudentMaster")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        [Route("getStudentList")]
        [HttpGet]    
        public List<StudentModel> getAllStudents() // getallstudent is method and list<studentmodel> is list of all student
        {
            List<StudentModel> students = new List<StudentModel>(); // Students is variable name and
                                       // new Lis<studentmodel> is create empty list of studentmodel class  

            StudentModel stu1 = new StudentModel()  // Create Student Object 
            {
                stuEmail = "marmik@gmail.com", // All Value Assign In Object 
                stuId = 1,
                StuName = "Marmik",
                stuActive = true
            };
            students.Add(stu1);

            StudentModel stu2 = new StudentModel()
            {
                stuEmail = "yash@gmail.com",
                stuId = 2,
                StuName = "yash",
                stuActive = false
            };
            students.Add(stu2);

            StudentModel stu3 = new StudentModel()
            {
                stuEmail = "pritesh@gmail.com",
                stuId = 3,
                StuName = "pritesh",
                stuActive = true
            };
            students.Add(stu3);
            return students;  // Return the Student List    
        }
    }
}

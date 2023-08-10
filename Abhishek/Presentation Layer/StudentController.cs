using Abhishek.Business_Logic_Layer;
using Abhishek.Data;
using Abhishek.Entities;
using Abhishek.StudentData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Abhishek.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        StudentService _Studentservice = new StudentService();

        [HttpGet]
        public List<Student> GetAllstudents()
        {
            return DataStudent.students;
        }
        [HttpGet("{id}")]


        public Student GetStudent(int rollnumber)
        {
            return _Studentservice.GetStudent(rollnumber);

        }
           [HttpPost]
        public bool Post(Student students)
        {
            
                return _Studentservice.Post(students);

            }
            
        }
    }

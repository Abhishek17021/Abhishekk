using Abhishek.Data;
using Abhishek.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Abhishek.Business_Logic_Layer;

namespace Abhishek.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeService _employeeService = new EmployeeService();
        [HttpGet]
        public ActionResult<List<Employee>> GetAllemployees()
        {
           return(DataEmployee.employees);
        }
        [HttpGet("{id}")]

        public Employee GetEmployee(int id)
        {
            return _employeeService.GetEmployee(id);

        }
        [HttpPost]
        public bool Post(Employee employee)
        {

            return _employeeService.Post(employee);

        }




    }
}
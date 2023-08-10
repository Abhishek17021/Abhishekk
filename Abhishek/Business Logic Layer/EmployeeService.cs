using Abhishek.Data;
using Abhishek.Entities;
using Abhishek.StudentData;

namespace Abhishek.Business_Logic_Layer
{
    public class EmployeeService
    {
        DataEmployee emp = new DataEmployee();

        public Employee GetEmployee(int id)
        {
            if (emp == null)
            {
                throw new Exception("Entered Employee doesnot exist");
            }
            return emp.GetEmployee(id);
        }
        public bool Post(Employee employees)
        {
            return emp.Post(employees);
        }

    }
}

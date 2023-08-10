using Abhishek.Entities;
using Abhishek.StudentData;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Linq;


namespace Abhishek.Data
{
    public class DataEmployee
    {
        public static List<Employee> employees = new List<Employee>()
        {
        new Employee() { Id = 1,Name= "Kavita", Location= "Kolkata"},
        new Employee() { Id = 2,Name= "Piyush", Location="Pune" },
        new Employee() { Id = 3,Name= "Mansi", Location="Hyd" },

     };

        public Employee GetEmployee(int id)
        {
            var employee = employees.Find(x => x.Id == id);

            return employee;


        }

        public bool Post(Employee employees)
        {
            DataEmployee.employees.Add(employees);
            string json = JsonSerializer.Serialize(DataEmployee.employees);
            System.IO.File.WriteAllText(@"C:\Users\parom\source\repos\Abhishek\Abhishek\StudentEntry.json", json);
            return true;

        }
    }
}
       
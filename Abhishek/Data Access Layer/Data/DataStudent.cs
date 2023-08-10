using Abhishek.Controllers;
using Abhishek.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Abhishek.StudentData
{
    public class DataStudent
    {

        public static List<Student> students = new List<Student>()
        {
        new Student() { RollNumber = 1,Name= "Abhishek", Class= "Five"},
        new Student() { RollNumber = 2,Name= "Aman", Class="Seven" },
        new Student() { RollNumber = 3,Name= "Rahul", Class="Three" },
        };

       
        public Student GetStudent(int rollnumber)
        {
            var student = students.Find(x => x.RollNumber == rollnumber);

            return student;


        }

        public bool Post(Student students)
        {
            DataStudent.students.Add(students);
            string json = JsonSerializer.Serialize(DataStudent.students);
            System.IO.File.WriteAllText(@"C:\Users\parom\source\repos\Abhishek\Abhishek\StudentEntry.json", json);
            return true;

        }
    }
}

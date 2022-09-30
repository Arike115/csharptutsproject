using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptutsproject
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }   
        public string Dept { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }


        public static List<Employee> Getallemployee()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee {Id = 1, Name = "Ben", Dept = "IT", Gender = "Male", Salary = 100000 });
            employees.Add(new Employee { Id = 2, Name = "Jude", Dept = "HR", Gender = "Male", Salary = 500000 });
            employees.Add(new Employee { Id = 3, Name = "Tom", Dept = "IT", Gender = "Male", Salary = 50000 });
            employees.Add(new Employee { Id = 4, Name = "Richy", Dept = "IT", Gender = "Male", Salary = 700000 });
            employees.Add(new Employee { Id = 5, Name = "Joy", Dept = "HR", Gender = "Female", Salary = 300000 });
            employees.Add(new Employee { Id = 6, Name = "Carly", Dept = "HR", Gender = "Female", Salary = 70000 });
            employees.Add(new Employee { Id = 7, Name = "John", Dept = "IT", Gender = "Female", Salary = 400000 });
            employees.Add(new Employee { Id = 8, Name = "pam", Dept = "IT", Gender = "Male", Salary = 100000 });
            employees.Add(new Employee { Id = 9, Name = "Stacy", Dept = "HR", Gender = "Male", Salary = 500000 });
            employees.Add(new Employee { Id = 10, Name = "Andy", Dept = "IT", Gender = "Male", Salary = 50000 });
            


            return employees;


        }
    }
}

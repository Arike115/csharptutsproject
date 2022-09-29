using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptutsproject
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }   
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int AnnualSalary { get; set; }


        public static List<Employee> Getallemployee()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { EmployeeId = 101, FirstName = "Ben", LastName = "Roy", Gender = "Male", AnnualSalary = 100000 });
            employees.Add(new Employee { EmployeeId = 102, FirstName = "Jude", LastName = "sam", Gender = "Male", AnnualSalary = 500000 });
            employees.Add(new Employee { EmployeeId = 103, FirstName = "Tom", LastName = "Fred", Gender = "Male", AnnualSalary = 50000 });
            employees.Add(new Employee { EmployeeId = 104, FirstName = "Richy", LastName = "Smith", Gender = "Male", AnnualSalary = 700000 });
            employees.Add(new Employee { EmployeeId = 105, FirstName = "Joy", LastName = "Lawn", Gender = "Female", AnnualSalary = 300000 });
            employees.Add(new Employee { EmployeeId = 106, FirstName = "Carly", LastName = "Vicky", Gender = "Female", AnnualSalary = 70000 });
            employees.Add(new Employee { EmployeeId = 107, FirstName = "Lyla", LastName = "Matt", Gender = "Female", AnnualSalary = 400000 });

            return employees;


        }
    }
}

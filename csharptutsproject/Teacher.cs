using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptutsproject
{
    public class Teacher
    {
        public int Id { get; set; } 
        public string ClassTeacherName { get; set; }
        public double Fees { get; set; }

        public static List<Teacher> GetClasses()
        {
            return new List<Teacher>
            {
                new Teacher{Id = 10,ClassTeacherName = "max", Fees = 100000},
                new Teacher{Id = 8,ClassTeacherName = "ajay", Fees = 80000},
                new Teacher{Id = 6,ClassTeacherName = "geeta", Fees = 60000},
                new Teacher{Id = 4,ClassTeacherName = "rohan", Fees = 40000},
            };

        }
    }
}

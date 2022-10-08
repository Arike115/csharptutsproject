using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptutsproject
{
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int TeacherNo { get; set; }
        public Gender Gender { get; set; }

        public static List<Student> GetStudents()
        {
            return new List<Student> {
               new Student{RollNo = 101, Name ="Grace", Gender = Gender.Male,TeacherNo = 10},
               new Student{RollNo = 102, Name ="Chris", Gender = Gender.Male,TeacherNo = 8},
               new Student{RollNo = 103, Name ="Luise", Gender = Gender.Female,TeacherNo = 10},
               new Student{RollNo = 104, Name ="Ram", Gender = Gender.Male,TeacherNo = 8},
               new Student{RollNo = 105, Name ="Kate", Gender = Gender.Female,TeacherNo = 6},
               new Student{RollNo = 106, Name ="John", Gender = Gender.Male,TeacherNo = 6},
               new Student{RollNo = 107, Name ="Emma", Gender = Gender.Female,TeacherNo = 6},
               new Student{RollNo = 108, Name ="Ravi", Gender = Gender.Male}, 
            };
            
        }
    }

    public enum Gender
    {
        Male,
        Female
    }
}

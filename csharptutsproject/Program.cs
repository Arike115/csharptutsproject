namespace csharptutsproject

{
    //Join == innerJoin
    //Group Join 
    //Left join == left outer join
    //right join  === right outer join
    public class Program
    {
        public static async Task Main()
        {
            var student = Student.GetStudents();
            var teacher = Teacher.GetClasses();

            //////join
            //////querysyntax
            //var data = from s in student
            //           join t in teacher
            //           on s.TeacherNo equals t.Id
            //           select new { s.TeacherNo, s.Name, s.RollNo, t.ClassTeacherName, t.Fees };

            ////Extensionmethod / Basedsyntax
            //var datas = student.Join(teacher,
            //                        y => y.TeacherNo,
            //                        t => t.Id,
            //                        (bt, xl) =>
            //                        new
            //                        {
            //                            bt.TeacherNo,
            //                            bt.Name,
            //                            bt.RollNo,
            //                            xl.ClassTeacherName,
            //                            xl.Fees
            //                        });


            //foreach (var item in datas)
            //{
            //    Console.WriteLine($"StudentName => {item.Name} ---- TeacherName => {item.ClassTeacherName}" +
            //        $" --- id=> {item.RollNo} ----SchoolLevy =>{item.Fees}");
            //}



            ////Left Outer Join or left join
            ////quersyntax

            //var leftdata = from d in teacher
            //               join c in student
            //               on d.Id equals c.TeacherNo into
            //               groupstudent
            //               from g in groupstudent.DefaultIfEmpty()
            //               select new
            //               {
            //                   d.Id,
            //                   d.ClassTeacherName,
            //                   classstudent = g == null ? "no student" : g.Name,
            //                   classnumber = g == null ? 0 : g.RollNo
            //               };

            //foreach (var item in leftdata)
            //{
            //    Console.WriteLine($"name => {item.ClassTeacherName} ---- RollNumber => {item.classnumber}" +
            //        $" --- id=> {item.Id} ----studentName =>{item.classstudent}");
            //}


            //GroupJoin
            //QuerySyntax

            var groupdata = from d in teacher
                            join c in student
                            on d.Id equals c.TeacherNo into Groupstudent
                            select new
                            { 
                                d.Id,
                                d.ClassTeacherName,
                                Groupstudent
                            };

            //basedsyntax

            var newdata = student.GroupJoin(teacher,
                            b => b.TeacherNo,
                            c => c.Id,(bt, groupstudent)
                            => new
                            {
                                bt.Name,
                                bt.TeacherNo,
                                bt.Gender,
                                groupstudent
                            });


            foreach (var item in groupdata)
            {
                Console.WriteLine($"name:{item.ClassTeacherName} ID:{item.Id}");
                foreach(var item2 in item.Groupstudent)
                {
                    Console.WriteLine($"studentname => {item2.Name} ----- RollNo => {item2.RollNo}");
                }
            }

        }








    }
    

}


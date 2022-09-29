#define funkewashere
#undef funkegone
namespace csharptutsproject

{
    public class Program
    {

       //Agregate operators
       //Join Operators 
        public static void Main()
        {
            
            
           var empl = Employee.Getallemployee().Select(emp => new 
           {
               FullName = emp.FirstName + ' '+emp.LastName, monthlYSalary = emp.AnnualSalary/12
           });

            foreach(var em in empl)
            {
                Console.WriteLine("fullname----{0} ----- MonthlySalary ------{1}", em.FullName,em.monthlYSalary);
            }


            var emx = Employee.Getallemployee().SelectMany(ems => ems.Gender.ToCharArray());
            foreach(char em in emx)
            {
                
                Console.WriteLine(em);
            }

          // Console.ReadKey();
        } 

        




    }
    

}


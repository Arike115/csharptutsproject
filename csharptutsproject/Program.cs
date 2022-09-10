namespace csharptutsproject
{
    


    //delegate--- is function pointer
    public class Program
    {
       

        public static void Main()
        {
           List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Id = 101, Name = "Mark"});
            employees.Add(new Employee() { Id = 102, Name = "john" });
            employees.Add(new Employee() { Id = 103, Name = "Mary" });
            employees.Add(new Employee() { Id = 104, Name = "joy" });


            Predicate<Employee> employ = new Predicate<Employee>(findemployee);

            
           Employee em = employees.Find(emp => findemployee(emp));

            Console.WriteLine("Id = {0}, Name = {1}", em.Id, em.Name);

            
        }

        public static bool findemployee(Employee emp)
        {
            
            return emp.Id == 104;
        }


        //public static bool check(UserDetailscs checkuser)
        //{
        //    if(checkuser.Gender == GenderList.Male)
        //    {
        //        Console.WriteLine(checkuser.Age);
        //        return true;

        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}



    }


}


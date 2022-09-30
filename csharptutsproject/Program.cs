namespace csharptutsproject

{
    public class Program
    {

        /// <summary>
       /// Groupby
       /// Ordering Operators
        /// </summary>
        public static void Main()
        {
            //GroupBy
            var empgroups = from employee in Employee.Getallemployee()
                            group employee by employee.Dept;

            var employeegroups = Employee.Getallemployee().GroupBy(employee => employee.Dept);

            foreach(var emp in employeegroups)
            {
                Console.WriteLine("{0} - {1}", emp.Key, emp.Count());
                Console.WriteLine("-------------------");
                foreach(var ep in emp)
                {
                    Console.WriteLine(ep.Name + "\t" + ep.Dept + "\t"+ ep.Salary);
                }
                Console.WriteLine(); Console.WriteLine();
            }

            //ordering operator
            Console.WriteLine("--------Ordering Operators-----------");
            var orderresult = Employee.Getallemployee().OrderByDescending(employee => employee.Name);
            foreach(var order in orderresult)
            {
                Console.WriteLine(order.Name + "\t" + order.Dept + "\t" + order.Salary);
            }
        } 

        




    }
    

}


namespace csharptutsproject

{
    public class Program
    {

        /// <summary>
       /// Element Operators --- first, firstordefault, last,lastordefault, single,singlordefault, elementat
       ///                      elementatdefault,defualtorempty
       /// Quantifier Operators  ----- any, all, contain
       /// Agregate Operators
        /// </summary>
        public static void Main()
        {
            //Element Opertors
            int[] Number = { 1, 2, 3, 4, 5, 6, 7 };
            int result = Number.FirstOrDefault();
            Console.WriteLine(result);

            int[] Numbers = { 4, 5, 6, 7 };
            int results = Numbers.LastOrDefault();
            Console.WriteLine(results);

            int[] Numberse = { 1 };
            int resultse = Numberse.SingleOrDefault();
            Console.WriteLine(resultse);

            string[] words = { "chalk", "pen", "book", "apple" };
            string resultses = words.ElementAt(1);
            Console.WriteLine(resultses);

            int[] Numberses = { 4, 5, 6, 7 };

            var total = Numberses.DefaultIfEmpty();
            foreach (int number in total)
            {
                Console.WriteLine(number);
            }

            //Quantifiers

            int[] figures = { 2, 4, 8, 10, 12 };

            var res = figures.Contains(3);
            Console.WriteLine(res);
            
            var resul = figures.Any(x => x > 12);
            Console.WriteLine(resul);


            var empgroups = from employee in Employee.Getallemployee()
                            group employee by employee.Dept;

            var employeegroups = Employee.Getallemployee().Any(employee => employee.Gender == "Male");
            Console.WriteLine(employeegroups);

            string[] letters = { "cup", "bottle", "mop" };
            var reses = letters.All(x => x == "mop");
            Console.WriteLine(reses);


        }






    }
    

}


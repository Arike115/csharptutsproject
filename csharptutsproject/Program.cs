namespace csharptutsproject

{
    public class Program
    {

        /// <summary>
       /// 
       /// Agregate Operators -----sum,count,longcount,max,min,average
        /// </summary>
        public static void Main()
        {
            var employee = Employee.Getallemployee();

            var sumsalary = employee.Sum(s => s.Salary);

            var avaeragedata = employee.Average(s => s.Salary);

            var maxsalary = employee.Max(s => s.Salary);    

            var minsalary = employee.Min(s => s.Salary);

            var countdata = employee.Count();
            var lountdata = employee.LongCount();

            Console.WriteLine("sum of salary = {0} \nAvg Salary = {1} \nMax Salary = {2} \nMin Salary = {3} \n Count = {4} \n loncount {5}",
                sumsalary,avaeragedata,maxsalary,minsalary,countdata,lountdata);

           







            //string[] Keywords = {
            //"abstract", "add*", "alias*", "as", "ascending*",
            //"async*", "await*", "base","bool", "break",
            //"by*", "byte", "case", "catch", "char", "checked",
            //"class", "const", "continue", "decimal", "default",
            //"delegate", "descending*", "do", "double",
            //"dynamic*", "else", "enum", "event", "equals*",
            //"explicit", "extern", "false", "finally", "fixed",
            //"from*", "float", "for", "foreach", "get*", "global*",
            //"group*", "goto", "if", "implicit", "in", "int",
            //"into*", "interface", "internal", "is", "lock", "long",
            //"join*", "let*", "nameof*", "namespace", "new", "null",
            //"object", "on*", "operator", "orderby*", "out",
            //"override", "params", "partial*", "private", "protected",
            //"public", "readonly", "ref", "remove*", "return", "sbyte",
            //"sealed", "select*", "set*", "short", "sizeof",
            //"stackalloc", "static", "string", "struct", "switch",
            //"this", "throw", "true", "try", "typeof", "uint", "ulong",
            //"unsafe", "ushort", "using", "value*", "var*", "virtual",
            //"unchecked", "void", "volatile", "where*", "while", "yield*"};

            // var selection =
            //    from word in Keywords
            //    where word.Any()
            //    select word;

            //var select = Keywords.Select(x => x.Contains('*'));

            //foreach(var word in selection)
            //{
            //    Console.WriteLine(word);
            //}


           

        }






    }
    

}


namespace csharptutsproject

{

    //asynchronous programming
    public class Program
    {
        public static async Task Main()
        {
            string textfilepath = @"c:\users\Documents\INFO.txt";

            StreamWriter sw = new StreamWriter(textfilepath);

            sw.Write("this is a random ");
            sw.WriteLine("sentence ");
            sw.WriteLine("this is a new word ");
            sw.WriteLine("Hello world");

            sw.Close();


           StreamReader sr = File.OpenText(textfilepath);

            Console.WriteLine("peek:{0}",Convert.ToChar(sr.Peek()));

            Console.WriteLine("readalllines:{0}", sr.ReadLine());

            Console.WriteLine("readall:{0}", sr.ReadToEnd());

            sr.Close();


            //DirectoryInfo dir = new DirectoryInfo(@"c:\users\Documents");

            //Console.WriteLine(dir.FullName);
            //Console.WriteLine(dir.Name);
            //Console.WriteLine(dir.Parent);
            //Console.WriteLine(dir.Attributes);
            //Console.WriteLine(dir.CreationTime);


            //  string[] customers =
            //  {
            //      "bob smith",
            //      "sally smith",
            //      "robert smith",
            //      "joy rob"
            //  };
            //  string textfilepath = @"c:\users\Documents\efd.txt";

            ////  File.WriteAllLines(textfilepath, customers);

            //  foreach (var cust in File.ReadLines(textfilepath))
            //  {
            //      Console.WriteLine(cust);
            //  }

        }

        public static async Task FirstMethod()
        {
            Console.WriteLine("all gone let afresh");
            Console.WriteLine("all gone let start afresh");
        }

        public static async Task secondMethod()
        {
            Console.WriteLine("the past is gone");
        }

    }
    

}


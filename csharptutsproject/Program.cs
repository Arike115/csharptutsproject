namespace csharptutsproject
{

    class Program
    {
        //statements
        //conditional statement
        public static void Main()
        {
            Console.WriteLine("Please enter 1 to 5");
            decimal userschoice = decimal.Parse(Console.ReadLine());

            if(userschoice == 1 || userschoice == 2 || userschoice == 3 || userschoice == 4 || userschoice == 5)
            {
                Console.WriteLine("your choice is {0}", userschoice);
            }
            //else if (userschoice == 2)
            //{
            //    Console.WriteLine("your choice is {0}", userschoice);
            //}
            //else if (userschoice == 3)
            //{
            //    Console.WriteLine("your choice is {0}", userschoice);
            //}
            //else if (userschoice == 4)
            //{
            //    Console.WriteLine("your choice is {0}", userschoice);
            //}
            //else if (userschoice == 5)
            //{
            //    Console.WriteLine("your choice is {0}", userschoice);
            //}
            else
            {

                Console.WriteLine("your choice is {0} is incorrect", userschoice);
            }


        }

      

    }


}


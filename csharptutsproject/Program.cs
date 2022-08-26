namespace csharptutsproject
{

    class Program
    {
        //statements
        //conditional statement
        public static void Main()
        {
            int TotalAmount = 0;

            Start:
            Console.WriteLine("select your choice of bread; 1 .. smallsize, 2.. mediumsize, 3... largesize");
            int userchoice = int.Parse(Console.ReadLine());

            switch (userchoice)
            {
                case 1:
                    TotalAmount += 100;
                    break;
                case 2:
                    TotalAmount += 200;
                    break;
                case 3:
                    TotalAmount += 400;
                    break;
                    default:
                    Console.WriteLine("your choice {0}is invalid", userchoice);
                    goto Start;


            }

            confirm:

            Console.WriteLine("Do you want another bread - Yes or No");
            string userdecision = Console.ReadLine();

            switch (userdecision.ToUpper())
            {
                case "Yes":
                    goto Start;
                case "No":
                    break;
                default:
                    Console.WriteLine("your choice {0}is invalid", userdecision);
                    goto confirm;
            }


            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine("Bill Amount = {0}", TotalAmount);





        }



    }


}


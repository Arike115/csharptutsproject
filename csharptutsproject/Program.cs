namespace csharptutsproject
{

    class Program
    {

        //Assignment Operator =
        //Arithmetic operators +,-,*,/,%
        //comparison operators == -> equalto, != -> notequalto, >, >=,<,<=
        //Conditional Operators &&,||
        //Ternary Operator ?
        public static void Main()
        {
            int b = 10;
            int c = 45;

            bool isb10 = b == 10 ? true:false;

            int d = b == 10 ? 15 : b;

            if(b == 10 || c == 7)
            {
                Console.WriteLine("they are the CORRECT");
            }
            else
            {
                Console.WriteLine("they are not");
            }

            int g = b / c;

            Console.WriteLine(d);   

            Multiplication(24, 67);
           
        }

        public static void Multiplication(int fig, int figs)
        { 
        }

    }


}


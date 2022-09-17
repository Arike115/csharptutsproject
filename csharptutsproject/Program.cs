#define funkewashere
#undef funkegone
namespace csharptutsproject

{
    //operator overloading

    public class Program
    {


        public static void Main()
        {

#if funkewashere
Console.WriteLine("this is where she was");

#else
            Console.WriteLine("this is where she was");
#endif
            Console.WriteLine("this is where she was");
#if funkegone
Console.WriteLine("this is where she was");
#endif
            Console.WriteLine("this is where she was");

            string word = "this is a new store";




            word.ReadMessage();

            "welcome to our store".ReadMessage();

            calculate(56);
            Console.ReadLine();







            int x = 0;

            //int y = v+x;

            var car = new CarClass(2, 12);
            var car2 = new CarClass(4, 8);

            //car.Display();
            var car3 = car * car2;
            car3.Display();


        }
        public static void calculate (int fig)
        {

            Console.WriteLine(fig);
         }

      




    }
    

}


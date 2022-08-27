namespace csharptutsproject
{
    
   public class Program
    {


        public static void Main()
        {
                //    non -static class
                //    CarClass start = new CarClass("Joy Ben", 10);
                //start.Callmethod();

            //static class
            CarClass.Name = "joyben";
            CarClass.Age = 10;
            CarClass.Callmethod();
            
        }



    }


}


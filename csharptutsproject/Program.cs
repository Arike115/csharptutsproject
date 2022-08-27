namespace csharptutsproject
{
    
   public class Program
    {
       

        public static void Main()
        {
               CarPrice carprice = new CarPrice();
            carprice.Name = "BMW";
            carprice.Color = "Black";
            carprice.modelyear = 2021;
            carprice.Callmethod();
            carprice.Amount = 20000000;
            carprice.Amountpaid();
            

            
        }



    }


}


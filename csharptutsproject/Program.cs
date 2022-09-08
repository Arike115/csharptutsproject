namespace csharptutsproject
{
    


    //Enums
    public class Program
    {
       

        public static void Main()
        {
            CarClass carClass = new CarClass();
            carClass.modelyear = modelyearlist.modelyear3030;
            carClass.Callmethod();
            carClass.Fish<int>(5,67);

            CarClass carClass2 = new CarClass();
            carClass2.Fish<string>("ball", "ball");

            UserDetailscs user = new UserDetailscs();
            user.Name = "joy ola";
            user.Age = 40;
            user.Email = "ola34@yahoo.com";
            user.Gender = Genderlist.Male;
            user.GetUserinfor();
            

            
        }



    }


}


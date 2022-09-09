namespace csharptutsproject
{
    


    //delegate--- is function pointer
    public class Program
    {
       

        public static void Main()
        {
            object number = 6.7;
            int[] numbers = { 2, 34, 5, 6, 7, };


            List<UserDetailscs> list = new List<UserDetailscs>();

            list.Add(new UserDetailscs() { Name = "joy", Email = "joy67@gmail.com", Age = 78,Gender = GenderList.Male});
            list.Add(new UserDetailscs() { Name = "Troy", Email = "Troy67@gmail.com", Age = 58,Gender = GenderList.Female});
            list.Add(new UserDetailscs() { Name = "Ben", Email = "ben67@gmail.com", Age = 20,Gender = GenderList.Male });
            list.Add(new UserDetailscs() { Name = "larry", Email = "larry67@gmail.com", Age = 18, Gender = GenderList.Others });
            list.Add(new UserDetailscs() { Name = "flora", Email = "flora67@gmail.com", Age = 30, Gender = GenderList.Female });
            list.Add(new UserDetailscs() { Name = "yan", Email = "yan67@gmail.com", Age = 48, Gender = GenderList.Others });

           // UserListDelegate listDelegate = new UserListDelegate(check);

           // UserDetailscs.getuserdetail(list, listDelegate);

            UserDetailscs.getuserdetail(list, emp => emp.Gender == GenderList.Male);
            


          

            
        }


        //public static bool check(UserDetailscs checkuser)
        //{
        //    if(checkuser.Gender == GenderList.Male)
        //    {
        //        Console.WriteLine(checkuser.Age);
        //        return true;

        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}



    }


}


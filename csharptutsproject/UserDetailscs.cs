using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptutsproject
{
   public delegate bool UserListDelegate(UserDetailscs userlist);
    public enum GenderList
    {
        Female,
        Male,
        Others
    }

   
    
    public class UserDetailscs
    {
        public string Name { get; set; }    
        public string Email { get; set; }   
        public int Age { get; set; }
        public GenderList Gender { get; set; }

        public static void getuserdetail(List<UserDetailscs> users, UserListDelegate userdelagate)
        {
            foreach(UserDetailscs detail in users)
            {
                if(userdelagate(detail))
                {
                    Console.WriteLine(detail.Name + " is older");
                }
            }
        }
    }
}

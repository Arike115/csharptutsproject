using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptutsproject
{
    public enum Genderlist
    { 
        Female,
        Male,
        Others
        

    }

    public class UserDetailscs
    {
        public string Name;
        public string Email;
        public int Age;
        public Genderlist Gender;

       public void GetUserinfor()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Email);
            Console.WriteLine(Age); 
            Console.WriteLine(Gender);
        }
    }
}

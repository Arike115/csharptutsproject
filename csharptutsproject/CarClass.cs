using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptutsproject
{
    //class
    //properties or field ------- data
    //constructor ----- representative of class
    //method/functions -------- behaviour

   public static class CarClass
    {
       public static string Name = "john";
       public static int Age = 90;
        static DateTime CreatedOn = DateTime.Now;
       
        public static void Callmethod()
        {
            Console.WriteLine("my name is {0}, am {1} years old", Name, Age);
            Console.WriteLine("The time is {0}", CreatedOn);
        }


    }
}

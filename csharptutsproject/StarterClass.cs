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

    public class StarterClass
    {
        string Name = "Ben";
        int Age = 25;
        DateTime CreatedOn = DateTime.Now;

        //contructor
        //public StarterClass(string name, int age)
        //{
        //    Name = name;
        //    Age = age;  
        //}

        public void Callmethod()
        {
            Console.WriteLine("my name is {0}, am {1} years old", Name, Age);
            Console.WriteLine("The time is {0}", CreatedOn);
        }





    }
}

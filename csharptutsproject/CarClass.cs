using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptutsproject
{
    public enum modelyearlist
    { 
       modelyear1990,
       modelyear2016,
       modelyear2022,
       modelyear3030,
       modelyear3032,

    }


    //inheritance
    public class CarClass //------> baseclass
    {
       public  string Name;
       public  modelyearlist modelyear;
       public  string Color;
       public  DateTime CreatedOn = DateTime.Now;   //------- field
       
        public  void Callmethod() //--------meth0d
        {
            Console.WriteLine("the car name is {0},{1} model, color {2}", Name, modelyear,Color);
            Console.WriteLine("The time is {0}", CreatedOn);
        }

        public bool Fish<T>( T value1, T value2)
        {
            bool result = value1.Equals(value2);
            Console.WriteLine(result);
            return result;

        }

    }
}

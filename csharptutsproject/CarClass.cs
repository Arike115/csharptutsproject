using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptutsproject
{

    //inheritance
   public class CarClass //------> baseclass
    {
       public  string Name;
       public  int modelyear;
       public  string Color;
       public  DateTime CreatedOn = DateTime.Now;
       
        public  void Callmethod()
        {
            Console.WriteLine("the car name is {0},  {1} model, color {2}", Name, modelyear,Color);
            Console.WriteLine("The time is {0}", CreatedOn);
        }


    }
}

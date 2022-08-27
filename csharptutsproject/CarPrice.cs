using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptutsproject
{
    public class CarPrice : CarClass //derived class
    {
        public  double Amount;
        public void Amountpaid()
        {
            Console.WriteLine(Amount);
        }
    }
}

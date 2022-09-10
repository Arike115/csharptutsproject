using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptutsproject
{
    public abstract class CarPrice 
    {
        public  double Amount;
        public void Amountpaid()
        {
            Console.WriteLine(Amount);
        }

        public void GetStudentDetails()
        {
            throw new NotImplementedException();
        }

        public void GetStudentlist()
        {
            throw new NotImplementedException();
        }

        public void GetTeachersDetails()
        {
            throw new NotImplementedException();
        }

        public void GetTeachersList()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptutsproject
{
    public  interface IStudentDetails : ITeachersDetails
    {
        void GetStudentDetails();
        void GetStudentlist();
    }
}

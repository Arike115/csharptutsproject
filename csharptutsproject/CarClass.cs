using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptutsproject
{
    /// <summary>
    /// carclass is a class use for entering user data
    /// 
    /// </summary>
    public class CarClass //------> baseclass
    {
        /// <summary>
        /// these are properties that are used for my data
        /// </summary>
        public int Id;
        public int grade;

        
        /// <summary>
        /// this constructor is for getting data
        /// </summary>
        /// <param name="id"></param>
        /// <param name="grade"></param>
        public CarClass(int id, int grade)
        {
            this.Id = id;
            this.grade = grade;
        }

        /// <summary>
        /// this method is used to display an item
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Id:" + Id);
            Console.WriteLine("Grade:" + grade);
        }
        #region operator overloading
        /// <summary>
        /// 
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static CarClass operator * (CarClass c1, CarClass c2)
        {
            //if(c1.grade < c2.grade)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            var newclass = new CarClass(c1.Id * c2.Id, c1.grade * c2.grade);
            return newclass;
        }
        #endregion

        //public static bool operator <(CarClass c1, CarClass c2)
        //{
        //    if (c1.grade < c2.grade)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }


}


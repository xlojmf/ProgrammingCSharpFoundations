using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D13_Abstraction
{
    internal class CourseSoftSkills : Course
    {

        #region properties
        internal string Area { get; set; }
        internal override string Classification { get; set; }
        #endregion

        #region constructor
        public CourseSoftSkills() :base()
        {
            Area = "";
            Classification= "";
        }

        public CourseSoftSkills(int courseId, string name, string area, string classfication = "1") : base(courseId, name, classfication)
        {
            Area = area;
            Classification= classfication;
        }

        #endregion

        #region metodos
        // marcar o metdo override na classe derivada para poder substituir o metodo virtual herdado
        internal override void ListCourse()
        {
            Console.WriteLine($"Id: {CourseID}, Name: {Name}, Area: {Area}, Classification: {Classification}");
        }

        internal override void Biling()
        { }


        #endregion


    }
}




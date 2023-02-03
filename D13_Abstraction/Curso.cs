using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D13_Abstraction
{
    internal abstract class Course
    {

        #region properties
        internal int CourseID { get; set; }
        internal string Name { get; set; }
        internal abstract string Classification { get; set; }
        #endregion


        #region constructors

        public Course() 
        { 
            CourseID= 0;
            Name= "";
            Classification = "";
        }

        public Course(int courseID, string name, string classification)
        {
            CourseID = courseID;
            Name = name;
            Classification = classification;
        }



        #endregion

        #region metodos
        // metodo virtual numa classe abstracta para poder ser substituido na classe derivada
        internal virtual void ListCourse()
        {
            Console.WriteLine($"Id: {CourseID}, Name: {Name}");
        }
        // metodo vazio sem implementacao para usar na classe derivada, mostrar intencao
        internal abstract void Biling();

        #endregion
    }


}


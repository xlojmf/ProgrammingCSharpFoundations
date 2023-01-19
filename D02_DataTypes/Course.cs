using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_DataTypes
{
    internal class Course
    {
        #region Properties
        // sintaxe geral de uma propriedade public datatype nomePropriedade { get; set}
        public int CourseID { get; set; } // read and write
        //public int CourseID { get; } // read

        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double DurationInHours { get; set; }

        #endregion

        #region Methods
        internal void Create()
        {

        }
        internal void List()
        {

        }
        #endregion
    }
}

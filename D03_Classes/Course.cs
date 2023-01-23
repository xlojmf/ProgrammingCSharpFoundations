using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03_Classes
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
            Console.WriteLine("Id:");
            CourseID = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Start Date: ");
            StartDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("End Date: ");
            EndDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("DurationInHours:");
            DurationInHours = Convert.ToInt16(Console.ReadLine());

        }
        internal void List()
        {
            Console.WriteLine("Trainee ID\tName\tEmail\tBirthdate");
            Console.WriteLine($"\t{CourseID.ToString()}\t{Name}\t{StartDate.ToShortDateString()}\t{EndDate.ToShortDateString()}\t{DurationInHours.ToString()}\n");
        }
        #endregion
    }
}

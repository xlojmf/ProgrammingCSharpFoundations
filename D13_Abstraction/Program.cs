using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D13_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // nao quero instancia directamente a base classe tornando abstracat
            //Course course= new Course();

            CourseSoftSkills courseSoftSkills = new CourseSoftSkills(1, "GT", "Gestao", "ola");
            CourseSoftSkills courseSoftSkills1 = new CourseSoftSkills(1, "GT", "Gestao","buh");
            CourseSoftSkills courseSoftSkills2 = new CourseSoftSkills(1, "GT", "Gestao");


            courseSoftSkills.ListCourse();
            courseSoftSkills1.ListCourse();
            courseSoftSkills2.ListCourse();
            Console.ReadKey();
        }
    }
}

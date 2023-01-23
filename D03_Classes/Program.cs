using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03_Classes
{

    internal class Program
    {
        private static Trainee trainee;

        static void Main(string[] args)
        {

            /*
             
            Console.WriteLine("\n-------------\nReference Types\n-----------\n");
            Console.WriteLine(course01.CourseID);
            Console.WriteLine(course01.Name);
            Console.WriteLine(course01.StartDate.ToString("yyyy-MM-dd"));
            Console.WriteLine(course01.EndDate.ToString("yyyy-MM-dd"));    
            Console.WriteLine(course01.DurationInHours);
            Console.WriteLine("-------------");
            Console.WriteLine(course02.CourseID);
            Console.WriteLine(course02.Name);
            Console.WriteLine(course02.StartDate.ToString("yyyy-MM-dd"));
            Console.WriteLine(course02.EndDate.ToString("yyyy-MM-dd"));
            Console.WriteLine(course02.DurationInHours);
            
             */

            // aula stuff depois mudar pq do construtor forma mais simples
            //Trainee student = new Trainee();
            // invocar os metodos do obbjecto
            //student.Create();
            //student.ListT();



            // aula stuff depois mudar pq do construtor forma mais simples
            Course curso = new  Course();
            // invocar os metodos do obbjecto
            curso.Create();
            curso.List();


            //my stuff
            /*Trainee trainee1 = new Trainee(1, "José Ferraz", "jmf@xlo.com", new DateTime(1982, 03, 30));
            Trainee trainee2 = Trainee.CreateTrainee();

            Trainee.List(trainee1);
            Trainee.List(trainee2);

            Teste();*/
            Console.ReadKey();
 

        }

        // private static Trainee trainee; // pq de ter q por para usar listas será pq dos publics e afins injeccao de dependecia?

        static void Teste()
        {
            List<Trainee> trainees = new List<Trainee>();
            trainee = Trainee.CreateTrainee();
            trainees.Add(trainee);
            Trainee.ListTrainees(trainees);
        }
    }
}

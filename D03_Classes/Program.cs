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

  
            // aula stuff depois mudar pq do construtor forma mais simples
            Trainee student = new Trainee();
            // invocar os metodos do obbjecto
            student.Create();
            student.ListT();

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

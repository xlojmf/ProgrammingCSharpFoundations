using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_DataTypes
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            #region 1. Declare variables and instanciar objects

            #region Value types

            // Ficam na stack e morrem mal termina o método
            byte idade; // 0 - 255
            float altura;
            double peso;
            bool inscrito; // True/False
            bool pago;
            DateTime data;
            DateTime hora;
            DateTime agora;
            DateTime dataAtual;
            DateTime dataVazia;
            DateTime dataMaxima;

            #endregion

            #region Reference types
            // Ficam na heap e são geridos pela GC (Garbage Collector)
            string nomeCompleto;
            // Create 2 instances
            // sintaexe é NomeClasse nomeObjecto = new NomeClasse()  <-- Constructor

            Course course01 = new Course(); // default constructor
            Course course02 = new Course();

            #endregion

            #endregion

            #region 2. Assign values

            #region Value types
            idade = 10;
            peso = 10.5;
            altura = 1.5F;
            inscrito= false;
            pago = false;

            data = new DateTime(2023,1,20);
            hora = new DateTime(2023,1,20,21,14,00);
            agora = DateTime.Now;
            dataAtual = DateTime.Today;
            dataVazia = DateTime.MinValue;
            dataMaxima = DateTime.MaxValue;
            #endregion

            #region Reference types

            course01.CourseID = 1;
            course01.Name = "SQL Foundations to Advanced";
            course01.StartDate = new DateTime(2022,11,11);
            course01.EndDate = new DateTime(2022, 12, 5);
            course01.DurationInHours = 33;

            course02.CourseID = 2;
            course02.Name = "C# Foundations";
            course02.StartDate = new DateTime(2023, 1, 11);
            course02.EndDate = new DateTime(2023, 1, 26);
            course02.DurationInHours = 30;

            #endregion

            #endregion

            #region 3. Work in console


            #endregion

            #region Values Types
            /*
            Console.WriteLine("\n-------------\nValue Types\n-----------\n");
            Console.WriteLine("Byte - idade" + idade);
            Console.WriteLine("Byte - idade " + Convert.ToString(idade)); // conversão
            Console.WriteLine("Byte - idade " + idade.ToString());

            
            Console.WriteLine("Float - altura" + altura);
            Console.WriteLine("Float - altura" + altura.ToString());
            
            Console.WriteLine("Double - peso" + peso);
            Console.WriteLine("Double - peso" + peso.ToString());

            Console.WriteLine("Boolean - inscrito" + inscrito);
            Console.WriteLine("Boolean - inscrito" + inscrito.ToString());

            Console.WriteLine("Boolean - pago" + pago );
            Console.WriteLine("Boolean - pago" + pago.ToString()); // metodo ToString

            // String interpolation type safe
            Console.WriteLine($"Boolean - { pago }");
            Console.WriteLine($"DateTime date - {data.ToShortDateString()}");
            Console.WriteLine($"DateTime hora - {hora:dd/MM/yyyy}");
            Console.WriteLine($"DateTime hora short - {hora.ToShortTimeString()}");
            Console.WriteLine($"DateTime hora long - {hora.ToLongTimeString()}");
            Console.WriteLine($"DateTime agora - {agora:dd/MM/yyyy}");
            Console.WriteLine($"DateTime data vaziia - {dataVazia:dd/MM/yyyy}");
            Console.WriteLine($"DateTime máxima - {dataMaxima.ToLongDateString()}");



            //format
            Console.WriteLine($"Ano - {agora:yyyy}");
            Console.WriteLine($"Mes - {agora:MM}");
            Console.WriteLine($"Dia - {agora:dd}");
            Console.WriteLine($"Hora - {agora:hh}");
            Console.WriteLine($"Minuto - {agora:mm}");
            Console.WriteLine($"Segundo - {agora:ss}");

            // metodos
            Console.WriteLine($"Ano - {agora.Year}");
            Console.WriteLine($"Mes - {agora.Month}");
            Console.WriteLine($"Dia - {agora.Day}");
            Console.WriteLine($"Hora - {agora.Hour}");
            Console.WriteLine($"Minuto - {agora.Minute}");
            Console.WriteLine($"Segundo - {agora.Second}");

            Console.WriteLine();
            #endregion

            #region Reference Types
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

            #endregion

            Trainee trainee1 = new Trainee(1, "José Ferraz", "jmf@xlo.com", new DateTime(1982, 03, 30));

            Trainee trainee2 = (Trainee)Trainee.CreateTrainee();// o pq de usar o (Trainee antes)
            Trainee.List(trainee1);
            Trainee.List(trainee2);

            // Teste();
            Console.ReadKey();
        }

       // private static Trainee trainee; // pq de ter q por para usar listas será pq dos publics e afins
        static void Teste()
        {
            List<Trainee> trainees = new List<Trainee>();
            Trainee.CreateTrainee();
          //  trainees.Add(trainee);
            Trainee.ListTrainees(trainees);
        }
    }
}

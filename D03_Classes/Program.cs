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

  
            // Aula Instanciar course e student
            Trainee student = new Trainee();
            Course curso = new Course();


            // invocar os metodos do obbjecto
            student.Create();
            student.ListT();
                     
            // invocar os metodos do obbjecto
            curso.Create();
            curso.List();

            // Métodos de instância são chamados através da instância
            // 1.   Criar a instância
            //      Student student00 = new Student();
            // 2.   Chamar o método (Create) através da instância (student00)
            //      student00.Create();
            // Métodos estáticos são chamados diretamente da classe
            // Se a classe for doutro projeto
            // 1.   Fazer uma reference à assembly (.dll)
            //      project > pasta references > botão direito do rato > add reference
            // 2.   Adicionar a namespace
            //      using D00_Utility;
            // 3.   Chamar o método da classe:
            //      Utility.SetUnicodeConsole();
            // Se a classe for da mesma namespace
            // 1.   Chamar o método da classe:
            //      Utility.SetUnicodeConsole();


            //my stuff
            Trainee trainee1 = new Trainee(1, "José Ferraz", "jmf@xlo.com", new DateTime(1982, 03, 30));
            Course course1= new Course(1,"Jose Ferraz", new DateTime(1982, 03, 30) , new DateTime(1982, 03, 30),30);
            
            course1.List();

            Trainee trainee2 = Trainee.CreateTrainee();

            Trainee.List(trainee1);
            Trainee.List(trainee2);

            Teste();
            Console.ReadKey();
 

        }      

        static void Teste()
        {
            List<Trainee> trainees = new List<Trainee>();
            trainee = Trainee.CreateTrainee();
            trainees.Add(trainee);
            Trainee.ListTrainees(trainees);
        }
    }
}

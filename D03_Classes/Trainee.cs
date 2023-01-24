using System;
using System.Collections.Generic;
using System.Globalization;

namespace D03_Classes
{
    internal class Trainee
    {

        #region Properties
        public int TraineeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        #endregion

        #region Constructor

        public Trainee() {
            //construtor defualt
            TraineeId = 0;
            Name = ""; 
            Email = string.Empty;
            BirthDate = DateTime.MinValue;
        }         

        public Trainee(int traineeid, string name, string email, DateTime birthDate) // inicializar o constructor para usar
        {
  
            TraineeId = traineeid;
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
        #endregion


        #region Methods
        //aula stuff
        public void Create() //instance metdo pq nao usa o static, se usar o static posso chamar directo pela classe e nao pela instancia
        {
            Console.WriteLine("Id:");
            TraineeId = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Email: ");
            Email = Console.ReadLine();
            Console.WriteLine("BirthDate: ");
            BirthDate= Convert.ToDateTime(Console.ReadLine());
        }

        public void ListT()
        {
            Console.WriteLine("Trainee ID\tName\tEmail\tBirthdate");
            Console.WriteLine($"\t{TraineeId}\t{Name}\t{Email}\t{BirthDate.ToShortDateString()}\n");
        }


        //my stuff
        internal static Trainee CreateTrainee()
        {
            Console.WriteLine("Enter Trainee ID:");
            int traineeid = int.Parse(Console.ReadLine()); //Convert.ToInt16 o pq de nao funcionar

            Console.WriteLine("Enter Trainee Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Trainee Email:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter Trainee Birthdate (yyyy-MM-dd):");
            //DateTime birthDate = DateTime.Parse(Console.ReadLine()); //perceber como mudar a ordem
            var cultura = new CultureInfo("pt-PT");
            DateTime birthDate = DateTime.Parse(Console.ReadLine(), cultura); // errado nao devemos converter ao atruibir convertemos para mostrar?

            return new Trainee(traineeid, name, email, birthDate); // errado nao devemos instanciar o objecto dentro do metodo
        }

        internal static void List(Trainee trainee)
        {
            Console.WriteLine("Trainee ID\tName\tEmail\tBirthdate");
            Console.WriteLine($"\t{trainee.TraineeId}\t{trainee.Name}\t{trainee.Email}\t{trainee.BirthDate.ToShortDateString()}\n");

        }

        internal static void ListTrainees(List<Trainee> trainees)
        {
            Console.WriteLine("Trainee ID\tName\tEmail\tBirthdate");
            foreach (Trainee trainee in trainees)
            {
                Console.WriteLine($"\t{trainee.TraineeId}\t{trainee.Name}\t{trainee.Email}\t{trainee.BirthDate.ToShortDateString()}\n");
            }
        }
        #endregion

    }

}

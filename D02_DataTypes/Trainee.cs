using System;
using System.Collections.Generic;
using System.Globalization;

namespace D02_DataTypes
{
    internal class Trainee
    {

        public int TraineeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Trainee(int traineeid, string name, string email, DateTime birthDate) // inicializar o constructor para usar
        {
            TraineeId = traineeid;
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

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
            DateTime birthDate = DateTime.Parse(Console.ReadLine(), cultura);

            return new Trainee(traineeid, name, email, birthDate);
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


    }

}

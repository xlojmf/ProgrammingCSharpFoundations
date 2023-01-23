using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace D03_Classes
{
    internal class Trainer
    {
        #region Fields(atributes): privados; variaveis internas da classe e que suportam as propriedades classicas
        private int trainerId;
        private string trainerName;
        private bool ccp;

        #endregion


        #region Properties (publicas e referem as caracterias do objecto)
        // Propriedade Clássica (propfull)
        public int TrainerId {        
            get { return trainerId; } 
            set { trainerId = value; }        
        }
        public string TrainerName { 
            get { return trainerName; }
            set { trainerName = value; }
        }

        //Auto Implemented (Propriedade Automatica): criada com snipet (prop)
        public string Email { get; set; }

        // Bodied Expression: usa o field e um operador(=>)
        public bool Ccp
        {
            get => ccp;
            set => ccp = value;
        }

        #endregion

        #region Constructor

        public Trainer()
        {
            TrainerId = 0;
            TrainerName= string.Empty;
            Email = string.Empty;
            Ccp = false;
        }

        public Trainer(int trainerid, string trainername, string email, bool ccp)
        {
            TrainerId= trainerid;
            TrainerName= trainername;
            Email= email;
            Ccp= ccp;
        }

        #endregion

        #region Methods
        internal void Create()
        {
            Console.WriteLine("Id:");
            TrainerId = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Name: ");
            TrainerName = Console.ReadLine();
            Console.WriteLine("Name: ");
            Email = Console.ReadLine();
            Console.WriteLine("Start Date: ");
            Ccp = Convert.ToBoolean(Console.ReadLine());

        }

        internal void List()
        {
            Console.WriteLine("Course ID\tName\tStart Date\tEnd Date\tDuration");
            Console.WriteLine($"\t{TrainerId}\t{TrainerName}\t{Email}\t{Ccp}\n");
        }

        #endregion

    }


}

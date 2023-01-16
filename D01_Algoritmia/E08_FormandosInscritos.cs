using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E08_FormandosInscritos
    {
        public static void Processar()
        {
           
            int numeroFormandos;
            string nome, curso;
            bool sabeProgramar;

            Console.Write("Nº de formandos a inscrever? ");
            numeroFormandos = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < numeroFormandos; i++)
            {

                Console.WriteLine("\n\n-----------------------\nFormando nº " + Convert.ToString(i + 1) + "\n-----------------------");

                Console.Write("Nome: ");
                nome = Console.ReadLine();

                Console.Write("Sabe programar (true / false)? ");
                sabeProgramar = Convert.ToBoolean(Console.ReadLine());

                if (sabeProgramar)
                {
                    curso = "C# Foundations";
                }
                else
                {
                    curso = "Programming Fundamentals";
                }

                Console.Write("Inscrito no curso: " + curso + "\n\n");

            }
        }
    }
}

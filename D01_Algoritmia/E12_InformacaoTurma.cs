using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E12_InformacaoTurma
    {

        public static void Processar()
        {
            string[,] turma = new string[13, 4];
            for (int i = 0; i < 13; i++)
            {
                string num = LerDadosTurma("Insira número do formando:");
                turma[i, 0] = num;
                string nome = LerDadosTurma("Insira nome do formando:");
                turma[i, 1] = nome;
                string localidade = LerDadosTurma("Insira localidade do formando:");
                turma[i, 2] = localidade;
                string email = LerDadosTurma("Insira email do formando:");
                turma[i, 3] = email;
            }

           EscreverDadosTurma(turma);
        }

        public static string LerDadosTurma(string dados)
        {
            Console.WriteLine(dados);
            return Console.ReadLine();
        }

        public static void EscreverDadosTurma(string[,] turma)

        {
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine("*********************************");
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(turma[i, j]);
                }
            }

        }
    }
}


/*
 
namespace D01_Algoritmia
{

    internal class E12_PreencherListarTurma_Modulos
    {

        internal static void E12_PreencherListarTurma_Modulos_Processar()
        {

            string[,] turma = LerDadosTurma();
            EscreverDadosTurma(turma);

        }

        internal static string[,] LerDadosTurma()
        {

            string[,] turma = new string[3, 4];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Nº: ");
                turma[i, 0] = Console.ReadLine();
                Console.Write("Nome: ");
                turma[i, 1] = Console.ReadLine();
                Console.Write("Localidade: ");
                turma[i, 2] = Console.ReadLine();
                Console.Write("Email: ");
                turma[i, 3] = Console.ReadLine();
                Console.WriteLine();
            }

            return turma;

        }

        internal static void EscreverDadosTurma(string[,] turma)
        {

            Console.WriteLine("\n\n----------------\nTurma\n----------------\n");

            for (int i = 0; i < 3; i++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write(turma[i, c] + "\t");
                }
                Console.WriteLine();
            }

        }

    }

}
 
 
 */
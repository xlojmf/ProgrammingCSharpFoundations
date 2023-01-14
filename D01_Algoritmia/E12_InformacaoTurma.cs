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

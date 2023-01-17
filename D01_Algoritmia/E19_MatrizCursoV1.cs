using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E19_MatrizCursoV1
    {
        // ler e listar os dados de 5 cursos: id nome e area
        internal static void Processar()
        {
            
            EscreverDados(LerDados());

        }


        internal static string[,] LerDados()
        {

            string[,] matriz = new string[5, 3];

            for (int i = 0; i < 5; i++)
            {

                matriz[i, 0] = Read("Insirir ID");
                matriz[i, 1] = Read("Insira Nome");
                matriz[i, 2] = Read("Insira Area");

            }

            return matriz;

        }

        public static string Read(string pedido)
        {
            WriteOperation(pedido);
            return Console.ReadLine();
        }

        public static void WriteOperation(string pedido)
        {
            Console.WriteLine(pedido);
        }

        internal static void EscreverDados(string[,] matriz)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("*********************************");
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(matriz[i, j]);
                }
            }
        }


    }
}

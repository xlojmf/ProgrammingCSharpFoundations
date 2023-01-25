using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D08_DataStructures
{

    class Program
    {

        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            #region Variables
            /*

            // Nomes da turma

            Utility.WriteTitle("VARIÁVEIS");

            string nomeFormando01;
            string nomeFormando02;
            string nomeFormando03;

            Console.Write("Nome do formando 1: ");
            nomeFormando01 = Console.ReadLine();

            Console.Write("Nome do formando 2: ");
            nomeFormando02 = Console.ReadLine();

            Console.Write("Nome do formando 3: ");
            nomeFormando03 = Console.ReadLine();

            Console.WriteLine("\n\nTurma");
            Console.WriteLine(nomeFormando01);
            Console.WriteLine(nomeFormando02);
            Console.WriteLine(nomeFormando03);

            Utility.TerminateConsole();
            */
            #endregion

            #region Array single dimensional (fixo) = Vetor: só 1 coluna
            /*
            // Fixo: dimensão inicial
            Utility.WriteTitle("Array single dimensional (vetor)");

            // 1º declarar e a dimensionar
            string[] nomesTurma = new string[3];

            // 2º atribuir 
            nomesTurma[0] = "a";
            nomesTurma[1] = "b";
            nomesTurma[2] = "c";

            Console.WriteLine("\n\nTurma - elemento a elemento");

            Console.WriteLine(nomesTurma[0]);
            Console.WriteLine(nomesTurma[1]);
            Console.WriteLine(nomesTurma[2]);

            // FOR v1
            Console.WriteLine("\n\nFOR - Turma - com o nº fixo de elementos");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(nomesTurma[i]);
            }

            // FOR v2
            Console.WriteLine("\n\nFOR - Turma - com a dimensão do vetor");

            for (int i = 0; i < nomesTurma.Length; i++)
            {
                Console.WriteLine(nomesTurma[i]);
            }

            // FOREACH
            Console.WriteLine("\n\nFOREACH - Turma");
            foreach (string item in nomesTurma)
            {
                Console.WriteLine(item);
            }

            Utility.TerminateConsole();
            */
            #endregion

            #region Array single dimensional (dinâmico)
            /*
            // Não tem dimensão inicial
            Utility.WriteTitle("Array single dimensional - dynamic");

            // 1º declarar um vetor sem dimensão inicial (zero elementos)
            // string[] localidadesTurma = new string[] { };

            // 2º atribuir indicando a posição

            // localidadesTurma[0] = "a";
            // localidadesTurma[1] = "b";
            // localidadesTurma[2] = "c";

            // 1º declarar e atribuir valores
            string[] localidadesTurma = new string[]
            {
                "a",
                "b",
                "c"
            };

            string[] paisTurma = { "p1", "p2", "p3" };

            // 2º listar
            foreach (string item in localidadesTurma)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (string item in paisTurma)
            {
                Console.WriteLine(item);
            }

            Utility.TerminateConsole();
            */
            #endregion

            #region Array multi dimensional = Matriz: mais do que 1 coluna
            Utility.WriteTitle("Array multi dimensional (matriz)");

            // Dimensionar e atribuir duma só vez
            // Matriz = 3 linhas x 2 colunas: nome, localidade
            string[,] turma = new string[3, 2]
            {
                { "n1", "l1"},      // [0,0], [0,1]
                { "n2", "l2"},      // [1,0], [1,1]
                { "n3", "l3"}       // [2,0], [2,1]
            };

            // Dimensionar e atribuir separadamente 
            string[,] produtos = new string[3, 3];  // nome, cor, preço

            produtos[0, 0] = "Garrafa";
            produtos[0, 1] = "Azul";
            produtos[0, 2] = "10";

            produtos[1, 0] = "Secretária";
            produtos[1, 1] = "Castanha";
            produtos[1, 2] = "100";

            produtos[2, 0] = "Rato";
            produtos[2, 1] = "Cinzento";
            produtos[2, 2] = "1000";

            // Dimensionar dinamicamente e atribuir duma só vez
            string[,] cursos = new string[,]
            {
                { "Curso1", "BD", "aa", "bb", "aaaa"},
                { "Curso2", "LP", "asdsad", "sadsad", "asdda"},
            };

            Utility.TerminateConsole();
            #endregion

        }

    }

}

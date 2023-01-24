using System;
using D00_Utility;

namespace D07_LoopStructures
{

    class Program
    {

        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            #region Variáveis
            string string01 = "";
            string string02 = "x";
            string name = string.Empty;
            #endregion

            #region WHILE
            // Enquanto não garante que seja feito
            Utility.WriteTitle("WHILE");

            while (string01 != "x")
            {
                Console.Write("Para saíres escreve x: ");
                string01 = Console.ReadLine();
            }

            Utility.TerminateConsole();
            #endregion

            #region DO...WHILE
            // Repetir até garante que é feito pelo menos 1 vez
            Utility.WriteTitle("DO...WHILE");

            do
            {
                Console.Write("Para saíres escreve x: ");
                string02 = Console.ReadLine();
            } while (string02 != "x");

            Utility.TerminateConsole();
            #endregion

            #region FOR
            // Repetir x número de vezes
            Utility.WriteTitle("FOR");

            for (int i = 0; i < 3; i++)    // i++    i = i + 1
            {
                Console.WriteLine($"i = {i}");
            }

            Console.WriteLine();

            for (int i = 2; i >= 0; i--)
            {
                Console.WriteLine($"i = {i}");
            }

            Utility.TerminateConsole();
            #endregion

            #region FOREACH
            Utility.WriteTitle("FOREACH");

            // Primeiro ver estruturas de dados: arrays e collections

            /*
            foreach (var item in collection)
            {

            }
            */

            Utility.TerminateConsole();
            #endregion

        }

    }

}

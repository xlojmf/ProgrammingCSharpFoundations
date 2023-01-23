using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_DataConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variaveis
            string string01 = "1";
            int int01 = 10;
            int int02 = 20;
            long long01 = 2000000;
            float float01 = 3.8F;
            double double01 = 10.5;
            #endregion

            #region Sem Conversão
            Console.WriteLine(string01 + int01);
            #endregion

            #region Conversão Implicita
            Console.WriteLine(int01 + long01); //numericos sao compativeis, e se são compativeis tem conversao implicita
            Console.WriteLine(float01 + double01);
            #endregion

            #region Conversao Explicita
            // Método ToString(): data type extension method --> converter para string
            // Classe Convert: converter diferentes tipos de dados
            // Método Parse(): converter string em número
            // Método TryParse(): converter string em número
            // Operator Cast: converter números em outros números (edited)
            #endregion

            #region
            #endregion

            Console.ReadKey();
            
        }
    }
}

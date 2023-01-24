using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace D04_DataConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            #region Variaveis
            string string01 = "1";
            string string02 = "a";
            int int01 = 10;
            int int02 = 20;
            long long01 = 2000000;
            float float01 = 3.8F;
            double double01 = 10.5;

            bool sucessInt = false;
            bool sucessLong = false;
            bool sucessFloat = false;
            bool sucessDouble = false;
            int resultInt = 0;
            float resultFloat = 0F;
            double resultDouble = 0;
            long resultLong = 000000000000000000;
            #endregion

            #region Sem Conversão
            Console.WriteLine(string01 + int01);
            #endregion

            #region Conversão Implicita
            Console.WriteLine(int01 + long01); //numericos sao compativeis, e se são compativeis tem conversao implicita
            Console.WriteLine(float01 + double01);
            #endregion

            #region Conversao Explicita

            Console.WriteLine();
            // Classe Convert: converter diferentes tipos de dados
            Console.WriteLine(Convert.ToInt16(string01) + int02);
            //Console.WriteLine(Convert.ToInt16(string02) + int02);

            Console.WriteLine();
            // Método ToString(): data type extension method --> converter para string
            Console.WriteLine(string01 + int02.ToString());
            Console.WriteLine(string01 + long01.ToString());
            Console.WriteLine(string01 + float01.ToString());

            Console.WriteLine();
            // Método Parse(): converter string em número
            Console.WriteLine(int01 + int.Parse(string01));
            Console.WriteLine(long01 + long.Parse(string01));
            Console.WriteLine(float01 + float.Parse(string01));
            Console.WriteLine(double01 + double.Parse(string01));


            Console.WriteLine();
            // Método TryParse(): converter string em número
            sucessInt = int.TryParse(string01, out resultInt);
            sucessFloat = float.TryParse(string01, out resultFloat);
            sucessDouble = double.TryParse(string01, out resultDouble);
            sucessLong = long.TryParse(string01, out resultLong);

            Console.WriteLine($"{sucessInt}, {resultInt}");
            Console.WriteLine($"{sucessFloat}, {resultFloat}");
            Console.WriteLine($"{sucessDouble}, {resultDouble}");
            Console.WriteLine($"{sucessLong}, {resultLong}");


            // Operator Cast: converter números em outros números (edited) do mais pequeno intervalo para o maior sempre para fazer cast's
            Console.WriteLine((long)int01 + long01);
            Console.WriteLine((double)float01 + double01);
            // Console.WriteLine((int)string01 + int01); nao se pode usar cast em strings

            #endregion

            #region
            #endregion

            Utility.TerminateConsole();
            
        }
    }
}

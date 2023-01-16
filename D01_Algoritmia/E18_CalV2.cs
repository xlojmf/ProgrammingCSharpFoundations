using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E17_CalV2
    {
        internal static void Processar()
        {
            double num1 = ReadNumber("Insira o primeiro número");
            double num2 = ReadNumber("Insira o segundo número");
            WriteOperation(Soma(num1, num2));
            WriteOperation(Subtracao(num1, num2));
            WriteOperation(Multiplicacao(num1, num2));
            WriteOperation(Divisao(num1, num2));

            // array para listar todos os resultados
        }

        internal static double ReadNumber(string pedido)
        {
            WriteOperation(pedido);
            return Convert.ToDouble(Console.ReadLine());
        }
        internal static string Soma(double num1, double num2)
        {
            string result = ("O resultado da soma é " + Convert.ToString(num1 + num2));
            return result;
        }

        internal static string Subtracao(double num1, double num2)
        {
            string result = ("O resultado da subtração é " + Convert.ToString(num1 - num2));
            return result;
        }

        internal static string Multiplicacao(double num1, double num2)
        {
            string result = ("O resultado da multiplicação é " + Convert.ToString(num1 * num2));
            return result;

        }

        internal static string Divisao(double num1, double num2)
        {
            string result = ("O resultado da divisão é " + Convert.ToString(num1 / num2));
            return result;

        }

        internal static void WriteOperation(string pedido)
        {
            Console.WriteLine(pedido);
        }

    }
}
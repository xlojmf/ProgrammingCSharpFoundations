using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    public class E15_SomaNumeros
    {
        public static void Processar()
        {
            double num1 = ReadNumber("Insira o primeiro número: ");
            double num2 = ReadNumber("Insira o segundo número: ");

            double result = Soma(num1, num2);

            MostraSoma(num1, num2, result);
        }

        internal static double ReadNumber(string numero)
        {
            Console.WriteLine(numero);
            return Convert.ToDouble(Console.ReadLine());
        }

        internal static double Soma(double num1,double num2) 
        {
            double result = num1 + num2;
            return result;
        }
        internal static void MostraSoma(double num1, double num2, double result)
        {
            Console.WriteLine("A soma do número " + Convert.ToString(num1) + "com o número " + Convert.ToString(num2) +" dá o resultado de " + Convert.ToString(result));
        }

    }
}

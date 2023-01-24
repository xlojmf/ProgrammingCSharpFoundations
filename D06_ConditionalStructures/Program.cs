using System;
using D00_Utility;

namespace D06_ConditionalStructures
{

    class Program
    {

        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            #region Variáveis
            int numero = 0;
            int valor01 = 1;
            int valor02 = 2;
            bool resultado = true;
            #endregion

            #region IF SIMPLES
            // D00_Utility.Utility.WriteTitle("IF SIMPLES");
            Utility.WriteTitle("IF SIMPLES");

            if (numero == 0)
                Console.WriteLine("O número é 0.");

            if (numero == 10)
            {
                Console.WriteLine("O número é 10.");
            }

            Utility.TerminateConsole();
            #endregion

            #region IF...ELSE
            Utility.WriteTitle("IF...ELSE");

            if (numero == 100)
            {
                Console.WriteLine("O número é 100.");
            }
            else
            {
                Console.WriteLine("O número é diferente de 100.");
            }

            Utility.TerminateConsole();
            #endregion

            #region OPERADOR TERNÁRIO
            Utility.WriteTitle("OPERADOR TERNÁRIO");

            // Desafio: ver se os dois valores são iguais

            // Versão clássica com IF...ELSE
            /*
            if (valor01 == valor02)
            {
                Console.WriteLine("Os valores são iguais.");
            }
            else
            {
                Console.WriteLine("Os valores não são iguais.");
            }
            */

            /*
            if (valor01 == valor02)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            */

            // Versão com o operador ternário
            resultado = valor01 == valor02 ? true : false;

            Console.WriteLine(resultado);

            Utility.TerminateConsole();
            #endregion

            #region IFS ENCADEADOS
            // Ver se o numero é 0, 10, 15 e dar uma mensagem

            Utility.WriteTitle("IFS ENCADEADOS");

            if (numero == 0)
            {
                Console.WriteLine("O número é 0.");
            }
            else
            {
                if (numero == 10)
                {
                    Console.WriteLine("O número é 10.");
                }
                else
                {
                    if (numero == 15)
                    {
                        Console.WriteLine("O número é 15.");
                    }
                    else
                    {
                        Console.WriteLine("O número não é 0, nem 10, nem 15.");
                    }
                }
            }

            Utility.TerminateConsole();
            #endregion

            #region IF...ELSEIF
            // Ver se o numero é 0, 10, 15 e dar uma mensagem

            Utility.WriteTitle("IF...ELSEIF");

            if (numero == 0)
            {
                Console.WriteLine("O número é 0.");
            }
            else if (numero == 10)
            {
                Console.WriteLine("O número é 10.");
            }
            else if (numero == 15)
            {
                Console.WriteLine("O número é 15.");
            }
            else if (numero > 20)
            {
                Console.WriteLine("O número é maior que 20.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("O número é inferior a 0.");
            }
            else if (numero != 0)
            {
                Console.WriteLine("O número é diferente de 0.");
            }
            else
            {
                Console.WriteLine("O número não é 0, nem 10, nem 15.");
            }

            Utility.TerminateConsole();
            #endregion

            #region SWITCH
            // Ver se o numero é 0, 10, 15 e dar uma mensagem

            Utility.WriteTitle("SWITCH");

            switch (numero)
            {
                case 0:
                    Console.WriteLine("O número é 0.");
                    break;
                case 10:
                    Console.WriteLine("O número é 10.");
                    break;
                case 15:
                    Console.WriteLine("O número é 15.");
                    break;
                default:            // é o correspondente ELSE
                    Console.WriteLine("O número não é 0, nem 10, nem 15.");
                    break;
            }

            Utility.TerminateConsole();
            #endregion

        }

    }

}

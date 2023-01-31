using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace D10_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            Utility.WriteTitle("Error Handling");

            try
            {
                int numero;
                Console.WriteLine("Escreve numero");
                numero= Convert.ToInt16(Console.ReadLine());
                Console.WriteLine(numero);

                Console.WriteLine(numero/0);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("não se pode dividir por 0 amigos!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("argumento mal");
            }
            catch (FormatException)
            {
                Console.WriteLine("formato mal");
            }

            catch (Exception)
            {
                Console.WriteLine("aconteceu erro");
                throw;
            }
            // pudemos ou nao usar
            finally
            {
                Console.WriteLine("vou terminar");
            }

            Utility.TerminateConsole();

        }
    }
}

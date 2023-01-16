using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E13_Saudar
    {
        internal static void Processar()
        {
            string texto = LerNome();
            EscreverNome(texto);
        }

        internal static string LerNome()
        {
            Console.WriteLine("Qual é o seu nome");
            return Console.ReadLine();
        }

        internal static void EscreverNome(string texto)
        {
            
            Console.WriteLine("Olá " + texto);
        }

    }
}

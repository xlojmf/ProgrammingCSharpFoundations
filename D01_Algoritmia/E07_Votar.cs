using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E07_Votar
    {
        internal static void Processar()
        {
            int idade;
            string mensagem;

            Console.WriteLine("Introduza um número");
            idade = Convert.ToInt16(Console.ReadLine());

            if (idade >= 18)
            {
                mensagem = "O cidadão pode votar";
            }
            else
            {
                mensagem = "O cidadão não pode votar";
            }

            Console.WriteLine(mensagem);
        }
    }
}

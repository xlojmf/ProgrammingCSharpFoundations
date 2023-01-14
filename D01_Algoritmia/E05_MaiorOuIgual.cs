using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E05_MaiorOuIgual
    {
        internal static void Processar() 
        {
            int numero1, numero2;
            string comparacao;
            Console.WriteLine("Introduza um número");
            numero1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Introduza um número");
            numero2 = Convert.ToInt16(Console.ReadLine());
            if (numero1 > numero2)
            {
                comparacao = "O primeiro numero é o maior";
            }
            else if (numero1 == numero2)
            {
                comparacao = "Os numeros são iguais";
            }
            else
            {
                comparacao = "O segundo numero é o maior";
            }
            Console.WriteLine(comparacao);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E16_SomaDoisNumerosDiferentesZero
    {
        // Calcular a soma de 2 números se forem ambos diferentes de zero.
        internal static void Processar()
        {
            int numero1, numero2, soma;
            Console.WriteLine("Introduza um número");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduza um número");
            numero2 = Convert.ToInt32(Console.ReadLine());
            if (numero1 != 0 && numero2 != 0)
            {
                soma = numero1 + numero2;
                Console.WriteLine("A soma dos numeros é "+Convert.ToString(soma));
            }
            else
            {
                Console.WriteLine("Um dos numeros inseridos é 0");
            }

        }
    }
}

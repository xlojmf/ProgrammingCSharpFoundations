using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E09_SomarEnquantoPar
    {
        internal static void Processar()
        {
            int x, y, soma;

            Console.WriteLine("Introduza um número");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduza um número");
            y = Convert.ToInt32(Console.ReadLine());

            do
            {
                soma = x + y;
                Console.WriteLine("A soma dos numeros é " + Convert.ToString(soma));

                Console.WriteLine("Introduza um número");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduza um número");
                y = Convert.ToInt32(Console.ReadLine());

            } while (x % 2 == 0 && y % 2 == 0);

            Console.WriteLine("um dos numeros não é par");

        }
    }
}

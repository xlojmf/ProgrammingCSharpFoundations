using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E04_MaiorDoisNumeros
    {
        // Ler dois números e dizer qual o maior
        internal static void Processar()
        {
            int x, y, numeroMaior;
            Console.WriteLine("Introduza um número");
            x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Introduza um número");
            y = Convert.ToInt16(Console.ReadLine());
            if (x > y)
            {
                numeroMaior= x;              
            }
            else
            {
                numeroMaior= y;
            }
            Console.WriteLine("O valor maior é " + Convert.ToString(numeroMaior));
        }
    }
}

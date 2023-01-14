using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    // Calcular o preço final de um produto mediante o preço a percentagem de desconto
    internal class E02_ProdutoPrecoFinal
    {
        internal static void Processar()
        {
            double precoInicial, taxaDesconto, valorDesconto, precoFinal;
            Console.WriteLine("Introduza o preço inicial");
            precoInicial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduza a taxa de desconto");
            taxaDesconto = Convert.ToDouble (Console.ReadLine());

            valorDesconto = (precoInicial * (taxaDesconto / 100));
            precoFinal = precoInicial - valorDesconto;

            Console.WriteLine($"O preço final é {Convert.ToString(precoFinal)}");
        }
    }
}

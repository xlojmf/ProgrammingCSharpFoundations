using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E03_AumentoVencimento
    {
        internal static void Processar()
        {
        // Calcular  20% aumento no vencimento Salario Final ← Salario * 1.2 
       
        double vencimento, vencimentoFinal;
        const double taxaAumento = 0.2;
        Console.WriteLine("Introduza o vencimento");
        vencimento = Convert.ToDouble(Console.ReadLine());
        vencimentoFinal = vencimento + (vencimento * taxaAumento);
        Console.WriteLine("O seu novo vencimento é " +Convert.ToString(vencimentoFinal));
        }
    }
}

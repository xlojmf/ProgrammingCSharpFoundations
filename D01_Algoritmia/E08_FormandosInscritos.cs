using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E08_FormandosInscritos
    {
        public static void Processar()
        {
            int inscritos;
            
            Console.WriteLine("Introduza um número");
            inscritos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Número total de inscritos" + Convert.ToString(inscritos));
        }
    }
}

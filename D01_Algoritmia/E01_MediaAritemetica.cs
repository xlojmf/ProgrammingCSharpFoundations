using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E01_MediaAritemetica
    {
        // E01. Média Aritemtica de dois valores  
        internal static void Processar()
        {
            double x, y, media;

            Console.WriteLine("Introduza um número");
            x =Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduza um número");
            y = Convert.ToDouble(Console.ReadLine());

            media = (x + y) / 2;
            Console.WriteLine("Média " + Convert.ToString(media));
    
        }
    }
}

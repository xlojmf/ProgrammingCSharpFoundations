using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E10_VetorMultiplicadoPorDois
    {
        internal static void Processar() 
        {
            /*
            int[] vector = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = vector[i] * 2;
                Console.WriteLine(vector[i]);
            }
            */
            int[] vector = new int[10];
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = i+1;
             }
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = vector[i] * 2;
                Console.WriteLine(vector[i]);
            }
        }
    }
}

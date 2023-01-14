using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E06_NomeMes
    {
        internal static void Processar()
        {
            int mes;
            string nomeMes;
            Console.WriteLine("Introduza um número");
            mes = Convert.ToInt32(Console.ReadLine());

            switch(mes){
                case 1:
                    nomeMes = "Janeiro";
                    break;
                case 2:
                    nomeMes = "Fevereiro";
                    break;
                case 3:
                    nomeMes = "Março";
                    break;
                case 4:
                    nomeMes = "Abril";
                    break;
                case 5:
                    nomeMes = "Maio";
                    break;
                case 6:
                    nomeMes = "Junho";
                    break;
                case 7:
                    nomeMes = "Julho";
                    break;
                case 8:
                    nomeMes = "Agosto";
                    break;
                case 9:
                    nomeMes = "Setembro";
                    break;
                case 10:
                    nomeMes = "Outubro";
                    break;
                case 11:
                    nomeMes = "Novembro";
                    break;
                case 12:
                    nomeMes = "Dezembro";
                    break;
                default:
                    nomeMes = "Esse numero não corresponde a um mês do ano!";
                    break;
                    
            }
            Console.WriteLine("O nome do mes é " + nomeMes);
        }
    }
}

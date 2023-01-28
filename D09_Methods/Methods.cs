using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace D09_Methods
{
    internal class Methods
    {
        #region  void ou procedure (procedimento) : não devolve valor
        internal void Procedure()
        {
            Console.WriteLine("void ou procedure (procedimento) : não devolve valor");
        }
        #endregion


        #region No void ou procedure (procedimento) : devolve valor com return
        internal string Function()
        {
            string text = "No void ou procedure (procedimento) : devolve valor com return";
            return text;
        }
        #endregion


        #region Method with void with mandatory parameters

        internal void MethodMandatoryParameters(string text01, string text02)
        {
            Console.WriteLine($"Resultado: {text01}, {text02}");
            Console.WriteLine("Resultado: {0}, {1}", text01, text02);
        }

        #endregion


        #region Method with void with optional parameters
        internal void MethodOptionalParameters(string buh, string name = "José")
        {
            Console.WriteLine(buh, name);
        }
        #endregion


        #region method with parameters by value (default para dados nativos)
        internal void PassingValueToMethod(string text)
        {
            text = "2. Text Alterado por valor";
            Console.WriteLine($"Valor dentro do metodo {text}");

        }
        #endregion


        #region method with parameters by reference (default para dados object)
        internal void PassingReferenceToMethod(ref string message)
        {
            message = "2. Text Alterado por referencia";
            Console.WriteLine($"Valor dentro do metodo {message}");
        }
        #endregion


        #region instance method
        internal void InstancePrint(string text)
        {
            Console.WriteLine(text);
        }
        #endregion


        #region static method
        internal static void StaticPrint(string text)
        {
            Console.WriteLine(text);
        }
        #endregion


    }
}

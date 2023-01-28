using D00_Utility;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D09_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            // 1 instanciar a classe para ter acesso aos seus metodos pq sao de instancia e não estaticos
            Methods methods= new Methods();
            methods.Procedure();
            //v1
            string messsage= methods.Function();
            Console.WriteLine(messsage);
            //v2
            Console.WriteLine(methods.Function());

            // parametros obrigatorios
            methods.MethodMandatoryParameters("buh","buh2");

            // parametros opcionais, opcional sempre no ultimo campo
            methods.MethodOptionalParameters("jj");
            methods.MethodOptionalParameters("jj","kk");

            // mehtod por valor
            string text = "1 texto Original";
            Console.WriteLine(text);
            methods.PassingValueToMethod(text);
            Console.WriteLine(text);

            //metodo por referencia
            string reference = "Original";
            Console.WriteLine($"1. texto antes de mudar o valor dar variavel {reference}");
            methods.PassingReferenceToMethod(ref reference);

            //method por instancia
            methods.InstancePrint("instancia");
            //metodo estatico
            Methods.StaticPrint("static");

            Utility.TerminateConsole();
        }
    }
}

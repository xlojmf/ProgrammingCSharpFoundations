using System;
using System.Text;

namespace D05_DataTypesManipulation
{

    class Program
    {
    
        static void Main(string[] args)
        {

            #region Variáveis e objetos
            
            // Strings
            string area = "Informática";
            string categoria = "Linguagens de programação";
            string curso = "C# Foundations";
            string cursoCompleto00;
            string cursoCompleto01;
            string cursoCompleto02;
            string cursoCompleto03;
            StringBuilder cursoCompleto04 = new StringBuilder();
            
            // Numbers
            int valor01 = 10;
            int valor02 = 100;
            double valor03 = 2.3;
            double valor04 = -12.1;
            double valor05 = 64;    // Não é int porque a Sqrt() pede 1 double
            int testeSqrt;
            testeSqrt = (int)Math.Sqrt(4);  // Cast

            // Datetime
            DateTime timestamp = DateTime.Now;

            #endregion

            #region Manipulação de strings

            // Clássico
            cursoCompleto00 = area + ", " + categoria + ", " + curso;   // Evitar usar e substituir por outro método
            cursoCompleto01 = $"{area}, {categoria}, {curso}";
            cursoCompleto02 = string.Join(", ", area, categoria, curso);

            // StringBuilder
            cursoCompleto03 = string.Concat(area, " - ", categoria, ", ", curso);
            cursoCompleto04.Append(area);
            cursoCompleto04.Append("\t");
            cursoCompleto04.Append(categoria);
            cursoCompleto04.Append("\t");
            cursoCompleto04.Append(curso);

            // Maiúsculas, minúsculas, 1ª palavra do curso, curso completo
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("MANIPULAÇÃO DE STRINGS");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Maiúsculas: {cursoCompleto01.ToUpper()}");
            Console.WriteLine($"Minúsculas: {cursoCompleto02.ToLower()}");
            Console.WriteLine($"1ª parte do curso (fixo): {cursoCompleto03.Substring(0, 11)}");  // Informática
            Console.WriteLine($"1ª parte do curso (dinâmico): {cursoCompleto02.Substring(0, cursoCompleto02.IndexOf(","))}");
            Console.WriteLine($"Curso: {cursoCompleto04}");

            Console.ReadKey();
            Console.Clear();

            #endregion

            #region Manipulação numbers
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("MANIPULAÇÃO DE NUMBERS");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Mínimo: {Math.Min(valor01, valor02)}");
            Console.WriteLine($"Máximo: {Math.Max(valor01, valor02)}");
            Console.WriteLine($"Absoluto: {Math.Abs(valor04)}");
            Console.WriteLine($"Arrendondamento: {Math.Round(valor03)}");
            Console.WriteLine($"Raíz quadrada: {Math.Sqrt(valor05)}");
            Console.WriteLine($"Raíz quadrada: {testeSqrt}");

            Console.ReadKey();
            Console.Clear();

            #endregion

            #region Manipulação datetime
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("MANIPULAÇÃO DE DATETIME");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Hora atual + 10 minutos (v1): {timestamp.AddMinutes(10).Minute}");
            Console.WriteLine($"Hora atual + 10 minutos (v2): {timestamp.AddMinutes(10).ToString("mm")}");
            Console.WriteLine($"Próxima hora: {timestamp.AddHours(1).Hour}");
            #region Semestre e Trimestre
            Console.WriteLine($"Trimestre: {(timestamp.Month + 2) / 3}");
            #endregion
            #endregion

            Console.ReadKey();

        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace E01_Calculator_V1
{
    internal class Util
    {

        internal static void DesignMenu()
        {
            // Design the user menu
            CenterDashWriteLine("Calculator Menu:");
            Console.WriteLine("\n1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("0. Quit\n");
        }



        internal static void Clear()
        {
            // Clear screen after 5 seconds
            Thread.Sleep(5000);
            Console.Clear();
        }

        internal static void CenterDashWriteLine(string text)
        {
            // Determine the center of the console window
            int center = Console.WindowWidth / 2;

            // Create a line of dashes
            string dashes = new string('-', (Console.WindowWidth - text.Length) / 2 - 2);

            // Write the text surrounded by dashes
            Console.Write(dashes);
            Console.Write(text);
            Console.WriteLine(dashes);
        }

    }


}

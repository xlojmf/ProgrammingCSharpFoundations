using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace E01_CalculatorInterface.Classes
{
    internal class Utils
    {
       

        internal static void DesignMenu()
        {
            string[] menuOptions = { "1. Addition", "2. Subtraction", "3. Multiplication", "4. Division", "0. Quit" };
            CenterDashWriteLine("Calculator Menu");
            Console.WriteLine();
            foreach (var menuOption in menuOptions)
            {
                Console.WriteLine(menuOption);
            }
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

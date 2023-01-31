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
        public int Choice { get; set; }
        internal static void DesignMenu1()
        {
            // Design the user menu
            CenterDashWriteLine("Calculator Menu:");
            Console.WriteLine("\n1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("0. Quit\n");
        }

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

        internal void GetMenuNumber()
        {
            int choice;
            int[] menuOptions = { 0, 1, 2, 3, 4 };

            Console.Write("Enter your choice: ");
            while (!int.TryParse(Console.ReadLine(), out choice) || !menuOptions.Contains(choice))
            {
                Console.WriteLine("Invalid input. Please choose a valid option (0-4)");
                Console.Write("Enter your choice: ");
            }
            Choice = choice;
        }


        internal void MultiVector()
        {
            string[,] menu = new string[,]
           {
                {"0"," -Exit"},
                {"1"," -Add"},
                {"2"," -Subtract"},
                {"3"," -Multiply"},
                {"4"," -Divide"}
           };

            string[] menuChoices = new string[menu.GetLength(0)];
            for (int i = 0; i < menu.GetLength(0); i++)
            {
                menuChoices[i] = menu[i, 0];
            }

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (!Array.Exists(menuChoices, element => element == choice))
            {
                Console.WriteLine("Invalid choice. Please enter a number from 0 to 4.");
            } else
            {
                Console.WriteLine(choice);
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

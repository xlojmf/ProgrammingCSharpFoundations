using D00_Utility;
using E01_CalculatorInterface.Classes;
using System;
using System.Threading;

namespace E02_CalculatorInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Utility.SetUnicodeConsole();
            while (true)
            {
                Utils.DesignMenu();

                int selectedMenu = calc.GetMenu("\nEnter your choice: ");
                if (selectedMenu == 0)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Until next time");
                    Thread.Sleep(3000);
                    break;
                }

                calc.Number1 = calc.ReadNumber("Enter first number: ");
                calc.Number2 = calc.ReadNumber("Enter second number: ");


                switch (selectedMenu)
                {
                    case 1:
                        Console.WriteLine("\nResult: " + calc.Add());
                        Utils.Clear();
                        break;
                    case 2:
                        Console.WriteLine("\nResult: " + calc.Subtract());
                        Utils.Clear();
                        break;
                    case 3:
                        Console.WriteLine("\nResult: " + calc.Multiply());
                        Utils.Clear();
                        break;
                    case 4:
                        if (Utility.ValidateNumber0(calc.Number2))
                        {
                            Console.WriteLine("\nCannot divide by zero.");
                            Utils.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nResult: " + calc.Divide());
                            Utils.Clear();
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        Utils.Clear();
                        break;
                }
            }

        }
    }
}

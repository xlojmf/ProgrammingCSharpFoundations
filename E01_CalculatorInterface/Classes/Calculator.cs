using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_CalculatorInterface
{
    internal class Calculator : ICalculator
    {
        #region properties
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public int Operation { get; set; }
        public double Result { get; set; }
        #endregion

        #region Constructor
        
        public Calculator() 
        { 
         Number1= 0;
         Number2= 0;
         Operation = 0;
         Result = 0;
        }

        #endregion


        #region methods


        public int GetMenu(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            while (!int.TryParse(input, out int menu) || menu < 0 || menu > 4)
            {
                Console.WriteLine("\nInvalid input. Choose a valid menu option, a number between 0 and 4.");
                Console.Write("\nEnter your desired operation: ");
                input = Console.ReadLine();
            }
            return Operation = int.Parse(input);
        }


        public double ReadNumber1(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            while (!double.TryParse(input, out double number))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                input = Console.ReadLine();
            }

            return Number1 = double.Parse(input);

        }
        public double ReadNumber2(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            while (!double.TryParse(input, out double number))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                input = Console.ReadLine();
            }

            return Number2 = double.Parse(input);

        }

        public double Add()
        {
            return Number1 + Number2;
        }
        public double Subtract()
        {
            return Number1 - Number2;
        }
        public double Multiply()
        {
            return Number1 * Number2;
        }
        public double Divide()
        {
            return Number1 / Number2;
        }

        #endregion


    }
}

using System;
using System.Xml.Linq;

namespace E01_Calculator_V1
{
    class Calculator
    {


        // properties
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public int Menu { get; set; }
        public double Result { get; set; }

        public Calculator()
        {
            //construtor defualt
            Number1 = 0;
            Number2 = 0;
            Menu= 0;
            Result = 0;
        }

        public static int result;
        public static double number;
  
        // methods
        // read the number the menu with tryparse unitl is true
        internal static int ReadOperation(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            while (!int.TryParse(input, out int result) || result < 0 || result > 4)
            {
                Console.WriteLine("\nInvalid input. Choose a valid menu option, a number between 0 and 4.");
                Console.Write("\nEnter your desired operation: ");
                input = Console.ReadLine();
            }

            return result = int.Parse(input);
        }

        // USING VOID METODO TO SAVE TO MENU PROPERTIE THE MENU
        public void GetMenu(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            while (!int.TryParse(input, out int menu) || menu < 0 || menu > 4)
            {
                Console.WriteLine("\nInvalid input. Choose a valid menu option, a number between 0 and 4.");
                Console.Write("\nEnter your desired operation: ");
                input = Console.ReadLine();
            }
            Menu = int.Parse(input);
        }

        // read the number method with tryparse unitl is true
        public void ReadNumber1(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            while (!double.TryParse(input, out double number))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                input = Console.ReadLine();
            }

            Number1 = double.Parse(input);

            Console.Write(message);
            string input1 = Console.ReadLine();

            while (!double.TryParse(input1, out double number))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                input = Console.ReadLine();
            }

            Number2 = double.Parse(input);
        }



        // read the number method with tryparse unitl is true
        public static double ReadNumber(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            while (!double.TryParse(input, out double number))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                input = Console.ReadLine();
            }

            return number = double.Parse(input);
        }


        internal double Add()
        {
            return Number1 + Number2;
        }

        internal double Subtract()
        {
            return Number1 - Number2;
        }

        internal double Multiply()
        {
            return Number1 * Number2;
        }

        internal double Divide()
        {
            return Number1 / Number2;
        }
    }
}





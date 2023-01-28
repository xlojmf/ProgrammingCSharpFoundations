using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_Calculator_V1
{
    class Calculator
    {


        // properties
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public int Menu { get; set; }


        public static int result;
        public static double number;

        // methods
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





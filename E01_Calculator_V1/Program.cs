﻿using System;
using System.Threading;
using static E01_Calculator_V1.Util;

/*
Propriedades:
Valor1
Valor2
Operacao
Método:
LerNumeros()
Somar()
Subtrair()
Multiplicar()
Dividir()
...
(+ os utilitarios se quisermos. mas devemos colocar na calculadora e nao no Utility ?????)

Quando a aplicacao arranca vai aparecer menu no ecra a perguntar a opercao que ela quer e enquanto nao selecionar na opcao correcta nao sai do menu. --> para poder usar estruturas ciclicas. 
no menu deve constar tambem um valor para sair do menu ( 0 - saida, 1 - soma, 2 - subtracao, 3 - multiplicacao, 4 - divisao)
**Temos de garantir que sao numeros! tryparse use

 */

namespace E01_Calculator_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // instante a calculator 
            Calculator calc = new Calculator();
            Util use= new Util();

            // cicle the application
            while (true)
            {
                DesignMenu();

                //calc.Menu = Calculator.ReadOperation("Enter your desired operation: ");
                //calc.Menu = menu;// para usar no futuro
                //calc.GetMenu("Enter your desired operation: ");
                //int selectedMenu = calc.Menu;
                use.GetMenuNumber();
                int selectedMenu = use.Choice;
                if (selectedMenu == 0)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n");
                    CenterDashWriteLine("Until next time");
                    Thread.Sleep(3000);
                    break;
                }

                // read the numbers using class
                calc.Number1 = Calculator.ReadNumber("Enter first number: ");
                calc.Number2 = Calculator.ReadNumber("Enter second number: ");

                // instance numbers
                //calc.Number1 = num1;
                //calc.Number2 = num2;

                // execture operations
                switch (selectedMenu)
                {
                    case 1:
                        Console.WriteLine("\nResult: " + calc.Add());
                        Clear();
                        break;
                    case 2:
                        Console.WriteLine("\nResult: " + calc.Subtract());
                        Clear();
                        break;
                    case 3:
                        Console.WriteLine("\nResult: " + calc.Multiply());
                        Clear();
                        break;
                    case 4:
                        if (calc.Number2 == 0)
                        {
                            Console.WriteLine("\nCannot divide by zero.");
                            Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nResult: " + calc.Divide());
                            Clear();
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        Clear();
                        break;
                }
            }
        }
    }
}

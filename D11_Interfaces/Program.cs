﻿using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D11_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Utility.SetUnicodeConsole();

            Utility.WriteTitle("Interface");

            Console.WriteLine(Utility.ValidateNumber0(10));

            Utility.TerminateConsole();
        }
    }
}
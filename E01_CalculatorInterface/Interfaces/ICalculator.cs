using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_CalculatorInterface
{
    internal interface ICalculator
    {
        #region properties
        double Number { get;}
        double Number1 { get; }
        double Number2 { get; }
        int Operation { get; }
        double Result { get; }
        #endregion

        #region methods

        double Add();
        double Subtract();
        double Multiply();
        double Divide();
        int GetMenu(string message);
        double ReadNumber(string message);
        #endregion
    }
}

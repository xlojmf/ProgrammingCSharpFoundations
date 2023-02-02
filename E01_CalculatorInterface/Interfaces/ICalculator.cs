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
        double Number1 { get; }
        double Number2 { get; }
        string Operation { get; }
        double Result { get; }
        #endregion

        #region methods

        void Add();
        void Subtract();
        void Multiply();
        void Divide();
        void ReadNumbers();
        void ShowResult();
        #endregion
    }
}

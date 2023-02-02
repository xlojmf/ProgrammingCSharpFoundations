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
        public string Operation { get; set; }
        public double Result { get; set; }
        #endregion

        #region Constructor
        
        public Calculator() 
        { 
         Number1= 0;
         Number2= 0;
         Operation = string.Empty;
         Result = 0;
        }

        #endregion


        #region methods

        public void Add() {
            //return Number1 + Number2; 
        }
        public void Subtract() { 
           // return Number1 + Number2; 
        }
        public void Multiply() { 
            //return Number1 + Number2; 
        }
        public void Divide() { 
            //return Number1 + Number2; 
        }

        public void ReadNumbers()
        {
           
        }

        public void ShowResult()
        {
            throw new NotImplementedException();
        }
        #endregion


    }
}

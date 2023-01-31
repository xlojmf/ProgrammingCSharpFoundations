using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D11_Interfaces
{
    internal interface IUser
    {

        #region Properties
        string userName { get; }
        string Password { get; }
        #endregion


        #region Methods

        void Message(string message);

        #endregion



    }
}

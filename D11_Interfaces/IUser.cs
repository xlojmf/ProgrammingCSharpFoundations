using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D11_Interfaces
{
    interface IUser
    {

        #region Properties
        string UserName { get; }
        string Password { get; }
        string Name { get; }
        #endregion


        #region Methods
        void Login();
        void Logout();
        void Message(string message);

        #endregion



    }
}

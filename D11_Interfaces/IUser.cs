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
        void Login(string name);
        void Logout(string message);
        string ReadUserData(string message);
        string AddUser();
        string GetName();
        List<User> CreateUser();
        void ListUsers(List<User> users);
        #endregion



    }
}

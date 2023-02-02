using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D11_Interfaces
{
    public class User : IUser
    {

        #region Properties
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        #endregion

        #region Constructor
        public User() { 
        Name= string.Empty;
        UserName= string.Empty; 
        Password= string.Empty;
        }

        public User(string userName, string password, string name)
        {
            UserName = userName;
            Password = password;
            Name = name;
        }



        #endregion

        #region Methods
        public void Login()
        {

        }
        public void Message(string message)
        {

        }
        public void Logout() { }
        #endregion

    }
}

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
        public void Login(string Name)
        {
            Console.WriteLine($"Welcome {Name}!");
        }
        public string ReadUserData(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        public void Logout(string message) 
        {
            Console.WriteLine(message);
        }
        #endregion

        public string GetLogoutMessage(int attempts)
        {
            return (attempts == 3) ? "Maximum number of attempts reached. Logging out." : "Invalid username or password. Logging out.";
        }

        public User[] CreateUser()
        {
            return new User[] {
            new User("user1", "pass1", "User 1"),
            new User("user2", "pass2", "User 2")
        };
        }

    }

}


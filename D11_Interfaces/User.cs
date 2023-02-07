using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
        public User()
        {
            Name = string.Empty;
            UserName = string.Empty;
            Password = string.Empty;
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
            Console.Write($"{Name}>");
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
            return (attempts == 3) ? "Maximum number of attempts reached. Logging out." : "Invalid username or password.";
        }

        public string AddUser()
        {
            Console.WriteLine("Do you wish to create an account? (yes or no)");
            string yesOrNo = Console.ReadLine();

            while (yesOrNo != "yes" && yesOrNo != "no")
            {
                Console.WriteLine("Invalid response. Please enter either 'yes' or 'no'.");
                yesOrNo = Console.ReadLine();
            }
            if (yesOrNo == "yes")
            {
                GetName();
            }
            return yesOrNo;

        }

        public string GetName()
        {
            Console.WriteLine("What is your name");
            return Name = Console.ReadLine();
        }

        public List<User> CreateUser()
        {
            return new List<User> {
        new User("user1", "pass1", "User 1"),
        new User("user2", "pass2", "User 2")
        };
        }

        public void ListUsers(List<User> users)
        {
            Console.WriteLine("\nUser List:");
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine($"Username: {users[i].UserName}");
            }
            Console.WriteLine();
        }

    }

}


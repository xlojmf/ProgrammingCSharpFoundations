using D00_Utility;
using System.Collections.Generic;

namespace D11_Interfaces
{

    internal class Program
    {
        static void Main(string[] args)
        {


            Utility.SetUnicodeConsole();

            Utility.WriteTitle("Interface with login");

            User userdefault = new User();
            List<User> users = userdefault.CreateUser();

            int attempts = 0;
            User loggedInUser = null;
            while (attempts < 3 && loggedInUser == null)
            {

                string username = userdefault.ReadUserData("Enter your username: ");
                string password = userdefault.ReadUserData("Enter your password: ");

                User loggedInUser1 = users.Find(user => user.UserName == username && user.Password == password);
                if (loggedInUser1 != null)
                {
                    loggedInUser1.Login(username);
                    break;
                }
                else
                {
                    string name = userdefault.AddUser();
                    if (attempts == 0 && name != "no")
                    {
                        users.Add(new User(username, password, name));
                        userdefault.ListUsers(users);
                        break;
                    }
                    attempts++;
                    userdefault.Logout(userdefault.GetLogoutMessage(attempts));
                }
            }

            Utility.TerminateConsole();
        }
    }
}

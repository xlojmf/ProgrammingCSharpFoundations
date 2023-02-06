using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D11_Interfaces
{
    // d11 qdo a aplicacao arranca quer criar dois utilizadores por defeito, e quer pedir o login e a pessoa vai pedir o username e password, e ao inserir na consola vai procurar se existem ou nao laggado ou nao 
    // usar array para criar os dois utilizadores
    internal class Program
    {
        static void Main(string[] args)
        {


            Utility.SetUnicodeConsole();

            Utility.WriteTitle("Interface with login");

            User userdefault = new User();
            User[] users = userdefault.CreateUser();

            int attempts = 0;
            User loggedInUser = null;
            while (attempts < 3 && loggedInUser == null)
            {

                string username = userdefault.ReadUserData("Enter your username: ");
                string password = userdefault.ReadUserData("Enter your password: ");

                User loggedInUser1 = Array.Find(users, user => user.UserName == username && user.Password == password);
                if (loggedInUser1 != null)
                {
                    loggedInUser1.Login(username);
                    break;
                }
                else
                {
                    attempts++;
                    userdefault.Logout(userdefault.GetLogoutMessage(attempts));
                }

                /*
                foreach (var user in users)
                {
                    if (user.UserName == username && user.Password == password)
                    {
                        loggedInUser = user;
                        loggedInUser.Login(user.UserName);
                        break;
                    }
                }

                if (loggedInUser == null)
                {
                    attempts++;
                    userdefault.Logout(userdefault.GetLogoutMessage(attempts));
                    
                }*/
            }

            Utility.TerminateConsole();
        }
    }
}

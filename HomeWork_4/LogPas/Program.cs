using System;
using System.IO;

namespace LogPas
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxTry = 3;

            while (maxTry != 0)
            {
                Console.Write("Enter login: ");
                string userLogin = Console.ReadLine();
                Console.Write("Enter password: ");
                string userPassword = Console.ReadLine();

                Account account = new Account(userLogin, userPassword);

                string[] correctLoginAndPassword = account.GetArrayFromFile();

                if (account.Authentication(account, correctLoginAndPassword) == true) break;                  
                maxTry--;
            }
        }
    }
}

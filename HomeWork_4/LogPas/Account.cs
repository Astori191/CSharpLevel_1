using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LogPas
{
    //4. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
    //Создайте структуру Account, содержащую Login и Password.

    class Account
    {
        private string login;
        private string password;

        public Account(string l, string p)
        {
            this.login = l;
            this.password = p;
        }
        /// <summary>
        /// Метод получения массива с логином[0] и паролем[1] из файла
        /// </summary>
        /// <returns>Массив</returns>
        public string[] GetArrayFromFile()
        {
            string[] array = new string[0];
            try
            {
                string path = @"C:\temp\Data.txt";
                int rows = File.ReadAllLines(path).Length;
                StreamReader sr = new StreamReader(path);
                array = new string[rows];
                while (!sr.EndOfStream)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        array[i] = sr.ReadLine();
                    }
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return array;
        }
        /// <summary>
        /// Метод проверки пользовательского ввода с эталонными значениями
        /// </summary>
        /// <param name="account">экземпляр класса Account с параметрами login password</param>
        /// <param name="existing">массив значений из файла</param>
        /// <returns></returns>
        public bool Authentication(Account account, string[] existing)
        {
            bool isReal = false;
            int len = existing.Length - 1;

            for (int i = 0; i < len; i++)
            {
                if (existing[i] == account.login && existing[i + 1] == account.password)
                {
                    isReal = true;
                    Console.WriteLine($"Your login: *{existing[i]}* and password: *{existing[i + 1]}* accepted!");
                }
                else
                {
                    isReal = false;
                    Console.WriteLine("Incorrect login or password!");
                }

            }

            return isReal;
        }

    }
}



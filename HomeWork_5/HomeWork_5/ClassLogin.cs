using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HomeWork_5
{
    //Создать программу, которая будет проверять корректность ввода логина. Корректным
    //логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита
    //или цифры, при этом цифра не может быть первой:
    //а) без использования регулярных выражений;
    //б) ** с использованием регулярных выражений.

    class ClassLogin
    {
        private string login;

        public ClassLogin(string userLogin) 
        {
            this.login = userLogin;
        }

        /// <summary>
        /// Метод считывает символы из файла, который не содержит пробелов между символами
        /// </summary>
        /// <returns>массив символов</returns>
        private static char[] ReadFileNoSpaces()
        {
            string path = @"C:\temp\Chars.txt";
            char[] symbols = new char[0];
            if (File.Exists(path))
            {
                string text = File.ReadAllText(path);
                int length = text.Length;
                symbols = new char[length];
                for (int i = 0; i < length; i++)
                {
                    symbols[i] = text[i];
                }
            }
            return symbols;
        }
        /// <summary>
        /// Метод, который считывает в список символы из файла, содержащий пробелы между символами
        /// </summary>
        /// <returns>список символов</returns>
        private List<char> ReadFileWithSpaces()
        {
            string path = @"C:\temp\Chars.txt";
            List<char> symbols = new List<char>();
            if (File.Exists(path))
            {
                string text = File.ReadAllText(path);
                string[] t = text.Split(' ');
                for (int i = 0; i < t.Length; i++)
                {
                    symbols.Add(char.Parse(t[i]));
                    Console.Write(symbols[i]);
                }
            }
            return symbols;
        }

        private static bool CheckIsDigit(string login)
        {
            char firstSymbol = login[0];

            if (char.IsDigit(firstSymbol) == true)
            {
                return false;
            }
            else return true;
        }

        //public bool CheckIsDigit0()
        //{
        //    return !char.IsDigit(login[0]);
        //}

        private static bool CheckChars(string login)
        {
            char[] symbols = ReadFileNoSpaces();           
            if (login.Length >= 2 && login.Length <= 10)
            {
                for (int i = 0; i < login.Length; i++)
                {
                    var currentChar = login[i];
                    bool isCharValid = false;

                    for (int j = 0; j < symbols.Length; j++)
                    {
                        if (currentChar == symbols[j])
                        {
                            isCharValid = true;
                        }
                    }

                    if (isCharValid == false)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool Validate()
        {
            if (!CheckIsDigit(this.login)) return false;
            if (!CheckChars(this.login)) return false;
            return true;
        }

        //public bool CheckChars()
        //{
        //    char[] symbols = ReadFileNoSpaces();
        //    char[] loginsymbols = login.ToCharArray();
        //    bool f = false;
        //    if (login.Length > 2 && login.Length < 10)
        //    {
        //        for (int i = 0; i < loginsymbols.Length; i++)
        //        {
        //            for (int j = 0; j < symbols.Length; j++)
        //            {
        //                if (loginsymbols[i] == symbols[j]) Console.WriteLine("vse ok");
        //            }
        //        }
        //    }
        //    Console.WriteLine(f);
        //    return f;
        //}



    }

}


//private string ReadFileUniversal()
//{
//    string path = @"C:\temp\Chars.txt";
//    string symbols = "";
//    if (File.Exists(path))
//    {
//        symbols = File.ReadAllText(path);
//    }
//    symbols = symbols.Replace(" ", "");
//    return symbols;
//}
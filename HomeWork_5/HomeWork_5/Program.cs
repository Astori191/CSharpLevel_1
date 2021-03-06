using System;
using System.Collections.Generic;
using System.IO;

namespace HomeWork_5
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            ClassLogin login = new ClassLogin(input);
            Console.WriteLine($"{login.Validate()}");
        }
    }
}


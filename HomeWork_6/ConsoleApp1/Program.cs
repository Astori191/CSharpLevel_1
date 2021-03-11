using System;

namespace ConsoleApp1
{
    class Program
    {
        //1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции
        //типа double (double, double). Продемонстрировать работу на функции с функцией a * x^2 и
        // функцией a * sin(x).
        public delegate double Funky(double a, double x);

        public static void Table(Funky F, double a, double x, double b)
        {
            Console.WriteLine("- A - X - Y -");
            while (x <= b)
            {
                Console.WriteLine($"| {a} | {x} | {F(a,x):0.00} |");
                x = x + 1;
            }
            Console.WriteLine("-------------");
        }
        public static double MyFunky(double a, double x)
        {
            return a * x * x;
        }
        public static double Sinus(double a, double x)
        {
            return a * Math.Sin(x);
        }
        static void Main()
        {
            Table(new Funky(MyFunky), 1, 2, 3);
            Table(new Funky(Sinus), 5, 10, 15);
        }
    }
}

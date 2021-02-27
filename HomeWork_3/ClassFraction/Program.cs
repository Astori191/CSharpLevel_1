using System;

namespace ClassFraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(3, 5);
            Fraction f2 = new Fraction(2, 6);
            Console.WriteLine($"f1: {f1.PrintFraction()}");
            Console.WriteLine($"f2: {f2.PrintFraction()}");

            Fraction addResult = f1 + f2;
            Console.WriteLine($"Sum: {addResult.PrintFraction()}");

            Fraction subResult = f1 - f2;
            Console.WriteLine($"Sub: {subResult.PrintFraction()}");

            Fraction multResult = f1 * f2;
            Console.WriteLine($"Mult: {multResult.PrintFraction()}");

            Fraction divResult = f1 / f2;
            Console.WriteLine($"Div: {divResult.PrintFraction()}");


        }
    }
}

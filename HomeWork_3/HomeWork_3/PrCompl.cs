using System;

namespace HomeWork_3
{

    class PrCompl
    {
        static void Main()
        {
            Complex z1 = new Complex(2, 3);
            Complex z2 = new Complex(3, -5);

            Console.WriteLine($"z1: {z1.Print()}");
            Console.WriteLine($"z2: {z2.Print()}");

            Complex addRes = Complex.Addition(z1, z2);
            //Console.WriteLine($"Sum: {addRes.Print()}");

            Complex subRes = Complex.Subtraction(z1, z2);
            //Console.WriteLine($"Diff: {subRes.Print()}");

            Complex multRes = Complex.Multiplication(z1, z2);
            //Console.WriteLine($"Mult: {multRes.Print()}");

            string userChoice = SelectOperation();

            switch (userChoice)
            {
                case "+":
                    Console.WriteLine($"Sum: {addRes.Print()}");
                    break;
                case "-":
                    Console.WriteLine($"Diff: {subRes.Print()}");
                    break;
                case "*":
                    Console.WriteLine($"Mult: {multRes.Print()}");
                    break;
                default:
                    Console.WriteLine("Something gone wrong!");
                    break;
            }

            Console.WriteLine();

            Fraction f1 = new Fraction(3, 7);
            Fraction f2 = new Fraction(2, 7);

            Console.WriteLine($"f1: {f1.PrintFraction()}");
            Console.WriteLine($"f2: {f2.PrintFraction()}");

            Fraction frAddRes = Fraction.Addition(f1, f2);
            Console.WriteLine($"Sum: {frAddRes.PrintFraction()}");




        }
        static string SelectOperation()
        {
            bool flag = default;
            string userChoice = String.Empty;

            while (flag != true)
            {
                Console.WriteLine("Choose operation \"+\" \"-\" \"*\"");
                userChoice = Console.ReadLine();

                if (userChoice != "+" && userChoice != "-" && userChoice != "*")
                {             
                    Console.WriteLine($"Bad input! Try again!");
                } 
                else
                {
                    flag = true;
                }
            }
            return userChoice;
        }
    }
}

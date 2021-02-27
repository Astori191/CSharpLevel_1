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

            string userChoice = SelectOperation();

            switch (userChoice)
            {
                case "+":
                    {
                        Complex addRes = Complex.Addition(z1, z2);
                        Console.WriteLine($"Sum: {addRes.Print()}");
                    }
                    break;
                case "-":
                    { 
                        Complex subRes = Complex.Subtraction(z1, z2);
                        Console.WriteLine($"Diff: {subRes.Print()}");
                    }
                    break;
                case "*":
                    {
                        Complex multRes = Complex.Multiplication(z1, z2);
                        Console.WriteLine($"Mult: {multRes.Print()}");
                    }
                    break;
                default:
                    Console.WriteLine("Something gone wrong!");
                    break;
            }

            Console.WriteLine();

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

using System;

namespace HomeWork_2
{
    class Program
    {
        static void Main()
        {
            //Minimum();
            //CountTheNumbersOfDigits();
            OddNumbers();
            //LoginPassword();
            //BodyMassIndex();
            //GoodNumbers();
            //TryRecursion();
        }

        // 1. Написать метод, возвращающий минимальное из трёх чисел +
        static void Minimum()
        {
            while (true)
            {
                Console.Write("Enter first number: ");
                string s1 = Console.ReadLine();
                Console.Write("Enter second number: ");
                string s2 = Console.ReadLine();
                Console.Write("Enter third number: ");
                string s3 = Console.ReadLine();

                if (int.TryParse(s1, out int a) && int.TryParse(s2, out int b) && int.TryParse(s3, out int c))
                {
                    Console.WriteLine($"Minimum number in sequence [{a}, {b}, {c}] is a: {MinOfThree(a, b, c)}");
                    break;
                } 
                else
                {
                    Console.WriteLine("Not a number! Try again.");
                }
            }
            Console.WriteLine();
        }

        static int MinOfThree(int n1, int n2, int n3)
        {
            int min = (n1 < n2 && n1 < n3) ? n1 : (n2 < n1 && n2 < n3) ? n2 : n3;
            // или Math.Min(n1, n2, n3)
            return min;
        }

        // 2. Написать метод подсчета количества цифр числа. +
        static void CountTheNumbersOfDigits()
        {
            int number = 7777;
            Console.WriteLine($"Your number is: {number}");

            int result = CountingDigits(number);
            Console.WriteLine($"Number of digit in a number is: {result}");
            Console.WriteLine();
        }

        static int CountingDigits(int n)
        {
            var count = 0;
            while (n != 0)
            {
                n /= 10;
                count++;
            }
            return count;
        }

        // 3. С клавиатуры вводятся числа, пока не будет введен 0. +
        // Подсчитать сумму всех нечетных положительных чисел.
        static void OddNumbers()
        {
            var input = 1;
            var result = 0;
            while (input != 0)
            {
                Console.WriteLine("Enter a number (press 0 to stop): ");
                string myString = Console.ReadLine();
                input = int.Parse(myString);
                if (input % 2 != 0)
                {
                    result += input;
                }
                Console.WriteLine($"Result: {result}");
            }
            Console.WriteLine();
        }

        // 4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
        // На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин: root, Password: GeekBrains). 
        // Используя метод проверки логина и пароля, написать программу: 
        // пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
        // С помощью цикла do while ограничить ввод пароля тремя попытками. +

        static void LoginPassword()
        {
            int maxTry = 3;

            while (maxTry > 0)
            {
                Console.Write("Enter Login: ");
                string userLogin = Console.ReadLine();
                Console.Write("Enter Password: ");
                string userPassword = Console.ReadLine();

                if (CheckLogin(userLogin) && CheckPassword(userPassword))
                {
                    break;
                } 
                else
                {
                    maxTry--;
                    Console.WriteLine($"{maxTry} tr. left\n");
                }
            }
        }
        static bool CheckLogin(string userLogin)
        {
            string login = "root";
            bool isValid = default;

            if (login.Equals(userLogin, StringComparison.Ordinal)) 
            {
                isValid = true;
                Console.WriteLine("\nLogin accept!");
            }
            else
            {
                Console.WriteLine("\nNo such login!");
            }

            return isValid;
        }

        static bool CheckPassword(string userPassword)
        {
            string password = "GeekBrains";
            bool isValid = default;

            if (password.Equals(userPassword, StringComparison.Ordinal))
            {
                isValid = true;
                Console.WriteLine("Password accept!");
            } 
            else
            {
                Console.WriteLine("Incorrect password!");
            }

            return isValid;
        }

        // 5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс
        // массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме. +
        // б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса. +

        static void BodyMassIndex()
        {
            Console.Write("Enter your height (m). Example (1,8): ");
            double userHeight = double.Parse(Console.ReadLine());

            Console.Write("Enter your weight (kg): ");
            double userWeight = double.Parse(Console.ReadLine());

            double index = userWeight / Math.Pow(userHeight, 2);
            Console.WriteLine($"\nBody mass index = {index:f2}");

            if (index < 18.5) 
            {
                double alert = (18.5 - index) * Math.Pow(userHeight, 2);
                Console.WriteLine($"\nYou need to gain {alert:f2} kg");               
            } 
            else if (index >= 18.5 && index <= 25.0)
            {
                Console.WriteLine("\nEverything is okay!");
            }
            else
            {
                double alert = (index - 25.0) * Math.Pow(userHeight, 2);
                Console.WriteLine($"\nYou need to lose {alert:f2} kg");
            }
        }

        // 6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
        // «Хорошим» называется число, которое делится на сумму своих цифр.
        // Реализовать подсчёт времени выполнения программы, используя структуру DateTime.   +
        static void GoodNumbers()
        {
            DateTime start = DateTime.Now;
            System.Threading.Thread.Sleep(20);
            int goodNumbersCount = default;
            int startOfRange = 1;
            int endOfRange = 1_000_000_000;
                   
            for (int i = startOfRange; i <= endOfRange; i++)
            {
                int temp = i;
                int sumOfDigits = 0;

                while (temp > 0)
                {
                    sumOfDigits += (temp % 10);
                    temp /= 10;
                }

                if (i % sumOfDigits == 0 ) 
                {
                    goodNumbersCount++;
                }
            }

            Console.WriteLine($"Good numbers = {goodNumbersCount}");
            DateTime finish = DateTime.Now;
            Console.WriteLine($"Program started at {start}. Finished at {finish}");
        }

        //7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a < b). +

        static void TryRecursion()
        {
            Recursion(1, 50);
        }

        static void Recursion(int a, int b)
        { 
            if (a <= b)
            {
                Console.WriteLine(a);
                Recursion(a + 1, b);
            }
        }
    }
}

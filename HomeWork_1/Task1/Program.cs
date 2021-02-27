using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        Questionnaire();
        BodyMass();
        Distance();
        SwapValues();
        ConsoleOutput();
    }

    static void Questionnaire()
    {
        // +
        // 1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
        // а) используя склеивание;
        // б) используя форматированный вывод;
        // в) *используя вывод со знаком $.
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        Console.Write("Enter your lastname: ");
        string userLastName = Console.ReadLine();
        Console.Write("Enter your age: ");
        string userAge = Console.ReadLine();

        Console.WriteLine("Hello " + userName + " " + userLastName + " you are " + userAge + " years old");
        Console.WriteLine("Hello {0} {1} you are {2} years old", userName, userLastName, userAge);
        Console.WriteLine($"Hello {userName} {userLastName} you are {userAge} years old");
        Console.ReadLine();
    }
    
    static void BodyMass()
    {
        // +
        // 2.Ввести вес и рост человека. 
        // Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах
        Console.Write("Enter your height: ");
        string userHeight = Console.ReadLine();
        Console.Write("Enter your weight: ");
        string userWeight = Console.ReadLine();

        if (double.TryParse(userHeight, out double h) && double.TryParse(userWeight, out double w))
        {
            Console.WriteLine($"Your weight is {h}. Your weight is {w}");
            double bodyMassIndex = w / (h * h);
            Console.WriteLine("Body mass index = {0:f6}", bodyMassIndex);
        } else
        {
            Console.WriteLine("Bad input");
        }

        Console.ReadLine();             
    }

    static void Distance()
    {
        // +
        // 3.
        // а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2, y2 
        // по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
        // б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;

        int x1 = 3;
        int y1 = 6;
        int x2 = 8;
        int y2 = 13;

        Console.WriteLine("Calculates the distance between points with coordinates x1={0}, y1={1}, x2={2}, y2={3}", x1, x2, y1, y2);

        Console.WriteLine("Result: {0:f2}", CalculateTheDistance(x1, y1, x2, y2));

        Console.ReadLine();
    }

    static double CalculateTheDistance(int x1, int y1, int x2, int y2)
    {
        double interval = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        return interval;
    }

    static void SwapValues()
    {
        // +
        //4. Написать программу обмена значениями двух переменных.
        //а) с использованием третьей переменной;
        //б) *без использования третьей переменной.

        int value1 = 10;
        int value2 = 20;
        // int temp = value1;

        Console.WriteLine($"Value1 = {value1}, Value2 = {value2}");

        value1 = value1 + value2; 
        value2 = value1 - value2; 
        value1 = value1 - value2; 

        //value1 = value2;
        //value2 = temp;

        Console.WriteLine($"\nValue1 = {value1}, Value2 = {value2}");
        Console.ReadLine();
    }


    //5.
    //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
    //б) Сделать задание, только вывод организуйте в центре экрана
    //в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)

    static void ConsoleOutput()
    {
        
        string myInfo = Message();

        int halfWidth = Console.WindowWidth / 2 - (myInfo.Length / 2);
        int halfHeight = Console.WindowHeight / 2;


        Console.Clear();
        Console.SetCursorPosition(halfWidth, halfHeight);
        Console.WriteLine($"{myInfo}");

        Console.ReadLine();
    }

    static string Message()
    {
        string myString = Console.ReadLine();
        return myString;
    }

}
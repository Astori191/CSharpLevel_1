using System;

namespace HomeWork_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayClass array = new ArrayClass(4);
            array.PrintArray();
            array.FindPairs();

            int size = 10;
            int initialValue = 4;
            int step = 6;
            int number = 2;

            array = new ArrayClass(size, initialValue, step);
            array.PrintArray();
            Console.WriteLine($"Array sum: {array.Sum}");
            array.Inverse();
            Console.WriteLine("********************");

            array = new ArrayClass(size, initialValue, step);
            array.Multi(number);
            Console.WriteLine("********************");

            array = new ArrayClass(20);
            array.PrintArray();
            Console.WriteLine($"Max count: {array.MaxCount}"); 

        }


    }
}

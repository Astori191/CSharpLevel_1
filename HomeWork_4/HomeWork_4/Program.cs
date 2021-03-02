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

            ArrayClass arrayMod= new ArrayClass(size, initialValue, step);
            arrayMod.PrintArray();
            Console.WriteLine($"Array sum: {arrayMod.Sum}");
        }


    }
}

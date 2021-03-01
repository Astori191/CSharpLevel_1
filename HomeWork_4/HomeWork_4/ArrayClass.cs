using System;
using System.Text;

namespace HomeWork_4
{

    //1. Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые
    //значения от –10 000 до 10 000 включительно.Заполнить случайными числами.Написать
    //программу, позволяющую найти и вывести количество пар элементов массива, в которых только
    //одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих
    //элемента массива.Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.

    class ArrayClass
    {
        private double[] myArray;
        Random r = new Random();

        public ArrayClass(int n)
        {
            if (n == 0) throw new ArgumentException();
            myArray = new double[n];
            for (int i = 0; i < n; i++)
            {
                myArray[i] = r.Next(1, 100);
            }        
        }

        //public ArrayClass(int n, int )



        public void PrintArray()
        {
            int length = myArray.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Array element {i}: {myArray[i]}");
            }
        }

        public void FindPairs()
        {
            int length = myArray.Length;
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (myArray[i] % 3 == 0 || myArray[i+1] % 3 == 0)
                {
                    count++;                 
                }              
            }
            Console.WriteLine($"Pairs count: {count}");
        }
    }
}

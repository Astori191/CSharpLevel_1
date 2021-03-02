using System;
using System.Text;

namespace HomeWork_4
{

    //1. Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые
    //значения от –10 000 до 10 000 включительно.Заполнить случайными числами.Написать
    //программу, позволяющую найти и вывести количество пар элементов массива, в которых только
    //одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих
    //элемента массива.Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.

    //3. Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий
    //массив определенного размера и заполняющий массив числами от начального значения с
    //заданным шагом. Создать свойство Sum, которое возвращает сумму элементов массива, метод
    //Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый
    //массив, остается без изменений), метод Multi, умножающий каждый элемент массива на
    //определённое число, свойство MaxCount, возвращающее количество максимальных элементов.

    class ArrayClass
    {
        private int[] myArray;
        private Random r = new Random();
      
        public ArrayClass()
        {
            myArray = Array.Empty<int>();
        }
        /// <summary>
        /// Конструктор заполняющий массив заданного размера, с заданным первым элементом, заданным шагом
        /// </summary>
        /// <param name="size">размер массива</param>
        /// <param name="initialValue">первый элемент</param>
        /// <param name="step">шаг</param>
        public ArrayClass(int size, int initialValue, int step)
        {
            myArray = new int[size];
            myArray[0] = initialValue;
            for (int i = 1; i < size; i++)
            {
                myArray[i] = myArray[i - 1] + step;
            }
        }

        public ArrayClass(int n)
        {
            if (n == 0) throw new ArgumentException();
            myArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                myArray[i] = r.Next(1, 100);
            }        
        }
        /// <summary>
        /// Свойство, возвращающее сумму элементов массива
        /// </summary>
        public int Sum
        {
            get
            {
                int length = myArray.Length;
                int sum = 0;
                for (int i = 0; i < length; i++)
                {
                    sum = sum + myArray[i];
                }
                return sum;
            }
        }

        public int[] Inverse()
        {
            int[] inverseArray = myArray;
            int length = myArray.Length;
            for (int i = 0; i < length; i++)
            {
                inverseArray[i] = myArray[i] * (-1);
            }
            return inverseArray;
        }

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
            int length = myArray.Length - 1;
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

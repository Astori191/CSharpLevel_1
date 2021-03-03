using System;
using System.Text;
using System.IO;
using System.Linq;

namespace HomeWork_4
{

    //1. Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые
    //значения от –10 000 до 10 000 включительно.Заполнить случайными числами.Написать
    //программу, позволяющую найти и вывести количество пар элементов массива, в которых только
    //одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих
    //элемента массива.Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.

    //а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
    //б) * Добавьте статический метод для считывания массива из текстового файла.Метод должен
    //возвращать массив целых чисел;
    //в)** Добавьте обработку ситуации отсутствия файла на диске.

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
                myArray[i] = r.Next(1, 30);
            }        
        }

        public ArrayClass(string path)
        {
            myArray = new int[0];

            if (File.Exists(path))
            {
                string text = File.ReadAllText(path);
                string[] t = text.Split(' ');

                myArray = new int[t.Length];
                for (int i = 0; i < myArray.Length; i++)
                {
                    myArray[i] = int.Parse(t[i]);
                }
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
        /// <summary>
        /// Метод меняющий знак элементов массива
        /// </summary>
        /// <returns>массив отрицательных значений</returns>
        public int[] Inverse()
        {
            int[] inverseArray = myArray;
            int length = inverseArray.Length;
            for (int i = 0; i < length; i++)
            {
                inverseArray[i] = myArray[i] * (-1);
                Console.WriteLine($"{inverseArray[i]}");
            } 
            return inverseArray;
        }
        /// <summary>
        /// Метод умножающий каждый элемент на заданное число
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int[] Multi(int number)
        {
            int[] multiArray = myArray;
            for (int i = 0; i < multiArray.Length; i++)
            {
                multiArray[i] = myArray[i] * number;         
                Console.WriteLine($"{multiArray[i]}");
            }
            return multiArray;
        }
        /// <summary>
        /// Свойство для нахождения максимального элемента
        /// </summary>
        public int Max
        {
            get
            {
                int max = myArray[0];
                for (int i = 1; i < myArray.Length; i++)
                {
                    if (myArray[i] > max)
                    {
                        max = myArray[i];
                    }
                }
                return max;
            }
        }
        /// <summary>
        /// Подсчет количества максимальных элементов
        /// </summary>
        public int MaxCount
        {
            get
            {
                int count = 0;
                foreach(int i in myArray)
                {
                    if (i == Max)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        public void PrintArray()
        {
            int length = myArray.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Array element {i}: {myArray[i]}");
            }
        }
        /// <summary>
        /// Нахождение пар
        /// </summary>
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

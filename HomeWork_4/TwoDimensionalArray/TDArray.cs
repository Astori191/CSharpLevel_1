using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TwoDimensionalArray
{
    //5. * а) Реализовать библиотеку с классом для работы с двумерным массивом.
    // Реализовать конструктор, заполняющий массив случайными числами. 
    // Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного,
    // свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный
    // элемент массива, метод, возвращающий номер максимального элемента массива
    // (через параметры, используя модификатор ref или out).
    //** б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные
    // в файл.
    // ** в) Обработать возможные исключительные ситуации при работе с файлами.


    class TDArray
    {
        private int[,] array;
        private Random rnd = new Random();

        /// <summary>
        /// Конструктор для заполнения двумерного массива случайными элементами
        /// </summary>
        /// <param name="rows">строки</param>
        /// <param name="columns">столбцы</param>
        public TDArray(int rows, int columns)
        {
            if (rows == 0 || columns == 0) throw new ArgumentException();
            array = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = rnd.Next(1, 100);
                }
            }
        }

        public TDArray(string path)
        {
            array = new int[,] { };
            if (File.Exists(path))
            {
                
            }
        }


        /// <summary>
        /// Получить количество строк
        /// </summary>
        private int Rows
        {
            get
            {
                int r = array.GetLength(0);
                return r;
            }
        }
        /// <summary>
        /// Получить количество столбцов
        /// </summary>
        private int Columns
        {
            get
            {
                int c = array.GetLength(1);
                return c;
            }
        }
        /// <summary>
        /// Получить максимальный элемент
        /// </summary>
        public int Max
        {
            get
            {
                int max = array[0, 0];
                int r = Rows;
                int c = Columns;
               
                for (int i = 0; i < r; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        if (array[i, j] > max) max = array[i, j];                       
                    }
                }
                Console.WriteLine($"Max element: {max}");
                return max;
            }
        }

        public void MaxElementIndex(out string pos)
        {
            pos = "";
            int max = Max;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (array[i,j] == max) pos = $"i:{i}, j:{j}";
                }
            }
        }
        /// <summary>
        /// Получить минимальный элемент
        /// </summary>
        public int Min
        {
            get
            {
                int min = array[0,0];
                int r = Rows;
                int c = Columns;
                for (int i = 0; i < r; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        if (array[i, j] < min) min = array[i, j];
                    }
                }
                Console.WriteLine($"Min element: {min}");
                return min;
            }
        }
        /// <summary>
        /// Вычислить сумму элементов массива
        /// </summary>
        /// <returns>Сумма</returns>
        public int GetArrayElementsSum()
        {
            int sum = 0;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    sum = sum + array[i, j];
                }
            }
            Console.WriteLine($"Sum of elements: {sum}");
            return sum;
        }
        /// <summary>
        /// Вычислить сумму элементов массива больше заданного
        /// </summary>
        /// <param name="number">Заданное число</param>
        /// <returns>Сумма</returns>
        public int GetArrayElementSumMoreThanValue(int number)
        {
            int sum = 0;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (array[i, j] > number) sum = array[i, j] + sum;
                }
            }
            Console.WriteLine($"Sum of element more than {number}: {sum}");
            return sum;
        }
        /// <summary>
        /// Вывести массив в консоль
        /// </summary>
        public void PrintArray()
        {
            int r = Rows;
            int c = Columns;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(array[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }




}

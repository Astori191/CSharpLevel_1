using System;
using System.Collections.Generic;
using System.IO;

namespace Students
{
    class Program
    {
        //Переделать программу Пример использования коллекций для решения следующих задач:
        //а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
        //б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
        //в) отсортировать список по возрасту студента;
        //г) *отсортировать список по курсу и возрасту студента;
        static void Main(string[] args)
        {
            string path = @"C:\temp\Students.txt";
            Student student = new Student();
            student.ReadFromFile(path);
            student.PrintList(path);
            student.PrintStudents5thAnd6thYear(path);
            student.PrintStudentsAgeFrom18To20(path);
            student.ListSortByAge(path);
        }
    }
}

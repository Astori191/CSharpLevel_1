using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Students
{
    class Student
    {
        private string firstName;
        private string lastName;
        private string univercity;
        private string faculty;
        private string department;
        private int age;
        private int course;
        private int group;
        private string city;

        public Student()
        {

        }

        private Student(string firstName, string lastName,string univercity, string faculty, string department, int age, int course, int group, string city)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.univercity = univercity;
            this.faculty = faculty;
            this.department = department;
            this.age = age;
            this.course = course;
            this.group = group;
            this.city = city;
        }

        public List<Student> ReadFromFile(string path)
        {
            StreamReader fileIn = new StreamReader(path);
            List<Student> list = new List<Student>();
            try
            {
                while (!fileIn.EndOfStream)
                {
                    string[] data = fileIn.ReadLine().Split(';');
                    list.Add(new Student(data[0], data[1], data[2], data[3], data[4], int.Parse(data[5]), int.Parse(data[6]), int.Parse(data[7]), data[8]));
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            fileIn.Close();
            return list;
        }

        public void PrintList(string path)
        {
            List<Student> list = ReadFromFile(path);

            foreach(Student s in list)
            {
                Console.Write($"{s.firstName}, {s.lastName}, {s.univercity}, {s.faculty}, {s.department}, {s.age}, {s.course}, {s.group}, {s.city}");
                Console.WriteLine();            
            }
        }

        private int Students5thAnd6thYear(string path)
        {
            List<Student> list = ReadFromFile(path);
            int count = 0;

            foreach(Student s in list)
            {
                if (s.course > 4 && s.course < 7) count++;
            }
            return count;
         }

        public void PrintStudents5thAnd6thYear(string path)
        {
            int count = Students5thAnd6thYear(path);
            Console.WriteLine($"5th and 6th year students: {count}");
        }

        private string StudentsAgeFrom18To20(string path)
        {
            List<Student> list = ReadFromFile(path);
            Dictionary<int, int> courseAndAge = new Dictionary<int, int>();
            foreach (Student s in list)
            {
                if (s.age > 17 && s.age < 21)
                {
                    if (courseAndAge.ContainsKey(s.course)) courseAndAge[s.course] += 1;
                    else courseAndAge.Add(s.course, 1);
                }
            }
            ICollection<int> keys = courseAndAge.Keys;
            string data = default;
            foreach (var key in keys)
            {
                data = data + ($"Course:{key} Students:{courseAndAge[key]}\n");
            }
            return data;
        }

        public void PrintStudentsAgeFrom18To20(string path)
        {
            string data = StudentsAgeFrom18To20(path);
            foreach (var item in data)
            {
                Console.Write(item);
            }
        }

        private int CompareByAge(Student s1, Student s2)
        {
            return String.Compare(s1.age.ToString(), s2.age.ToString());
        }

        public void ListSortByAge(string path)
        {
            List<Student> list = ReadFromFile(path);
            list.Sort(new Comparison<Student>(CompareByAge));
            foreach (var item in list)
            {
                Console.WriteLine($"{item.firstName} {item.lastName} {item.age}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

// С помощью рефлексии выведите все свойства структуры DateTime

namespace Ref
{
    class Program
    {
        static void Main()
        {
            Type type = typeof(DateTime);
            foreach (var prop in type.GetProperties())
            {
                Console.WriteLine(prop.Name);
            }
            Console.ReadLine();
        }

    }
}

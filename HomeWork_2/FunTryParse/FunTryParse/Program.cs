using System;
using System.Text;

namespace FunTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number. Press 0 to stop.");
            int sum = GetValue();
            Console.WriteLine($"Sum of odd numbers: {sum}");

            static int GetValue()
            {
                int sum = 0;
                while (true)
                {
                    string data = Console.ReadLine();
                    if (int.TryParse(data, out int n))
                        if (n > 0 && n % 2 != 0)
                        {
                            sum = sum + n;
                        }
                        else if (n == 0)
                        {
                            Console.WriteLine("0 pressed. Exit.");
                            break;
                        }
                        else if (n < 0)
                        {
                            Console.WriteLine("Bad input");
                            break;
                        }
                    Console.WriteLine($"Number: {n}");
                }
                return sum;
            }
            #region _something
            //Console.WriteLine("Enter numbers. Press 0 to stop");

            //string oddData = GetData();
            //int sum = 0;
            //StringBuilder sb = new StringBuilder(oddData);

            //for (int i = 0; i < sb.Length; i++)
            //{
            //    i++;
            //    sum = i + sum;
            //}
            //Console.WriteLine($"Sum of odd numbers: {sum}");          
        }
        static void GetData()
        {
            //    bool flag = default;
            //    string total = default;
            //    string odd = default;
            //    string separator = " ";
            //    do
            //    {
            //        string data = Console.ReadLine();
            //        if (int.TryParse(data, out int num))
            //        { 
            //            if (num % 2 != 0)
            //            {
            //                flag = true;
            //                total = total + num + separator;
            //                Console.WriteLine($"Data: {total}");
            //                odd = odd + num + separator;
            //                Console.WriteLine($"Odd: {odd}");
            //            }
            //            else if (num == 0)
            //            {
            //                Console.WriteLine("0 pressed. Exit...");
            //                break;
            //            }
            //            else if (num % 2 == 0)
            //            {
            //                flag = true;
            //                total = total + num + separator;
            //                Console.WriteLine("Even number.");
            //                Console.WriteLine($"Data: {total}");
            //            }
            //        }
            //        else 
            //        {
            //            Console.WriteLine("Something wrong. Exit...");
            //            break;
            //        }

            //    } while (flag);

            //    return odd;
            #endregion
        }
    }
}

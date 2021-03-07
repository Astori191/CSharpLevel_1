using System;

namespace Permutation
{
    public static class StringUtils
    {
        public static bool AreMutations(string s1, string s2)
        {
            if (s1 == s2)
            {
                return true;
            }

            if (s1.Length != s2.Length) return false;

            char[] arr1 = s1.ToCharArray();
            Array.Sort(arr1);
            char[] arr2 = s2.ToCharArray();
            Array.Sort(arr2);

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i]) return false;
            }

            return true;
        }
    }

    class Program
    {
        static bool TestCase1()
        {
            return StringUtils.AreMutations("abc", "abc") == true;
        }

        static bool TestCase2()
        {
            return StringUtils.AreMutations("abc", "bca") == true;
        }

        static bool TestCase3()
        {
            return StringUtils.AreMutations("abc", "bcd") == false;
        }

        static bool TestCase4()
        {
            return StringUtils.AreMutations("abc", "bcac") == false;
        }

        static bool TestCase5()
        {
            return StringUtils.AreMutations("bcac", "abc") == false;
        }

        static bool TestCase6()
        {
            return StringUtils.AreMutations("","") == true;
        }

        static void Main()
        {
            Console.WriteLine("1: " + TestCase1());
            Console.WriteLine("2: " + TestCase2());
            Console.WriteLine("3: " + TestCase3());
            Console.WriteLine("4: " + TestCase4());
            Console.WriteLine("5: " + TestCase5());
            Console.WriteLine("6: " + TestCase6());
        }
      
    }
}

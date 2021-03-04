using System;

namespace TwoDimensionalArray
{
    class Program
    {
        static void Main()
        {
            TDArray tdArray = new TDArray(3,4);
            tdArray.PrintArray();

            int min = tdArray.Min;

            //tdArray.GetArrayElementsSum(); // tdArray.GetArrayElementsSum(tdArray) ?
            tdArray.MaxElementIndex(out string pos);
            Console.WriteLine(pos);
            tdArray.GetArrayElementSumMoreThanValue(77);
            string path = @"C:\temp\DimArray.txt";
            tdArray = new TDArray(path);
        }
    }
}

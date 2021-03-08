using System;

namespace Msg
{
    class Program
    {
        static void Main()
        {
            string text = "One two three four five six seven eight nine ten longword stepanov";
            ClassMessage message = new ClassMessage(text);

            //message.PrintWordsContainsNLetters(4);
            Console.WriteLine();
            //message.RemoveWords('e');
            Console.WriteLine();
            message.FindMaxLengthWord();
            Console.WriteLine();
            //message.UseStringBuilder();
        }
    }
}

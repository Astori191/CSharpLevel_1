using System;

namespace Msg
{
    class Program
    {
        static void Main()
        {
            string text = "One two three four five wordword six seven eight nine ten longword longlong ";
            ClassMessage message = new ClassMessage(text);

            message.PrintWordsContainsNLetters(4);
            Console.WriteLine();
            message.RemoveWords('e');
            Console.WriteLine();
            message.PrintLongWords();
            Console.WriteLine();
            message.UseStringBuilder();
        }
    }
}

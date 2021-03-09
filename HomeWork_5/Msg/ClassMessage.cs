using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msg
{
    //Разработать статический класс Message, содержащий следующие статические методы для
    //обработки текста:
    //а) Вывести только те слова сообщения, которые содержат не более n букв. +
    //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    //в) Найти самое длинное слово сообщения.
    //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    //д) *** Создать метод, который производит частотный анализ текста.В качестве параметра в
    //него передается массив слов и текст, в качестве результата метод возвращает сколько раз
    //каждое из слов массива входит в этот текст.Здесь требуется использовать класс Dictionary.


    class ClassMessage
    {
        private string message;

        public ClassMessage(string text)
        {
            this.message = text;
        }

        public void PrintWordsContainsNLetters(int n)
        {
            string[] t = message.Split(' ');
            foreach(var word in t)
            {
                if (word.Length <= n && word != "") Console.Write(word + ' ');
            }
        }

        public void RemoveWords(char c)
        {
            string[] t = message.Split(' ');
            string toChange = message;

            foreach(var word in t)
            {
                if (word.EndsWith(c))
                {
                    toChange = toChange.Replace(word, "");                   
                }             
            }
            Console.WriteLine($"\n {toChange}");
        }

       private List<string> FindMaxLengthWord()
        {
            string[] t = message.Split(' ');
            string maxLengthWord = t[0];
            List<string> londWords = new List<string>();          
            int max = 0;

            foreach (var word in t)
            {
                if (word.Length > maxLengthWord.Length)
                {
                    londWords.Clear();
                    maxLengthWord = word;                    
                    max = maxLengthWord.Length;
                }
                if (word.Length == max) londWords.Add(word);
            }
            return londWords;
        }

        public void PrintLongWords()
        {
            List<string> londWords = FindMaxLengthWord();
            foreach (var word in londWords)
            {
                Console.WriteLine($"List: {word}");
            }

        }

        public void UseStringBuilder()
        {
            string[] t = message.Split(' ');
            List<string> londWords = FindMaxLengthWord();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < londWords.Count; i++)
            {
                sb.Append(londWords[i]);
                sb.Append(' ');
            }
            Console.WriteLine($"Using StringBilder: {sb}");
        }
    }
}

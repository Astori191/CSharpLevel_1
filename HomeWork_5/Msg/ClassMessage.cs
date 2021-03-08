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


        // TODO
        // Коряво работает
       public int FindMaxLengthWord()
        {
            string[] t = message.Split(' ');
            string maxLengthWord = t[0];
            List<string> w = new List<string>();
            var max = 0;
            foreach (var word in t)
            {
                if (word.Length >= maxLengthWord.Length)
                {

                    maxLengthWord = word;
                    for (int i = 0; i < 1; i++)
                    {
                        w.Add(word);
                        if (w[i].Length == maxLengthWord.Length) continue;
                        else
                        {
                            w.Remove(word);
                        }                       
                    }
                    
                    max = maxLengthWord.Length;
                }
            }
            //Console.WriteLine(maxLengthWord);
            return max;
        }

        public void UseStringBuilder()
        {
            string[] t = message.Split(' ');
            int max = FindMaxLengthWord();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i].Length == max)
                {
                    sb.Append(t[i]);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}

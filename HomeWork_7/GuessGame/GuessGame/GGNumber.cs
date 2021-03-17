using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    class GGNumber
    {
        int number;
        int tries;

        public GGNumber()
        {
            this.number = 0;
            this.tries = 3;
        }

        public int Number { get { return this.number; } }
        public int Tries { get { return this.tries; } }

        public void GenerateNumber()
        {
            Random rand = new Random();
            this.number = rand.Next(1, 100);
        }

        public bool CheckUserNumber(int userInput, out string res)
        {
            bool flag = false;

                if (this.number == userInput)
                {
                    flag = true;
                    res = "Верно!";
                }
                else if (this.number > userInput)
                {
                    res = "Число меньше загаданного";
                    tries--;
                }
                else if (this.number < userInput)
                {
                    res = "Число больше загаданного";
                    tries--;
                }
                else
                {
                    res = "Неверно!";
                    tries--;
                }

            return flag;
        }
        public void Reset()
        {
            this.number = 0;
            this.tries = 3;
        }

    }
}

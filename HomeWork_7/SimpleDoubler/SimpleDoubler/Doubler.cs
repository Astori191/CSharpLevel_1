using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDoubler
{
    class Doubler
    {
        int value;
        int actions;
        int goal;
        Random rand = new Random();

        public delegate void CtrlZ();

        Stack<CtrlZ> operations = new Stack<CtrlZ>();

        public int Value { get { return this.value; } }
        public int Actions { get { return this.actions; } }
        public int Goal { get { return this.goal; } }

        public Doubler()
        {
            this.value = 0;
            this.actions = 0;
            this.goal = 0;
        }

        public void Plus()
        {
            this.value++;
            this.actions++;
            operations.Push(new CtrlZ(Minus));
        }

        public void Minus()
        {
            this.value--;
            this.actions--;
        }

        public void Multi()
        {
            if (this.value != 0)
            {
                this.value *= 2;
                this.actions++;
                operations.Push(new CtrlZ(Div));
            }
        }

        public void Div()
        {
            this.value /= 2;
            this.actions--;
        }

        public void Reset()
        {
            this.value = 0;
            this.actions = 0;
            operations.Clear();
        }

        public void SetGoal()
        {
            this.goal = rand.Next(1, 50);
        }

        public bool CheckGoal()
        {
            if (this.value == this.goal) return true;
            else return false;
        }

        public bool CheckGoalOutOfRange()
        {
            if (this.value > this.goal) return true;
            else return false;
        }

        public void CheckStack()
        {
            CtrlZ ctrlZ;
            if (operations.Count != 0)
            {
                ctrlZ = operations.Pop();
                ctrlZ();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDoubler
{
    public partial class Form1 : Form
    {
        Doubler doubler;
        public Form1()
        {
            InitializeComponent();
            doubler = new Doubler();
            BtnPlus.Text = "+1";
            BtnMulti.Text = "x2";
            BtnReset.Text = "Сброс";
            BtnStart.Text = "Начать";
            BtnCancel.Text = "Отменить";
            BtnExit.Text = "Выйти";
            LabelNumber.Visible = false;
            LabelActions.Visible = false;
            LabelGoal.Visible = false;
            BtnPlus.Visible = false;
            BtnMulti.Visible = false;
            BtnReset.Visible = false;
            LabelNumber.Text = "0";
            LabelActions.Text = "0";
            this.Text = "Удвоитель";
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            doubler.Plus();
            Check();
            Upd();
        }
        private void BtnMulti_Click(object sender, EventArgs e)
        {
            doubler.Multi();
            Check();
            Upd();
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            doubler.Reset();
            Upd();
        }
        
        private void Upd()
        {
            LabelNumber.Text = doubler.Value.ToString();
            LabelActions.Text = doubler.Actions.ToString();
            this.Refresh();

        }

        private void Check()
        {
            if (doubler.CheckGoal() && !doubler.CheckGoalOutOfRange())
            {
                MessageBox.Show("Задача выполнена!");
                doubler.Reset();
            }
            else if (doubler.CheckGoalOutOfRange())
            {
                MessageBox.Show("Число больше требуемого. Игра окончена.");
                doubler.Reset();
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            doubler.SetGoal();
            MessageBox.Show($"Получите значение: {doubler.Goal}");
            LabelNumber.Visible = true;
            LabelActions.Visible = true;
            LabelGoal.Visible = true;
            BtnPlus.Visible = true;
            BtnMulti.Visible = true;
            BtnReset.Visible = true;
            LabelGoal.Text = doubler.Goal.ToString();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            doubler.CheckStack();
            Upd();
        }
    }
}

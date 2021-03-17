using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessGame
{
    public partial class Form1 : Form
    {
        GGNumber ggn = new GGNumber();
        public Form1()
        {
            InitializeComponent();
            LabelA.Text = "Введите число";
            LabelTries.Text = "Попытки";
            BtnStart.Text = "Проверить";
            BtnStart.Enabled = false;
            BtnGenerate.Text = "Сгенерировать число";
            BtnReset.Text = "Начать сначала";
            BtnReset.Visible = false;
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (int.TryParse(UserInput.Text, out int n))
            {
                ggn.CheckUserNumber(n, out string res);
                MessageBox.Show(res);
                LabelTries.Text = ggn.Tries.ToString();
            }
            else
            {
                MessageBox.Show("Не число");
            }
        }
        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            ggn.GenerateNumber();
            BtnGenerate.Visible = false;
            BtnReset.Visible = true;
            BtnStart.Enabled = true;
            UserInput.Enabled = true;
            LabelTries.Text = ggn.Tries.ToString();
            MessageBox.Show($"Загадано число {ggn.Number}");
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ggn.Reset();
            BtnReset.Visible = false;
            BtnGenerate.Visible = true;
            UserInput.Enabled = false;
            BtnStart.Enabled = false;
        }
    }
}

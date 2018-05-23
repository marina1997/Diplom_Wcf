using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace FormsWKR1
{
    public partial class algorithm_deutsch : Form
    {
        public algorithm_deutsch()
        {
            InitializeComponent();
        }
        int count;                                                                                 // Переменная для подсчета textbox
        private void run_Click(object sender, EventArgs e)
        {
            int answer;
                //ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            string matrix;                                                                         // Переменная, в которой хранится Оракул
            matrix = this.Controls["textbox" + 1.ToString()].Text;                                 // Заполнение Оракула
            for (count = 2; count <= 16; count++)
              {
                 if (this.Controls["textbox" + count.ToString()].Text.Length < 1)
                 {
                     MessageBox.Show("Входные данные некорректны");
                     return;
                 }
                 matrix = matrix + this.Controls["textbox" + count.ToString()].Text;
              }

            using (ServiceReference1.Service1Client client = new ServiceReference1.Service1Client())
            {
                answer = client.deutschStart(matrix);
            }
            FunctionMeasurement(answer);
            
        }
        private void FunctionMeasurement(int i)                                                  // Интерпретация и вывод результата. Пятый шаг 
        {
            if (i == 0) label1.Text = "Функция f константа";
            else label1.Text = "Функция f сбалансирована";
        }

        private void back_Click(object sender, EventArgs e)
        {
            main main_form = new main();
            main_form.Show();
            Hide();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            for (count = 1; count < 17; count++)                                                 // Цикл в котором очищаются все textBox
            {
                this.Controls["textbox" + count.ToString()].Text = "";
            }
            label1.Text = "";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar != 48 && e.KeyChar != 49 && number != 8) 
            {
                e.Handled = true;
                MessageBox.Show("Входные данные некорректны");
            }
        }

        private void textbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar != 48 && e.KeyChar != 49 && number != 8)
            {
                e.Handled = true;
                MessageBox.Show("Входные данные некорректны");
            }
        }

        private void textbox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar != 48 && e.KeyChar != 49 && number != 8 )
            {
                e.Handled = true;
                MessageBox.Show("Входные данные некорректны");
            }
        }

        private void textbox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar != 48 && e.KeyChar != 49 && number != 8 )
            {
                e.Handled = true;
                MessageBox.Show("Входные данные некорректны");
            }
        }

        private void textbox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar != 48 && e.KeyChar != 49 && number != 8)
            {
                e.Handled = true;
                MessageBox.Show("Входные данные некорректны");
            }
        }

        private void textbox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar != 48 && e.KeyChar != 49 && number != 8)
            {
                e.Handled = true;
                MessageBox.Show("Входные данные некорректны");
            }
        }

        private void textbox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar != 48 && e.KeyChar != 49 && number != 8)
            {
                e.Handled = true;
                MessageBox.Show("Входные данные некорректны");
            }
        }

        private void textbox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar != 48 && e.KeyChar != 49 && number != 8)
            {
                e.Handled = true;
                MessageBox.Show("Входные данные некорректны");
            }
        }

        private void textbox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar != 48 && e.KeyChar != 49 && number != 8)
            {
                e.Handled = true;
                MessageBox.Show("Входные данные некорректны");
            }
        }

        private void textbox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar != 48 && e.KeyChar != 49 && number != 8)
            {
                e.Handled = true;
                MessageBox.Show("Входные данные некорректны");
            }
        }

        private void textbox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar != 48 && e.KeyChar != 49 && number != 8)
            {
                e.Handled = true;
                MessageBox.Show("Входные данные некорректны");
            }
        }

        private void textbox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar != 48 && e.KeyChar != 49 && number != 8)
            {
                e.Handled = true;
                MessageBox.Show("Входные данные некорректны");
            }
        }

        private void algorithm_deutsch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textbox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar != 48 && e.KeyChar != 49 && number != 8)
            {
                e.Handled = true;
                MessageBox.Show("Входные данные некорректны");
            }
        }

        private void textbox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar != 48 && e.KeyChar != 49 && number != 8)
            {
                e.Handled = true;
                MessageBox.Show("Входные данные некорректны");
            }
        }

        private void textbox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar != 48 && e.KeyChar != 49 && number != 8)
            {
                e.Handled = true;
                MessageBox.Show("Входные данные некорректны");
            }
        }

        private void textbox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar != 48 && e.KeyChar != 49 && number != 8)
            {
                e.Handled = true;
                MessageBox.Show("Входные данные некорректны");
            }
        }
    }
}

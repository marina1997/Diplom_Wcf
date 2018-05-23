using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsWKR1
{
    public partial class algorithm_grover : Form
    {
        public algorithm_grover()
        {
            InitializeComponent();
        }

        int count;
        public List<string> answer_mas = new List<string>();                                // Хранятся все ответы

        private void run_Click(object sender, EventArgs e)
        {
            
                //ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            int N;                                                                          // Сколько раз будет выполняться вся программа
            int numberIterations;                                                           // Сколько раз будет выполняться итерация Гровера
            string array;                                                                   // Строка, в которой хранятся пространство поиска
            for (count = 1; count <= 10; count++)                                           // Проверка вводимых данных
                  if (this.Controls["textbox" + count.ToString()].Text.Length < 1)
                  {
                      MessageBox.Show("Входные данные некорректны");
                      return;
                  }
            array = this.Controls["textbox" + 1.ToString()].Text;                           // Заполнение Оракула
            string answer;
            for (count = 2; count <= 8; count++)
            {
                    array = array + this.Controls["textbox" + count.ToString()].Text;
            }
            N = Convert.ToInt32(textbox9.Text);                                             // Ввод количества выполнений алгоритма Гровера
            numberIterations = Convert.ToInt32(textbox10.Text);                             // Ввод количества выполнений итерации Гровера
            using (ServiceReference1.Service1Client client = new ServiceReference1.Service1Client())
            {
                for (count = 0; count < N; count++)
                {
                    answer = client.groverStart(array, numberIterations);
                    answer_mas.Add(answer);
                }
                //FunctionMeasurement(answer);
            }
            plotting();
        }
        private void plotting()
        {
            int sum;
            String[] answer_all = { "000", "001", "010", "011", "100", "101", "110", "111" };           // Все возможные ответы. Для построения графика


            chart1.Series[0].Points.Clear();                                                           // Очищение графика      
            for (int count = 0; count < answer_all.Length; count++)                                    // Построение Графика
            {
                sum = 0;
                for (int i = 0; i < answer_mas.Count; i++)
                {
                    if (answer_all[count] == answer_mas[i]) sum++;
                }
                chart1.Series[0].Points.AddXY(answer_all[count], sum);
            }
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;                                      // Убирется сетка у графика
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            answer_mas.Clear();                                                                        // Очищение списка

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            for (count = 1; count < 11; count++)                                                      // Цикл в котором очищаются все textBox и график
            {
                this.Controls["textbox" + count.ToString()].Text = "";
            }
            chart1.Series[0].Points.Clear();   
        }

        private void back_Click(object sender, EventArgs e)
        {
            main main_form = new main();
            main_form.Show();
            Hide();
        }

        private void textbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar != 48 && e.KeyChar != 49 && number != 8 )
            {
                e.Handled = true;
                MessageBox.Show("Входные данные некорректны");
            }
        }

        private void textbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar != 48 && e.KeyChar != 49 && number != 8 )
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
            if (e.KeyChar != 48 && e.KeyChar != 49 && number != 8 )
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
            if (e.KeyChar != 48 && e.KeyChar != 49 && number != 8 )
            {
                e.Handled = true;
                MessageBox.Show("Входные данные некорректны");
            }
        }

        private void textbox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar != 48 && e.KeyChar != 49 && number != 8 )
            {
                e.Handled = true;
                MessageBox.Show("Входные данные некорректны");
            }
        }

        private void textbox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 )
            {
                e.Handled = true;
                MessageBox.Show("Входные данные некорректны");
            }
        }

        private void textbox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
                MessageBox.Show("Входные данные некорректны");
            }
        }
    }
}

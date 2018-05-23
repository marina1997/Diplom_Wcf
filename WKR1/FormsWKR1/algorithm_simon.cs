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
    public partial class algorithm_simon : Form
    {
        public algorithm_simon()
        {
            InitializeComponent();
        }

        private List<string> answer_mas = new List<string>();                                // Массив, в котором хранятся все ответы
        private int N;                                                                       // Количество выполнений алгоритма
        private int count;
        private void run_Click(object sender, EventArgs e)
        {
            string answer;
            string matrix;                                                                   // Переменная, в которой хранится Оракул
            //int[] matrix = new int[] { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,  1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 , 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 , 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 , 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 } ;                                                                   // Переменная, в которой хранится Оракул
            int[] matrixInt = new int[256];                                                  // Массив для оракула
            
            for (count = 1; count <= 256; count++)                                           
            {
                if (this.Controls["textBox" + count.ToString()].Text.Length < 1)             // Проверка вводимых данных
                {
                    MessageBox.Show("Входные данные некорректны");
                    return;
                }
                matrix = this.Controls["textbox" + count.ToString()].Text;                  // Ввод оракула
                if (Convert.ToInt32(matrix)>=2)             // Проверка вводимых данных
                {
                    MessageBox.Show("Входные данные некорректны");
                    return;
                }
                matrixInt[count-1] = Convert.ToInt32(matrix);
            }

            if (this.Controls["textBox" + 300.ToString()].Text.Length < 1)                  // Проверка вводимых данных
            {
                MessageBox.Show("Входные данные некорректны");
                return;
            }
            N = Convert.ToInt32(textBox300.Text);                                              // Ввод количества выполнений алгоритма Саймона
            using (ServiceReference1.Service1Client client = new ServiceReference1.Service1Client())
            {
                client.Endpoint.Binding.SendTimeout = new TimeSpan(0, 2, 30);
                client.Endpoint.Binding.ReceiveTimeout = new TimeSpan(0, 2, 30);
                for (count = 0; count < N; count++)                                         // Вызов квантового алгоритма
                {
                    answer = Convert.ToString(client.simonStart(matrixInt));
                    answer_mas.Add(answer);
                }
            }
            plotting();                                                                     // Построение графика
        }
        private void plotting()
        {
            int sum;
            String[] answer_all = { "00", "01", "10", "11" };                                          // Все возможные ответы. Для построения графика


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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            main main_form = new main();
            main_form.Show();
            Hide();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            for (count = 1; count <= 256; count++)                                                      // Цикл в котором очищаются все textBox и график
            {
                this.Controls["textbox" + count.ToString()].Text = "";
            }
            this.Controls["textbox" + 300.ToString()].Text = "";
            chart1.Series[0].Points.Clear();   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar != 48 && e.KeyChar != 49 && number != 8)
            {
                e.Handled = true;
                MessageBox.Show("Входные данные некорректны");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace FormsWKR1
{
    public partial class algorithm_Shora : Form
    {
        public algorithm_Shora()
        {
            InitializeComponent();
        }

        private void run_Click(object sender, EventArgs e)
        {
            using (ServiceReference1.Service1Client client = new ServiceReference1.Service1Client())
            {
                client.Endpoint.Binding.SendTimeout = new TimeSpan(3, 1, 30);
                client.Endpoint.Binding.ReceiveTimeout = new TimeSpan(6, 1, 30);
            int numberToFactor;                                                                   // Число для факторизации
            numberToFactor = Convert.ToInt32(textBox1.Text);
            int registerLength;                                                                   // Число - количество кубитов
            registerLength = Convert.ToInt32(textBox2.Text);
            label1.Text=string.Join(",",client.shorStart(numberToFactor, registerLength));
            }
            //ServiceReference1.Service1Client client2 = new ServiceReference1.Service1Client();
            ////ServiceHost serviceHost = new ServiceHost(typeof(WKR1));
            //WSHttpBinding binding = new WSHttpBinding();
            //binding.OpenTimeout = new TimeSpan(0, 10, 0);
            //binding.CloseTimeout = new TimeSpan(0, 10, 0);
            //binding.SendTimeout = new TimeSpan(1, 0, 0);
            //binding.ReceiveTimeout = new TimeSpan(2, 0, 0);
            //LcrWebService pSrv = new LcrWebService();
            //pSrv.Credentials = System.Net.CredentialCache.DefaultCredentials;
            //pSrv.Timeout = 900000;
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
                MessageBox.Show("Входные данные некорректны");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
                MessageBox.Show("Входные данные некорректны");
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void back_Click(object sender, EventArgs e)
        {
            main main_form = new main();
            main_form.Show();
            Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void algorithm_Shora_Load(object sender, EventArgs e)
        {

        }
    }
}

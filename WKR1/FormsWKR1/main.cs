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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void deutsch_Click(object sender, EventArgs e)
        {
            algorithm_deutsch form_deutsch = new algorithm_deutsch();
            form_deutsch.Show();
            Hide();
        }

        private void algorithmGrover_Click(object sender, EventArgs e)
        {
            algorithm_grover form_grover = new algorithm_grover();
            form_grover.Show();
            Hide();
        }

        private void algorithmShora_Click(object sender, EventArgs e)
        {
            algorithm_Shora form_shora = new algorithm_Shora();
            form_shora.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void algorithmSimona_Click(object sender, EventArgs e)
        {
            algorithm_simon form_shora = new algorithm_simon();
            form_shora.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AboutProgr about_pr = new AboutProgr();
            about_pr.Show();
            Hide();
        }
    }
}

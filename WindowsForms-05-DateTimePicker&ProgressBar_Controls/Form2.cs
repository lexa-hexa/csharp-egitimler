using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_05_DateTimePicker_ProgressBar_Controls
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                int sayi = Convert.ToInt32(textBox1.Text);
                progressBar1.Maximum = sayi;
                for (int i = 0; i < sayi; i++)
                {
                    progressBar1.Value = i;
                }
            }
            else MessageBox.Show("Bir sayı giriniz!");
        }
    }
}

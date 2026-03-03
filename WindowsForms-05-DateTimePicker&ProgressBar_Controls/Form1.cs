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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = "İki tarih arasında " + (dateTimePicker2.Value - dateTimePicker1.Value).Days.ToString() + " gün vardır.";
            MessageBox.Show("İki tarih arasında " + (dateTimePicker2.Value - dateTimePicker1.Value).Days.ToString() + " gün vardır.");
        }
    }
}

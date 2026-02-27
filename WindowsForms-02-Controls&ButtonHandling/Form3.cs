using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_02_Controls_ButtonHandling
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();// Random rastgele değer üretmemizi sağlar
            this.BackColor = Color.FromArgb(random.Next(1, 256), random.Next(1, 256), random.Next(1, 256));

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 500;
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }

        private void Form3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MessageBox.Show("Form Kapatılacak!", "Uyarı!");
                this.Close();
            }
        }
    }
}

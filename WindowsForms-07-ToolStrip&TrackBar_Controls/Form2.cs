using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_07_ToolStrip_TrackBar_Controls
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //trackbar kontrolü değer artış ya da değer azalış işlemleri yaptırmamızı sağlar
            trackBar1.Minimum = 10;
            trackBar1.Maximum = 25;
            trackBar1.TickFrequency = 2;
            textBox1.Text = "Trackbar Kullanımı";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Palatino", trackBar1.Value);
        }
    }
}

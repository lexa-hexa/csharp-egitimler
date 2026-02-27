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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            //form2.Show();//Form2 penceresini göster 
            form2.ShowDialog();//Show dan farkı form2 yi açtığımızda bir önceki forma ikinci form ekranı kapanmadan açamıyorsun
            //this.Hide();formu kapatsanda arka planda çalışmaya devam eder
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Form ekranında mouse ile çift tıklayarak bu metodu oluşturduk
            this.Close(); //ilgili pencereyi kapat
            //Form1.ActiveForm.Close();
        }
    }
}

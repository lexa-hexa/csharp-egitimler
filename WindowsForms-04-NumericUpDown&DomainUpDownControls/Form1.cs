using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_04_NumericUpDown_DomainUpDownControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 10)
            {
                label1.Font = new Font("Tahoma", (float)numericUpDown1.Value);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++) 
            {
                domainUpDown1.Items.Add(FontFamily.Families[i].Name);//sistemdeki fontlardan 50 tanesini domainupdown a ekledik
            }
            domainUpDown1.Wrap = true;//liste sonunda ilk / son öğeye ilerle
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            //domainUpDown kontrolü içerisinde string ifadelerden oluşan liste tutar ve oklarla bu değerler arasında dolaşmamızı sağlar
            textBox1.Font = new Font(domainUpDown1.SelectedItem.ToString(), (float)numericUpDown1.Value);
        }
    }
}

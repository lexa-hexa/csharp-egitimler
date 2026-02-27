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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak istiyor musunuz?", "Uyarı!", MessageBoxButtons.OKCancel);
            if (sonuc == DialogResult.OK) 
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Çıkmak istiyor musunuz?", "Uyarı!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}

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
    public partial class PekistirmeForm : Form
    {
        public PekistirmeForm()
        {
            InitializeComponent();
        }

        private void PekistirmeForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak istiyor musun?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes) 
            {
                this.Close();
            }
            else { MessageBox.Show("İptal edildi!"); }
        }
    }
}

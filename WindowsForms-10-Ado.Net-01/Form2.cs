using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_10_Ado.Net_01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        CategoryDAL categoryDAL = new CategoryDAL();
        private void Form2_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Yukle()
        {
            dgvKategoriler.DataSource = categoryDAL.GetDataTable();
        }

        private void dgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dgvKategoriler.CurrentRow.Cells[0].Value.ToString();
            txtKategoriAdi.Text = dgvKategoriler.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            categoryDAL.Add(new Category { KategoriAdi = txtKategoriAdi.Text });
            Yukle();
            MessageBox.Show("Yeni kategori eklendi", "Bilgi!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            categoryDAL.Update(
                new Category
                {
                    Id = Convert.ToInt32(lblId.Text),
                    KategoriAdi = txtKategoriAdi.Text
                }
                );
            Yukle();
            MessageBox.Show("Seçilen kategori güncellenmiştir!", "Bilgi!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                categoryDAL.Delete(Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value.ToString()));
                Yukle();
                MessageBox.Show("Kategori silinmiştir.", "Bilgi!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
    }
}



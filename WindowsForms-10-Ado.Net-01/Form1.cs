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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDAL productDAL = new ProductDAL();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvUrunListesi.DataSource = productDAL.GetProducts();
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            productDAL.Add(
                new Product 
                {
                    UrunAdi = txtUrunAdi.Text,
                    UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text),
                    StokMiktari = Convert.ToInt32(txtStokMiktari.Text)
                }
                );
            dgvUrunListesi.DataSource = productDAL.GetProducts();
            MessageBox.Show("Ürün Eklendi!", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            productDAL.Update(
                new Product
                {
                    Id = Convert.ToInt32(lblId.Text),
                    UrunAdi = txtUrunAdi.Text,
                    UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text),
                    StokMiktari = Convert.ToInt32(txtStokMiktari.Text)
                }
                );
            dgvUrunListesi.DataSource = productDAL.GetProducts();
            MessageBox.Show("Ürün bilgileri güncellenmiştir!", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void dgvUrunListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dgvUrunListesi.CurrentRow.Cells[0].Value.ToString();
            txtUrunAdi.Text = dgvUrunListesi.CurrentRow.Cells[1].Value.ToString();
            txtUrunFiyati.Text = dgvUrunListesi.CurrentRow.Cells[2].Value.ToString();
            txtStokMiktari.Text = dgvUrunListesi.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) 
            {
                productDAL.Delete(Convert.ToInt32(dgvUrunListesi.CurrentRow.Cells[0].Value.ToString()));
                dgvUrunListesi.DataSource = productDAL.GetProducts();
                MessageBox.Show("Ürün silindi!", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
    }
}

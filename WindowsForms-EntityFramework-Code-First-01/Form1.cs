using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_EntityFramework_Code_First_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UrunDbContext urunDbContext = new UrunDbContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Yukle()
        {
            dgvUrunListesi.DataSource = urunDbContext.Products.ToList();
            cmbKategoriler.DataSource = urunDbContext.Categories.ToList();
        }
        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            urunDbContext.Products.Add(
                new Product
                {
                    StokMiktari = Convert.ToInt32(txtStokMiktari.Text),
                    UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text),
                    UrunAdi = txtUrunAdi.Text,
                    CategoryId = (int)cmbKategoriler.SelectedValue
                }
                );

            var sonuc = urunDbContext.SaveChanges();
            Yukle();
            if (sonuc > 0)
            {
                MessageBox.Show("Ekleme başarılı");
            }
            else
            {
                MessageBox.Show("Ekleme yaparken hata oluştu!");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvUrunListesi.CurrentRow.Cells[0].Value);
            var kayit = urunDbContext.Products.Find(id);

            kayit.UrunAdi = txtUrunAdi.Text;
            kayit.UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text);
            kayit.StokMiktari = Convert.ToInt32(txtStokMiktari.Text);

            var sonuc = urunDbContext.SaveChanges();
            Yukle();
            if (sonuc > 0) 
            {
                MessageBox.Show("Güncelleme başarılı");
            }
            else
            {
                MessageBox.Show("Güncellenirken bir hata oluştu!");
            }
        }

        private void dgvUrunListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvUrunListesi.CurrentRow.Cells[0].Value);
            var kayit = urunDbContext.Products.Find(id);

            txtUrunAdi.Text = kayit.UrunAdi;
            txtStokMiktari.Text = kayit.StokMiktari.ToString();
            txtUrunFiyati.Text = kayit.UrunFiyati.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvUrunListesi.CurrentRow.Cells[0].Value);
            var kayit = urunDbContext.Products.Find(id);

            urunDbContext.Products.Remove(kayit);

            var sonuc = urunDbContext.SaveChanges();
            Yukle();
            if (sonuc > 0) 
            {
                MessageBox.Show("Silme başarılı");
            }
            else
            {
                MessageBox.Show("Silinirken bir hata oluştu");
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            dgvUrunListesi.DataSource = urunDbContext.Products.Where(p => p.UrunAdi.Contains(txtArama.Text)).ToList();
        }

        private void dgvUrunListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

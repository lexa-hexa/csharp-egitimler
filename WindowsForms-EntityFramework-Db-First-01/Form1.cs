using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_EntityFramework_Db_First_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UrunYonetimiEntities urunYonetimi = new UrunYonetimiEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Yukle()
        {
            dgvUrunListesi.DataSource = urunYonetimi.Products.ToList();
        }
        private void dgvUrunListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvUrunListesi.CurrentRow.Cells[0].Value);
            var kayit = urunYonetimi.Products.Find(id);
            txtStokMiktari.Text = kayit.StokMiktari.ToString();
            txtUrunAdi.Text = kayit.UrunAdi;
            txtUrunFiyati.Text = kayit.UrunFiyati.ToString();
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            urunYonetimi.Products.Add(
                new Product
                {
                    UrunAdi = txtUrunAdi.Text,
                    StokMiktari = Convert.ToInt32(txtStokMiktari.Text),
                    UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text)
                }
                );

            var sonuc = urunYonetimi.SaveChanges();//Ürünleri db ye yüklemek için bu bölümü eklememiz gerekmektedir.

            Yukle();
            if (sonuc > 0)
            {
                MessageBox.Show("Ürün eklendi!");
            }
            else { MessageBox.Show("Ürün eklerken hata oldu!");}
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvUrunListesi.CurrentRow.Cells[0].Value);
            var kayit = urunYonetimi.Products.Find(id);

            kayit.UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text);
            kayit.StokMiktari = Convert.ToInt32(txtStokMiktari.Text);
            kayit.UrunAdi = txtUrunAdi.Text;

            var sonuc = urunYonetimi.SaveChanges();//Ürünleri db ye yüklemek için bu bölümü eklememiz gerekmektedir.

            Yukle();
            if (sonuc > 0)
            {
                MessageBox.Show("Ürün güncellendi!");
            }
            else { MessageBox.Show("Ürün güncellerken hata oldu!"); }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvUrunListesi.CurrentRow.Cells[0].Value);
            var kayit = urunYonetimi.Products.Find(id);

            urunYonetimi.Products.Remove(kayit);

            var sonuc = urunYonetimi.SaveChanges();//Ürünleri db ye yüklemek için bu bölümü eklememiz gerekmektedir.

            Yukle();
            if (sonuc > 0)
            {
                MessageBox.Show("Ürün silindi!");
            }
            else { MessageBox.Show("Ürün silinirken hata oldu!"); }
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            dgvUrunListesi.DataSource = urunYonetimi.Products.Where(u => u.UrunAdi.Contains(txtArama.Text)).ToList();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            dgvUrunListesi.DataSource = urunYonetimi.Products.Where(u => u.UrunAdi.Contains(txtArama.Text)).ToList();
        }
    }
}

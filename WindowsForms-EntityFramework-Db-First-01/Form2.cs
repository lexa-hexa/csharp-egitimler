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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        UrunYonetimiEntities urunYonetimi = new UrunYonetimiEntities();
        void Yukle()
        {
            dgvKategoriler.DataSource = urunYonetimi.Categories.ToList();
        }
        void Temizle()
        {
            txtKategoriAdi.Clear();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        private void dgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value);
            var kayit = urunYonetimi.Categories.Find(id);

            txtKategoriAdi.Text = kayit.KategoriAdi;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value);
            var kayit = urunYonetimi.Categories.Find(id);

            urunYonetimi.Categories.Add(
                new Category
                {
                    KategoriAdi = txtKategoriAdi.Text
                }
                );

            var sonuc = urunYonetimi.SaveChanges();
            Yukle();
            if(sonuc > 0)
            {
                MessageBox.Show("Kategori eklendi!");
                Temizle();
            }
            else { MessageBox.Show("Kategori eklerken hata oldu!"); }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value);
            var kayit = urunYonetimi.Categories.Find(id);

            kayit.KategoriAdi = txtKategoriAdi.Text;

            var sonuc = urunYonetimi.SaveChanges();
            Yukle();
            if (sonuc > 0) 
            {
                MessageBox.Show("Kategori güncellendi!");
                Temizle();

            }
            else { MessageBox.Show("Kategori güncellenirken hata oluştu!");}
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // DataGridView'de (dgvKategoriler) seçili olan satırın ilk hücresindeki (ID) değeri alıp int'e çeviriyoruz
            int id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value);
            // Alınan bu ID'ye göre veritabanındaki Categories tablosundan ilgili kaydı buluyoruz
            var kayit = urunYonetimi.Categories.Find(id);

            urunYonetimi.Categories.Remove(kayit);

            var sonuc = urunYonetimi.SaveChanges();
            Yukle();
            if(sonuc > 0)
            {
                MessageBox.Show("Kategori adı silindi!");
                Temizle();
            }
            else { MessageBox.Show("Kategori adı silinirken hata oluştu!");}
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            dgvKategoriler.DataSource = urunYonetimi.Categories.Where(k => k.KategoriAdi.Contains(txtAra.Text)).ToList();
        }
    }
}

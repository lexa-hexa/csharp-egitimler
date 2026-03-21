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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        UrunDbContext urunDbContext = new UrunDbContext();
        private void Form2_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Yukle()
        {
            dgvKategoriler.DataSource = urunDbContext.Categories.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            urunDbContext.Categories.Add(
                new Category
                {
                    KategoriAdi = txtKategoriAdi.Text
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
                MessageBox.Show("Ekleme yaparken bir hata oluştu");
            }
        }

        private void dgvKategoriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value);
            var kayit = urunDbContext.Categories.Find(id);

            txtKategoriAdi.Text = kayit.KategoriAdi;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value);
            var kayit = urunDbContext.Categories.Find(id);

            kayit.KategoriAdi = txtKategoriAdi.Text;

            var sonuc = urunDbContext.SaveChanges();
            Yukle();
            if (sonuc > 0)
            {
                MessageBox.Show("Kategori eklendi");
            }
            else
            {
                MessageBox.Show("Kategori eklenirken hata oldu");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value);
            var kayit = urunDbContext.Categories.Find(id);

            urunDbContext.Categories.Remove(kayit);

            var sonuc = urunDbContext.SaveChanges();
            Yukle();
            if (sonuc > 0) 
            {
                MessageBox.Show("Silme başarılı");
            }
            else
            {
                MessageBox.Show("İşlem başarısız");
            }

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            dgvKategoriler.DataSource = urunDbContext.Categories.Where(c => c.KategoriAdi.Contains(txtAra.Text)).ToList();
        }
    }
}

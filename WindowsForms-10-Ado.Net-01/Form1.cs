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
            //dgvUrunListesi.DataSource = productDAL.GetProducts(); --> List ile veri listeleme
            dgvUrunListesi.DataSource = productDAL.GetTable();//--> DataTable ile veri listeleme
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception hata)
            {
                //Burada error. veritabanına kaydedebiliriz
                MessageBox.Show("Hata oluştu!" + hata.ToString());
            }
            finally
            {
                //Burası try-catch denendikten sonra son blok olarak 

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu!");
            }

        }

        private void dgvUrunListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblId.Text = dgvUrunListesi.CurrentRow.Cells[0].Value.ToString();
                txtUrunAdi.Text = dgvUrunListesi.CurrentRow.Cells[1].Value.ToString();
                txtUrunFiyati.Text = dgvUrunListesi.CurrentRow.Cells[2].Value.ToString();
                txtStokMiktari.Text = dgvUrunListesi.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu!");
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    productDAL.Delete(Convert.ToInt32(dgvUrunListesi.CurrentRow.Cells[0].Value.ToString()));
                    dgvUrunListesi.DataSource = productDAL.GetProducts();
                    MessageBox.Show("Ürün silindi!", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    MessageBox.Show("Hata oluştu!");
                }
            }

        }
    }
}
// ==========================================================
// TRY - CATCH - FINALLY MEKANİZMASI
// ==========================================================
// Bu yapı C# dilinde oluşabilecek hataları (Exception) kontrol altına almak
// ve programın beklenmedik şekilde çökmesini engellemek için kullanılır.
// Hata yönetimi (Exception Handling) yazılım geliştirmede kritik bir konudur.
// ==========================================================


// TRY BLOĞU
// ----------------------------------------------------------
// Hata oluşma ihtimali bulunan kodlar bu blok içerisine yazılır.
// Program çalışırken bir problem meydana gelirse kontrol doğrudan
// catch bloğuna aktarılır.
//
// Örnek durumlar:
// - Kullanıcının sayı yerine metin girmesi
// - Dosya bulunamaması
// - Veritabanı bağlantı hatası
// - Null referans hataları
//
// try bloğunun amacı programın kontrolünü kaybetmemektir.
// ----------------------------------------------------------


// CATCH BLOĞU
// ----------------------------------------------------------
// try bloğu içerisinde bir hata oluştuğunda devreye girer.
// Oluşan hatayı yakalar ve programın güvenli şekilde devam etmesini sağlar.
//
// catch bloğunda genellikle:
// - Kullanıcıya hata mesajı gösterilir
// - Loglama yapılır
// - Alternatif bir işlem gerçekleştirilir
//
// Birden fazla catch kullanılabilir ve farklı hata türleri yakalanabilir.
// Örneğin:
// catch (FormatException)
// catch (NullReferenceException)
// catch (SqlException)
// ----------------------------------------------------------


// FINALLY BLOĞU
// ----------------------------------------------------------
// try veya catch çalıştıktan sonra HER ZAMAN çalışır.
// Hata oluşsa da oluşmasa da bu blok kesin olarak yürütülür.
//
// Genellikle kaynak temizleme işlemleri için kullanılır:
//
// - Dosya kapatma
// - Veritabanı bağlantısını kapatma
// - Bellek temizleme
// - Ağ bağlantısını sonlandırma
//
// Bu sayede sistem kaynakları güvenli şekilde serbest bırakılır.
// ----------------------------------------------------------


// Kısaca akış şu şekildedir:
//
// try      -> Riskli kod çalıştırılır
// catch    -> Hata yakalanır ve yönetilir
// finally  -> Temizlik işlemleri yapılır
//
// Bu yapı sayesinde uygulamalar daha güvenli, stabil ve
// hatalara karşı dayanıklı hale gelir.
// ==========================================================

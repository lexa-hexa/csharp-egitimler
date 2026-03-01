using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_03_KullaniciGirisEkrani
{
    public partial class Form1 : Form
    {
        int hak = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (hak <= 0) return;
            if (!AlanlarDoluMu()) return;
            if (!GirisBasariliMi()) return;
        }
        private bool AlanlarDoluMu()
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text))//Kullanıcı adı boşsa
            {
                MessageBox.Show("Kullanıcı adı boş geçilemez!");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Şifre boş geçilemez");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtKullaniciKodu.Text))
            {
                MessageBox.Show("Kullanıcı kodu boş geçilemez");
                return false;
            }
            else { return true; }
        }
        private bool GirisBasariliMi()
        {
            string veritabanindakiKullaniciAdi = "Enes";
            string veritabanindakiSifre = "123456";
            string veritabanindakiKullaniciKodu = "Axd1234";

            if (txtKullaniciAdi.Text == veritabanindakiKullaniciAdi && txtKullaniciKodu.Text == veritabanindakiKullaniciKodu && txtSifre.Text == veritabanindakiSifre)
            {                
                MessageBox.Show("Hoşgeldin " + txtKullaniciAdi.Text);
                groupBox1.Visible = false;
                return true;
            }
            else
            {
                hak--;
                HakGuncelle();
                if (hak > 0)
                {
                    
                    MessageBox.Show($"Hatalı giriş. Kalan hak: {hak}", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                else
                {                    
                    btnGiris.Enabled = false;
                    txtKullaniciAdi.Enabled = false;
                    txtSifre.Enabled = false;
                    txtKullaniciKodu.Enabled = false;
                    MessageBox.Show("3 Kez hatalı giriş yapıldı! Hesabınız kilitlenmiştir.");
                    return false;
                }
            }
        }
        private void HakGuncelle()
        {
            KalanHak.Text = "Kalan Hak: " + hak;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HakGuncelle();
        }
    }
}

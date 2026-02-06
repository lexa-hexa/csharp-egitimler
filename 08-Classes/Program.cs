using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _08_Classes
{
    //- Sınıf (Class) soyut veri tipidir. Nesne (object) onun somutlaşan bir cismidir.
    class Ev // Ev isminde soyut bir sınıf oluşturuyoruz
    {
        internal int kapiNo;
        internal string SokakAdi;
        internal string Ilce;
        internal string Sehir;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ev ilkEv = new Ev(); // Ev sınıfından ilkEv isminde bir nesne türetiyoruz
            ilkEv.Ilce = "Kadıköy";
            ilkEv.Sehir = "İstanbul";
            ilkEv.SokakAdi = "Sahil Sk.";
            ilkEv.kapiNo = 23;

            Console.WriteLine("Ev adresi: " + ilkEv.SokakAdi + "\n kapı no: " + ilkEv.kapiNo);

            Ev memlekettekiEv = new Ev()
            {
                kapiNo = 21,
                Sehir = "Bartın",
                SokakAdi = "Fener Sk."
            };
            memlekettekiEv.Ilce = "Arıt";
            Console.WriteLine("Ev adresi: {0}\nKapı No: {1}", memlekettekiEv.SokakAdi, memlekettekiEv.kapiNo);

            Kullanici yeniKullanici = new Kullanici();
            yeniKullanici.Aktif = true;
            yeniKullanici.KullaniciAdi = "admin";
            yeniKullanici.Sifre = "enes123";

            Console.WriteLine($"Kullanıcı aktif mi? : { yeniKullanici.Aktif }\n Kullanıcı Adı: {yeniKullanici.KullaniciAdi} \n Şifreniz: {yeniKullanici.Sifre}");

            yeniKullanici.EkranaYaziYaz("Merhaba Dünya!");//Console.ReadLine() kullansanda işe yarar
            Console.WriteLine("İki sayının toplamı: " + yeniKullanici.ToplamaYap(10, 8));

            Console.WriteLine(Kullanici.SinifDegiskeni);

            Console.WriteLine("Lütfen mail adresinizi giriniz!");
            var mailAdresi = Console.ReadLine();
            var islemSonucu = yeniKullanici.MailGonder(mailAdresi);
            if (islemSonucu == true)
            {
                Console.WriteLine("Mailiniz başarıyla gönderilmiştir.");
            }
            else Console.WriteLine("Mail adresi boş olamaz!");

            /*----------Banka Hesabı Örnek Proje---------------------------*/
            BankaHesabi hesap = new BankaHesabi();
            hesap.HesapNo = "TR-12 3451 6789 01";
            hesap.Bakiye = 1000;

            Console.WriteLine($"Hesap No: {hesap.HesapNo}");
            Console.WriteLine($"Hesap Bakiyesi: {hesap.Bakiye}");

            Console.WriteLine("Yatırmak istediğiniz tutarı giriniz:");
            var yatirmaSonucu = hesap.ParaYatir(Convert.ToDecimal(Console.ReadLine()));
            Console.WriteLine("Yatırma sonucu: " + yatirmaSonucu);
            Console.WriteLine("GÜncel bakiye: " + hesap.Bakiye);

            Console.WriteLine("Yatırmak istediğiniz tutarı giriniz:");
            var cekmeSonucu = hesap.ParaCek(Convert.ToDecimal(Console.ReadLine()));
            Console.WriteLine("Çekme sonucu: " + cekmeSonucu);
            Console.WriteLine("Güncel bakiye: " + hesap.Bakiye);

            Console.Read();
        }
    }
}

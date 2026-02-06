using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Classes
{
    internal class Kullanici
    {
        //- ctor yazıp iki defa tab tuşuna basarsak constructor açmış oluruz
        //- Eğer bir class ta kurucu metot varsa ilk o çalışır
        string KurucuMetot;
        public Kullanici()// constructor kurucu metot
        {
            KurucuMetot = "Sınıflarda constructor (kurucu metot) özelliği vardır ve bu metotlar sınıftan bir nesne oluşturulduğunda otomatik olarak çalışır ve içerisindeki kodları çalıştırır. Kurucu metotlar değişkenler gibi veri tipi almazlar ve void ifadesi de bulunmaz, sınıfın adıyla aynı ad kullanılarak oluşturulur."; //Yukarıda tanımladığımız kurucuMetot değişkenine sınıfımızın kurucu metodunda değer ataması yaptık
            Console.WriteLine(KurucuMetot);
        }
        public int Id;
        public string KullaniciAdi;
        public string Sifre;
        public bool Aktif;

        public void EkranaYaziYaz(string ekranaYazilacakYazi)
        {
            Console.WriteLine(ekranaYazilacakYazi);
        }
        public int ToplamaYap(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public bool MailGonder(string mail)
        {
            if (!string.IsNullOrWhiteSpace(mail)) 
            {
                //Mail gönderme kodları burada olacak
                return true;
            }
            else return false;
        }

        public static string SinifDegiskeni = "Sınıflarda metot ve değişken de kullanabiliriz.";

    }
}

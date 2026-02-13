using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _11_Structs
{
    struct yapi
    {
        //public string ad = "Enes"; //struct kullanımında class dan farklı olarak öğelere başlangıç değeri atanamaz
        public int sayi;
        public string metin;
        public void Metot()
        {
            Console.WriteLine("yapı içindeki metot");
        }
    }
    internal class Program
    {
        //Urun örnek projedir
        struct Urun
        {
            public string UrunAdi;
            public decimal Fiyat;
            public int Stok;

            public string BilgiYazdir()
            {
                return $"UrunAdi: {UrunAdi}, Fiyat: {Fiyat}, Stok: {Stok}";
            }
        }
        struct Kimlik
        {
            public string ad;
            public string soyad;
            public int yas;
            public string dogumYeri;

            public struct Adres
            {
                public int Id { get; set; }
                public int KapiNo { get; set; }
                public string Sehir { get; set; }
                public string Ilce { get; set; }
                public string AcikAdres { get; set; }
            }
        }


        static void Main(string[] args)
        {
            //Struct ile yapı kurma
            Kimlik kimlik = new Kimlik();
            kimlik.ad = "Enes";
            kimlik.soyad = "Yerebakan";
            kimlik.dogumYeri = "Bartın";
            kimlik.yas = 23;

            Console.WriteLine("Kimlik Bilgileri");
            Console.WriteLine("Ad: {0}, Soyad: {1}", kimlik.ad, kimlik.soyad);
            Console.WriteLine("Doğum Yeri: " + kimlik.dogumYeri);
            Console.WriteLine($"Yaş: {kimlik.yas}");

            Console.WriteLine("-------------------------------------");

            Urun urun = new Urun();
            urun.UrunAdi = "Telefon";
            urun.Fiyat = 57500;
            urun.Stok = 28;

            Console.WriteLine(urun.BilgiYazdir());
            Console.WriteLine("------------------------------------");
            Console.WriteLine("C# class vs struct FARKI");
            Console.WriteLine("Özellik\t\t\tstruct\t\t\t\tclass");
            Console.WriteLine("RAM davranışı\t\tKopyalanır\t\t\tReferanslanır");
            Console.WriteLine("Metoda giderken\t\tKopyası gider\t\t\tKendisi gider");
            Console.WriteLine("Değişiklik\t\tSadece kopyayı etkiler\t\tHer yeri etkiler");
            Console.WriteLine("------------------------------------");

            Console.Read();
        }
    }
}

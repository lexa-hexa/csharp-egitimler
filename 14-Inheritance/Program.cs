using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Inheritance
{
    //Kalıtım - Inheritance 
    class AtaSinif
    {
        public AtaSinif()
        {
            Console.WriteLine("AtaSinif kurucu metodu çalıştı.");
        }
        public void Yaz()
        {
            Console.WriteLine("AtaSinif Yaz metodu çalıştı.");
        }
    }
    //AtaSinif'tan OgulSinif'a kalıtım yapıldı. OgulSinif, AtaSinif'ın tüm özelliklerini ve metotlarını miras alır.
    class OgulSinif : AtaSinif
    {
        public OgulSinif()
        {
            Console.WriteLine("OgulSinif kurucu metodu çalıştı.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            OgulSinif ogul = new OgulSinif();
            ogul.Yaz(); // OgulSinif, AtaSinif'tan miras aldığı Yaz() metodunu kullanabilir.

            ApartmanKati apartmanKati = new ApartmanKati();
            apartmanKati.sahip = "Mehmet Bey";
            apartmanKati.EvSahibiniYaz(apartmanKati.sahip);

            apartmanKati.apartmanYoneticisi = "Ahmet Bey";
            apartmanKati.ApartmanYoneticisiniYaz(apartmanKati.apartmanYoneticisi);

            Cizici[] birCizici = new Cizici[4];
            birCizici[0] = new DogruCiz();
            birCizici[1] = new DaireCiz();
            birCizici[2] = new KareCiz();
            birCizici[3] = new Cizici();

            foreach (var item in birCizici)
            {
                item.Ciz();
            }

            Console.Read();
        }
    }
    class Ev
    {
        public string sahip;
        public void EvSahibiniYaz(string sahip)
        {
            Console.WriteLine("Ev sahibi: " + sahip);
        }
    }
    class ApartmanKati : Ev
    {
        internal string apartmanYoneticisi;
        public void ApartmanYoneticisiniYaz(string yonetici)
        {
            Console.WriteLine("Apartman Yöneticisi: " + yonetici);
        }
    }
    //Polimorfizm (Çok Biçimlilik) - Polymorphism
    public class Cizici
    {
        public virtual void Ciz() // virtual anahtar kelimesi, bu metotun alt sınıflarda geçersiz kılınabileceğini belirtir.
        {
            Console.WriteLine("Çizici");
        }
    }
    public class DogruCiz : Cizici
    {
        public override void Ciz() // override anahtar kelimesi ile ciz metodumuzu ezerek farklı çıktı üretmesini sağladık
        {
            Console.WriteLine("Düz çizgi");
        }
    }
    public class DaireCiz : Cizici
    {
        public override void Ciz() // override anahtar kelimesi ile ciz metodumuzu ezerek farklı çıktı üretmesini sağladık
        {
            Console.WriteLine("Daire");
        }
    }
    public class KareCiz : Cizici
    {
        public override void Ciz() // override anahtar kelimesi ile ciz metodumuzu ezerek farklı çıktı üretmesini sağladık
        {
            Console.WriteLine("Kare");
        }
    }
}

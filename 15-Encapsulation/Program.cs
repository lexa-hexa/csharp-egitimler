using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Encapsulation
{
    //Metot Kullanarak Kapsülleme
    class Bolum
    {
        private string BolumAdi;//dışarıdan erişime kapalı değişkenimiz.
        //Accessor (Getter)
        public string GetBolumAdi()
        {
            return BolumAdi;
        }
        //Mutator (Setter)
        public void SetBolumAdi(string a)
        {
            if (a == "Programlama")
            {
                Console.WriteLine("Okulumuzda {0} bölümü bulunmamaktadır!", a);
            }
            else BolumAdi = a;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bölüm adınızı giriniz");
            var bolumAdi = Console.ReadLine();

            /*----------Metot Kullanarak Kapsülleme
            Bolum bolum = new Bolum();
            
            var bolumAdi = Console.ReadLine();
            bolum.SetBolumAdi(bolumAdi);

            Console.WriteLine("Seçilen bölüm adı: " + bolum.GetBolumAdi());
            */

            /* ----------Property Kullanarak Kapsülleme
            Fakulte fakulte = new Fakulte();
            fakulte.Bolum = bolumAdi;
            Console.WriteLine("Seçilen bölüm adı: " + fakulte.Bolum);
            */

            /*----------Read Only property Kullanarak Kapsülleme
            Universite universite = new Universite(bolumAdi);
            Console.WriteLine("Seçtiğiniz bölüm: " + universite.Bolum);
            */

            YuksekOkul yuksekOkul = new YuksekOkul();
            yuksekOkul.Bolum = bolumAdi;

            Console.Read();
        }
    }
    //Özgen (Property) kullanarak kapsülleme
    class Fakulte
    {
        private string bolum;
        public string Bolum
        {
            get { return bolum; }
            set 
            {
                if (value == "Programlama")
                {
                    Console.WriteLine("Okulumuzda {0} bölümü bulunmamaktadır!", value);
                }
                else bolum = value;
            }
        }
    }

    //Yalnız okunur (Read only property)
    class Universite
    {
        private string bolum;
        public Universite(string str)
        {
            bolum = str;
        }
        public string Bolum
        {
            get { return bolum; }
        }
    }
    //Write Only property
    class YuksekOkul
    {
        private string bolum;
        public string Bolum
        {
            set 
            {
                bolum = value;
                Console.WriteLine("Seçtiğiniz bölüm: " + bolum);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metotlar Konusu (Methods)
            //İlk başta sadece toplamayap metodu kullandım sonra geliştirerek bunu ilk kullanıcıdan hangi işlemi yapmak istediğini sordum sonra da işlem metotlarını ekledim.
            //void, metotlar geriye değer döndürmez.
            //static ise bu metotların nesne oluşturmadan çağrılabilmesini sağlar.
            //Main metodu static olduğu için, içerisinden çağrılan metotların da static olması gerekir.            
            /*-------------------DÖRT İŞLEM--------------------------------*/
            Console.WriteLine("Bana hangi işlemi yapacağını söyle");
            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Çıkarma");
            Console.WriteLine("3 - Bölme");
            Console.WriteLine("4 - Çarpma");
            Console.WriteLine("5 - Çıkış");

            int giris = Convert.ToInt32(Console.ReadLine());
            if (giris == 1)
            {
                ToplamaYap();
            }
            else if (giris == 2)
            {
                CikarmaYap();
            }
            else if (giris == 3)
            {
                BolmeYap();
            }
            else if (giris == 4)
            {
                CarpmaYap();
            }
            else if (giris == 5)
            {
                Console.WriteLine("Çıkış Yapılıyor...");
            }
            else { Console.WriteLine("Hatalı değer girdiniz!"); }
           /*---------------------------------------------------*/
           //Geriye değer döndüren metot 
           //Örnek küçük harfleri yazdıran metot
            Console.WriteLine("Bir cümle yazınız.");
            string s = Console.ReadLine();
            Console.WriteLine("Küçük harf sayısı: " + kucukHarfSay(s));

            //Örnek Büyük harfleri yazdıran metot
            Console.WriteLine("Bir cümle tekrar yazın.");
            string B = Console.ReadLine();
            Console.WriteLine("Büyük Harf sayısı: " + buyukHarfSay(B));




                // Metot                       Ne kontrol eder
                // char.IsLower(c)             Küçük harf mi ? (a - z)
                // char.IsUpper(c)             Büyük harf mi ? (A - Z)
                // char.IsDigit(c)             Rakam mı? (0 - 9)
                // char.IsLetter(c)            Harf mi? (büyük + küçük)
                // char.IsWhiteSpace(c)        Boşluk mu?
            

            //Örnek 2
            Console.WriteLine("Bana büyük harf, küçük harf ve rakamların olduğu karışık bir yazı yaz.");
            string METIN = Console.ReadLine();
            Console.WriteLine("Büyük harf sayısı: " + BuyukHarfSay(METIN));
            Console.WriteLine("Küçük harf sayısı: " + kucukharfsay(METIN));
            Console.WriteLine("Rakam sayısı: " + rakamSay(METIN));
            

            //Yöntem 1 = birlestir("Enes", soyad: "Yerebakan");

            Console.WriteLine("Lütfen Mail adresinizi girin.");
            var email = Console.ReadLine();
            if (MailGonder(email) == false)
            {
                Console.WriteLine("Mail adresi boş geçilemez!");
            }
            else Console.WriteLine("Mail Kabul Edildi!");


            Console.Read();
        }
        /*----------------------DÖRT İŞLEM------------------------------------*/
        static void ToplamaYap()
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen bir sayı daha giriniz: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İşlem sonucu: " + (sayi1 + sayi2));
        }
        static void CikarmaYap()
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            double sayi3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen bir sayı daha giriniz: ");
            double sayi4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İşlem sonucu: " + (sayi3 - sayi4));
        }
        static void BolmeYap()
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            double sayi5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen bir sayı daha giriniz: ");
            double sayi6;
            do
            {
                sayi6 = Convert.ToDouble(Console.ReadLine());
                if (sayi6 == 0)
                {
                    Console.WriteLine("0 ile bölme yapılamaz! Lütfen geçerli bir değer giriniz!");
                }
            } while (sayi6 == 0);
            
            

            Console.WriteLine("İşlem sonucu: " + (sayi5 / sayi6));
        }
        static void CarpmaYap()
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            double sayi7 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen bir sayı daha giriniz: ");
            double sayi8 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İşlem sonucu: " + (sayi7 * sayi8));
        }
        /*------------------------------------------------------------------*/
        
        static int kucukHarfSay(string s)//Geriye int veri tipinde değer döndüren ve parametre olarak string değişken alan metot
        {
            int kucukHarfSayisi = 0;
            foreach (char harf in s)
            {
                if(char.IsLower(harf)) kucukHarfSayisi++;                
            }
            return kucukHarfSayisi;// Geriye döndürülen değer
        }
        //Örnek 1
        static int buyukHarfSay(string B)
        {
            int buyukHarfSay = 0;
            foreach (char harf in B)
            {
                if(char.IsUpper(harf)) buyukHarfSay++;
            }return buyukHarfSay;
        }

        //Örnek 2
        static int BuyukHarfSay(string METIN)
        {
            int BuyukHarfSayisi = 0;
            foreach (char bHarf in METIN)
            {
                if(char.IsUpper(bHarf)) BuyukHarfSayisi++;
            }return BuyukHarfSayisi;
        }
        static int kucukharfsay(string METIN)
        {
            int kucukharfsayisi = 0;
            foreach (char kHarf in METIN)
            {
                if(char.IsLower(kHarf)) kucukharfsayisi++;
            }return kucukharfsayisi;
        }
        static int rakamSay(string METIN)
        {
            int rakamSayisi = 0;
            foreach (char rakam in METIN)
            {
                if(char.IsDigit(rakam)) rakamSayisi++;
            }return rakamSayisi;
        }
        /*-------------------------------------------------------*/
        static void birlestir(string ad, string soyad) // Birleştir ismini verdiğimiz metot dışarıdan iki adet parametre alıyor ad ve soyad
        {
            Console.WriteLine("Hoşgeldin " + ad + " " + soyad); // Parametreden gelen değerleri önüne tanımlama yazıp birleştirerek ekrana yazıyor 
        }

        static bool MailGonder(string mailAdresi)
            {
                if (!string.IsNullOrWhiteSpace(mailAdresi)) //Eğer mailAdresi değişkenine bir değer girilmişse, yani mail adresi boş değilse 
                {
                    return true;//Geriye True değer döndür
                }
                else return false;//mailAdresi değişkeni boşsa geriye False değer döndür
            }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Methods_TextAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secim;
            do
            {
                Console.WriteLine("Merhabalar, yapmak istediğin işlemi seçer misin?");
                Console.WriteLine("1 - Yazınızdaki küçük harfleri saydırmak");
                Console.WriteLine("2 - Yazınızdaki büyük harfleri saydırmak");
                Console.WriteLine("3 - Yazınızdaki rakamları saymak");
                Console.WriteLine("4 - Boşlukları saymak");
                Console.WriteLine("5 - Harfleri saymak");
                Console.WriteLine("6 - Metin kontrolü");
                Console.WriteLine("7 - Metin birleştirme");
                Console.WriteLine("8 - İşlem sonlandırmak");

                if (!int.TryParse(Console.ReadLine(), out secim))
                {
                    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz!");
                    continue;
                }

                switch (secim)
                {

                    case 1:
                        {
                            Console.WriteLine("Metin giriniz: ");
                            string metin = Console.ReadLine();
                            Console.WriteLine("Yazdığınız metindeki küçük harf sayısı: " + kucukDegerSay(metin));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Metin giriniz: ");
                            string metin = Console.ReadLine();
                            Console.WriteLine("Yazdığınız metindeki büyük harf sayısı: " + buyukDegerSay(metin));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Metin giriniz: ");
                            string metin = Console.ReadLine();
                            Console.WriteLine("Yazdığınız metindeki rakam sayısı: " + rakamSay(metin));
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Metin giriniz: ");
                            string metin = Console.ReadLine();
                            Console.WriteLine("Yazdığınız yazıdaki boşluk sayısı: " + boslukSay(metin));
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Metin giriniz: ");
                            string metin = Console.ReadLine();
                            Console.WriteLine("Yazdığınız yazıdaki harf sayısı: " + harfSay(metin));
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Metin giriniz: ");
                            string metin = Console.ReadLine();
                            Console.WriteLine(MetinGecerliMi(metin) ? "Doğru yazım" : "Yanlış yazım");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Adınız: ");
                            string ad = Console.ReadLine();
                            Console.WriteLine("Soyadınız: ");
                            string soyad = Console.ReadLine();
                            birlestir(ad, soyad);
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Çıkış yapılıyor...");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Hatalı seçim! 1-8 arası giriniz.");
                            break;
                        }
                }

            } while (secim != 8);

            Console.Read();
        }

        static int buyukDegerSay(string metin)
        {
            int buyukDegerSay = 0;
            foreach (char harf in metin)
            {
                if (char.IsUpper(harf)) buyukDegerSay++;
            }
            return buyukDegerSay;
        }
        static int kucukDegerSay(string metin)
        {
            int kucukDegerSay = 0;
            foreach (char harf in metin)
            {
                if (char.IsLower(harf)) kucukDegerSay++;
            }
            return kucukDegerSay;
        }
        static int rakamSay(string metin)
        {
            int rakamSay = 0;
            foreach (char harf in metin)
            {
                if (char.IsDigit(harf)) rakamSay++;
            }
            return rakamSay;
        }
        static int boslukSay(string metin)
        {
            int boslukSay = 0;
            foreach (char harf in metin)
            {
                if (char.IsWhiteSpace(harf)) boslukSay++;
            }
            return boslukSay;
        }
        static int harfSay(string metin)
        {
            int harfSay = 0;
            foreach (char harf in metin)
            {
                if (char.IsLetter(harf)) harfSay++;
            }
            return harfSay;
        }
        static void birlestir(string ad, string soyad)
        {
            Console.WriteLine("Hoşgeldin " + ad + " " + soyad);
        }
        static bool MetinGecerliMi(string metin)
        {
            if (string.IsNullOrWhiteSpace(metin)) return false;
            if (metin.Length < 5) return false;
            if (harfSay(metin) == 0) return false;
            return true;
        }
    }
}

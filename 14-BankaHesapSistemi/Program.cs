using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_BankaHesapSistemi //Bu bir örnek senaryodur. Gerçek bir banka hesap sistemi değildir. Sadece kalıtım konusunu pekiştirmek amacıyla hazırlanmıştır.
{
    class BankaHesabi
    {
        public string HesapNo;
        public decimal Bakiye;
        public void ParaYatir(decimal tutar)
        {
            if (tutar <= 0)
            {
                Console.WriteLine("Lütfen geçerli bir tutar giriniz.");
                return;
            }
            Bakiye += tutar;
            Console.WriteLine($"Hesap No {HesapNo} \nBakiye{Bakiye}");
        }
        public virtual void ParaCek(decimal tutar)
        {
            if(tutar <= 0)
            {
                Console.WriteLine("Lütfen geçerli bir tutar giriniz.");
                return;
            }
            else if (tutar > Bakiye)
            {
                Console.WriteLine("Hesapta çekilecek tutar bulunmamaktadır");
            }
            else
            {
                Bakiye -= tutar;
                Console.WriteLine($"Hesap No {HesapNo} \nBakiye{Bakiye}");
            }
        }
    }
    class VadeliHesap : BankaHesabi
    {
        public override void ParaCek(decimal tutar)
        {
            decimal kesintiliTutar = tutar * 1.02m;

            if(kesintiliTutar <= 0)
            {
                Console.WriteLine("Geçersiz tutar");
                return;
            }
            else if(kesintiliTutar > Bakiye)
            {
                Console.WriteLine("Yetersiz bakiye");
                return;
            }
            else
            {
                Bakiye -= kesintiliTutar;
            }
            Console.WriteLine($"Kesintili tutar: {kesintiliTutar} - Yeni bakiye: {Bakiye}");
        }
    }
    class VadesizHesap : BankaHesabi
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hesap türü seçiniz: \n1 - Vadeli Hesap\n2 - Vadesiz Hesap");
            int hesapTur = Convert.ToInt32(Console.ReadLine());
            
            BankaHesabi hesap1 = new BankaHesabi();
            


            if (hesapTur == 1)
            {
                hesap1 = new VadeliHesap();
            }
            else if (hesapTur == 2)
            {
                hesap1 = new VadesizHesap();
            }
            else
            {
                Console.WriteLine("Girilen değer yanlış lütfen yeni değer giriniz");
                return;
            }
            Console.Write("Hesap numarasını giriniz: ");
            hesap1.HesapNo = Console.ReadLine();
            hesap1.Bakiye = 5000;

            Console.WriteLine("Hesap oluşturuldu. Hesap No: " + hesap1.HesapNo);
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: \n1. Para Yatır\n2. Para Çek");
            int secim = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-----------------------------");

            Console.WriteLine("Hesap No: " + hesap1.HesapNo);
            Console.WriteLine("Mevcut Bakiye: " + hesap1.Bakiye);
            decimal tutar;
            switch (secim)
            {
                case 1:
                    Console.Write("Yatırmak istediğiniz tutarı giriniz: ");
                    tutar = Convert.ToDecimal(Console.ReadLine());
                    hesap1.ParaYatir(tutar);
                    break;
                case 2:
                    Console.Write("Çekmek istediğiniz tutarı giriniz: ");
                    tutar = Convert.ToDecimal(Console.ReadLine());
                    hesap1.ParaCek(tutar);
                    break;
                default:
                    break;
            }
            Console.WriteLine("İşlem tamamlandı. Güncel Bakiye: " + hesap1.Bakiye);
            Console.WriteLine("Çıkmak için herhangi bir tuşa basınız...");
            Console.ReadKey();
        }   
    }
}

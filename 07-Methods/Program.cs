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
                //void, metotların geriye değer döndürmemesini sağlar.
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

    }
}

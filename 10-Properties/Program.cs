using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Properties //Özgenler - Properties
{
    class Skorlar
    {
        private int skor;
        public int Skor //Skor isminde property tanımladık
        {
            get { return skor; } // get bloğu return skor: deyimi ile private skor değişkenini okuyor ve çağrıldığı yere bu değeri dönüyor
            set { skor = value; } //set bloğu skor = value; deyimi ile sınıfın private değişkenine value değerini atıyor
        }
    }
    internal class Program
        {
            static void Main(string[] args)
            {
                Skorlar skorlar = new Skorlar();
                skorlar.Skor = 5;
                
                Console.WriteLine(skorlar.Skor);
                
                Kisi kisi= new Kisi();
                kisi.Ad = "Enes";
                kisi.Aktif = true;

                if (kisi.Aktif == true)
                {
                    Console.WriteLine($"Hoşgeldin {kisi.Ad}");
                }

                BankaHesabi hesap = new BankaHesabi();

                Console.WriteLine(hesap.Bakiye);
                hesap.ParaYatir(1000);
                Console.WriteLine(hesap.HesapOzeti);

            Console.Read();
            }
        }
}

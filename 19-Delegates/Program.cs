using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Delegates //Delegate = metot referansı tutan tip
{
    class Vergiler
    {
        public double BrutOku()
        {
            Console.Write("Brüt Gelirinizi giriniz: ");
            return Double.Parse(Console.ReadLine());
        }
        public double GelirVergisiHesapla(double d)
        {
            if (d > 5000) return d * 0.40;
            else return d * 0.25;
        }
    }
    public delegate void BasitDelege(); // delege tanımlaması
    public delegate void ParametreliDelege(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vergiler vergiler = new Vergiler();
            //Console.WriteLine("Ödeyeceğiniz vergi: " + vergiler.GelirVergisiHesapla(vergiler.BrutOku()));
            BasitDelege delege = new BasitDelege(Topla);
            delege();
            ParametreliDelege parametreliDelege = new ParametreliDelege(Cikar);
            parametreliDelege(110, 8);

            Console.ReadLine();
        }
        static void Topla()
        {
            Console.WriteLine("İşlem sonucu: " + (10 + 8));
        }
        static void Cikar(int x, int y)
        {
            Console.WriteLine("İşlem sonucu: " + (x - y));
        }
    }
}

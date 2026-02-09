using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Access_Modifiers
{
    internal class Program
    {
        public class deneme
        {
            public string UrunAdi = "public öğeye herkes erişebilir";
            private string urunAdi;
        }
        protected class test // Ait olduğu sınıftan ve o sınıftan türetilen sınıflardan erişebilir
        {
            private string UrunAdi;
        }
        internal class urun // internal erişim belirteci Etkin projeye ait sınıflardan erişilebilir, erişilemez
        {
            private string gizli = "Private yalnız bulunduğu sınıftan erişebilir, dıştaki sınıflardan erişilemez";
        }
        static void Main(string[] args)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.Adi = "Enes";
            kullanici.Soyadi = "Yerebakan";

            Console.WriteLine($"Kullanıcı adı: {kullanici.Adi}");
            Console.WriteLine($"Kullanıcı soyadı: {kullanici.Soyadi}");

            Console.Read();
        }
    }
}

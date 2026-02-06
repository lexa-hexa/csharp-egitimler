using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Classes
{
    internal class BankaHesabi
    {
        public string HesapNo;
        public decimal Bakiye;
        public bool ParaYatir(decimal tutar)
        {
            //Para yatırma işlemi
            if(tutar > 0)
            {
                Bakiye = Bakiye + tutar;
                Console.WriteLine("Para yatırma işleminiz gerçekleştirilmiştir");
                return true;
            }
            else Console.WriteLine("Yatıralacak min. değer 0'dan büyük olmalıdır."); return false;
        }
        public bool ParaCek(decimal tutar)
        {
            //Para çekme işlemi
            if(tutar <= 0)
            {
                Console.WriteLine("Çekilecek tutar 0'dan büyük olmalıdır.");
                return false;
            }
            if (Bakiye < tutar)
            {
                Console.WriteLine($"Para çekme işlemi başarısız, {Bakiye} tutarından fazlasını çekemezsiniz");
                return false;
            }
            else
            {
                Bakiye -= tutar;
                Console.WriteLine("İşleminiz gerçekleştiriliyor...");
                return true;
            }
        }

    }
}

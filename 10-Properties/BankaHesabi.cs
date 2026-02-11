using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Properties
{
    internal class BankaHesabi
    {
        private decimal bakiye;
        public decimal Bakiye 
        {
            get { return bakiye; }
            private set { bakiye = value; } 
        }

        public void ParaYatir(decimal tutar)
        {
            if (tutar <= 0)
                return;
            
        }

        public void ParaCek(decimal tutar)
        {
            if (tutar <= 0)
                return;
            if (tutar > Bakiye)
                return;

            Bakiye = Bakiye - tutar;
        }

        public bool LimitAsildiMi
        {
            get
            {
                return Bakiye < 0;
            }
        }

        public string HesapOzeti
        {
            get
            {
                //Kısa düzgün yazımı da mevcut
                //return $"Bakiye: {Bakiye} | Limit Aşıldı mı: {(LimitAsildiMi ? "Evet" : "Hayır")}";
                if (LimitAsildiMi == true)
                {
                    return "Evet";
                }
                else
                {
                    return "Hayır";
                }
                    
            }
        }
    }
}
